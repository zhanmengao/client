#include "main.h"
#include "Tools.h"
#define NUM_SPHERES 50
GLFrame spheres[NUM_SPHERES];

GLShaderManager		shaderManager;			// Shader Manager
GLMatrixStack		modelViewMatrix;		// Modelview Matrix
GLMatrixStack		projectionMatrix;		// Projection Matrix
GLFrustum			viewFrustum;			// View Frustum
GLGeometryTransform	transformPipeline;		// Geometry Transform Pipeline
GLFrame				cameraFrame;			// Camera frame

GLTriangleBatch		torusBatch;
GLTriangleBatch		sphereBatch;
GLBatch				floorBatch;

GLuint				uiTextures[3];

//绘制sphere
void DrawSongAndDance(GLfloat yRot)
{
	static GLfloat vWhite[] = { 1.0f, 1.0f, 1.0f, 1.0f };
	static GLfloat vLightPos[] = { 0.0f, 3.0f, 0.0f, 1.0f };

	// Get the light position in eye space
	M3DVector4f	vLightTransformed;
	M3DMatrix44f mCamera;
	modelViewMatrix.GetMatrix(mCamera);
	m3dTransformVector4(vLightTransformed, vLightPos, mCamera);

	// Draw the light source
	modelViewMatrix.PushMatrix();
	modelViewMatrix.Translatev(vLightPos);
	shaderManager.UseStockShader(GLT_SHADER_FLAT,
		transformPipeline.GetModelViewProjectionMatrix(),
		vWhite);
	sphereBatch.Draw();
	modelViewMatrix.PopMatrix();

	glBindTexture(GL_TEXTURE_2D, uiTextures[2]);
	for (int i = 0; i < NUM_SPHERES; i++) {
		modelViewMatrix.PushMatrix();
		modelViewMatrix.MultMatrix(spheres[i]);
		shaderManager.UseStockShader(GLT_SHADER_TEXTURE_POINT_LIGHT_DIFF,
			modelViewMatrix.GetMatrix(),
			transformPipeline.GetProjectionMatrix(),
			vLightTransformed,
			vWhite,
			0);
		sphereBatch.Draw();
		modelViewMatrix.PopMatrix();
	}

	// Song and dance
	modelViewMatrix.Translate(0.0f, 0.2f, -2.5f);
	modelViewMatrix.PushMatrix();	// Saves the translated origin
	modelViewMatrix.Rotate(yRot, 0.0f, 1.0f, 0.0f);

	// Draw stuff relative to the camera
	glBindTexture(GL_TEXTURE_2D, uiTextures[1]);
	shaderManager.UseStockShader(GLT_SHADER_TEXTURE_POINT_LIGHT_DIFF,
		modelViewMatrix.GetMatrix(),
		transformPipeline.GetProjectionMatrix(),
		vLightTransformed,
		vWhite,
		0);
	torusBatch.Draw();
	modelViewMatrix.PopMatrix(); // Erased the rotate

	modelViewMatrix.Rotate(yRot * -2.0f, 0.0f, 1.0f, 0.0f);
	modelViewMatrix.Translate(0.8f, 0.0f, 0.0f);

	glBindTexture(GL_TEXTURE_2D, uiTextures[2]);
	shaderManager.UseStockShader(GLT_SHADER_TEXTURE_POINT_LIGHT_DIFF,
		modelViewMatrix.GetMatrix(),
		transformPipeline.GetProjectionMatrix(),
		vLightTransformed,
		vWhite,
		0);
	sphereBatch.Draw();
}

void SetupRC()
{
	glewInit();
	shaderManager.InitializeStockShaders();

	glEnable(GL_DEPTH_TEST);
	glEnable(GL_CULL_FACE);

	glClearColor(0.0f, 0.0f, 0.0f, 1.0f);

	// This makes a torus
	gltMakeTorus(torusBatch, 0.4f, 0.15f, 40, 20);

	// This makes a sphere
	gltMakeSphere(sphereBatch, 0.1f, 26, 13);


	// Make the solid ground
	GLfloat texSize = 10.0f;
	floorBatch.Begin(GL_TRIANGLE_FAN, 4, 1);
	floorBatch.MultiTexCoord2f(0, 0.0f, 0.0f);
	floorBatch.Vertex3f(-20.0f, -0.41f, 20.0f);

	floorBatch.MultiTexCoord2f(0, texSize, 0.0f);
	floorBatch.Vertex3f(20.0f, -0.41f, 20.0f);

	floorBatch.MultiTexCoord2f(0, texSize, texSize);
	floorBatch.Vertex3f(20.0f, -0.41f, -20.0f);

	floorBatch.MultiTexCoord2f(0, 0.0f, texSize);
	floorBatch.Vertex3f(-20.0f, -0.41f, -20.0f);
	floorBatch.End();

	// Make 3 texture objects
	glGenTextures(3, uiTextures);

	// Load the Marble
	glBindTexture(GL_TEXTURE_2D, uiTextures[0]);
	LoadTGATexture("marble.tga", GL_LINEAR_MIPMAP_LINEAR, GL_LINEAR, GL_REPEAT);

	// Load Mars
	glBindTexture(GL_TEXTURE_2D, uiTextures[1]);
	LoadTGATexture("marslike.tga", GL_LINEAR_MIPMAP_LINEAR,
		GL_LINEAR, GL_CLAMP_TO_EDGE);

	// Load Moon
	glBindTexture(GL_TEXTURE_2D, uiTextures[2]);
	LoadTGATexture("moonlike.tga", GL_LINEAR_MIPMAP_LINEAR,
		GL_LINEAR, GL_CLAMP_TO_EDGE);

	// Randomly place the spheres
	for (int i = 0; i < NUM_SPHERES; i++)
	{
		GLfloat x = ((GLfloat)((rand() % 400) - 200) * 0.1f);
		GLfloat z = ((GLfloat)((rand() % 400) - 200) * 0.1f);
		spheres[i].SetOrigin(x, 0.0f, z);
	}
}


