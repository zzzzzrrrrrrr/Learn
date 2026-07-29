#include<iostream>

/*//域
namespace begin
{
	//int rand = 10;
	int rand = 10;

	int Add(int left, int right)
	{
		return left + right;
	}

	struct Node
	{
		struct Node* next;
		int val;
	};
}

//int a = 0;

int main()
{
	//printf("%p\n", rand);
	//printf("%d\n", begin::rand);
	//int a = 1;
	//printf("%d\n", a);

	//::域作用限定符
	//printf("%d\n", ::a);

	//printf("%d\n", begin::rand);
	printf("%d\n", begin::Add(1, 1));

	struct begin::Node* p1;

	return 0;
}*/

using namespace std;

/*int main()
{
	//int i = 1234;
	//int j = -1234;
	//std::cout << i << endl;
	//using 展开std就可以不用指定命名空间
	//cout << i << endl;

	int a = 0;
	double b = 0.1;
	char c = 'x';

	cout << a << "" << b << "" << c << endl;
	cin >> a >> b >> c;

	
	return 0;
}*/

void Func(int a = 0)
{
	cout << a << endl;
}

void Func1(int a = 10,int b = 20, int c = 30)
{
	cout << "a = " << a << endl;
	cout << "b = " << b << endl;
	cout << "c = " << c << endl << endl;;
}

void Func2(int a = 1, int b = 2, int c = 3)
{
	cout << "a = " << a << endl;
	cout << "b = " << b << endl;
	cout << "c = " << c << endl << endl;
}

int Add(int left,int right)
{
	cout << "int Add(int left,int right)" << endl;
	return left + right;
}

double Add(double left, double right)
{	
	cout << "double Add(double left,double right)" << endl;
	return left + right;
}

typedef struct Listnode
{
	int val;
	struct Listnode* next;
}LTnode, * Pnode;

//void Listpushback(LTnode*& phead, int x)
void Listpushback(Pnode& phead, int x)
{
	Pnode newnode = (Pnode)malloc(sizeof(LTnode));
	newnode->val = x;
	newnode->next = NULL;
	if (phead == NULL)
	{
		phead = newnode;
	}

}

//全缺省和半缺省
int main()
{
	Func();
	Func(10);

	Func1();
	Func1(1);
	Func1(1, 2);
	Func1(1, 2, 3);
	
	Func2();
	Func2(100);
	Func2(100, 200);
	Func2(100, 200, 300);

	Add(1, 2);
	Add(1.1, 2.2);

	Pnode plist = NULL;
	Listpushback(plist, 2);
}