void ShutdownRC(void)
{
	glDeleteTextures(3, uiTextures);
}
void OnDrawBegin()
{
	glClear(GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT);
	modelViewMatrix.PushMatrix();
	M3DMatrix44f mCamera;
	cameraFrame.GetCameraMatrix(mCamera);
	modelViewMatrix.MultMatrix(mCamera);
}

void Draw()
{
	static CStopWatch	rotTimer;
	float yRot = rotTimer.GetElapsedSeconds() * 60.0f;

	//绘制倒影
	modelViewMatrix.PushMatrix();
	modelViewMatrix.Scale(1.0f, -1.0f, 1.0f); // Flips the Y Axis
	modelViewMatrix.Translate(0.0f, 0.8f, 0.0f); // Scootch the world down a bit...
	glFrontFace(GL_CW);
	DrawSongAndDance(yRot);
	glFrontFace(GL_CCW);
	modelViewMatrix.PopMatrix();

	//绘制大理石地面
	glEnable(GL_BLEND);
	glBindTexture(GL_TEXTURE_2D, uiTextures[0]);
	glBlendFunc(GL_SRC_ALPHA, GL_ONE_MINUS_SRC_ALPHA);
	static GLfloat vFloorColor[] = { 1.0f, 1.0f, 1.0f, 0.75f };
	shaderManager.UseStockShader(GLT_SHADER_TEXTURE_MODULATE,
		transformPipeline.GetModelViewProjectionMatrix(),
		vFloorColor, 0);
	floorBatch.Draw();

	glDisable(GL_BLEND);

	//绘制物体本身
	DrawSongAndDance(yRot);
}
void OnDrawEnd()
{
	modelViewMatrix.PopMatrix();

	// Do the buffer Swap
	glutSwapBuffers();

	// Do it again
	glutPostRedisplay();
}
void RenderScene(void)
{
	OnDrawBegin();
	Draw();
	OnDrawEnd();
}


void SpecialKeys(int key, int x, int y)
{
	float linear = 0.1f;
	float angular = float(m3dDegToRad(5.0f));

	if (key == GLUT_KEY_UP)
		cameraFrame.MoveForward(linear);

	if (key == GLUT_KEY_DOWN)
		cameraFrame.MoveForward(-linear);

	if (key == GLUT_KEY_LEFT)
		cameraFrame.RotateWorld(angular, 0.0f, 1.0f, 0.0f);

	if (key == GLUT_KEY_RIGHT)
		cameraFrame.RotateWorld(-angular, 0.0f, 1.0f, 0.0f);
}


void ChangeSize(int nWidth, int nHeight)
{
	glViewport(0, 0, nWidth, nHeight);
	transformPipeline.SetMatrixStacks(modelViewMatrix, projectionMatrix);

	viewFrustum.SetPerspective(35.0f, float(nWidth) / float(nHeight), 1.0f, 100.0f);
	projectionMatrix.LoadMatrix(viewFrustum.GetProjectionMatrix());
	modelViewMatrix.LoadIdentity();
}

int main(int argc, char* argv[])
{
	gltSetWorkingDirectory(argv[0]);

	glutInit(&argc, argv);
	glutInitDisplayMode(GLUT_DOUBLE | GLUT_RGB | GLUT_DEPTH);
	glutInitWindowSize(800, 600);

	glutCreateWindow("OpenGL SphereWorld");

	glutReshapeFunc(ChangeSize);
	glutDisplayFunc(RenderScene);
	glutSpecialFunc(SpecialKeys);

	SetupRC();
	glutMainLoop();
	ShutdownRC();
	return 0;
}