#define _CRT_SECURE_NO_WARNINGS

#include"顺序表.h"
#include "通讯录.h"

//测试通讯录
/*void Contacttest01()
{
	Contact con;
	//通讯录初始化
	ContactInit(&con);

	//通讯录添加数据
	ContactAdd(&con);

	//通讯录删除数据
	ContactDel(&con);

	//通讯录的修改
	ContactModify(&con);

	//展示通讯录数据
	ContactShow(&con);

	//通讯录销毁
	ContactDesTroy(&con);
}*/

void menu()
{
	printf("****1.增加联系人   2.删除联系人  ****\n");
	printf("****3.查找联系人   4.修改联系人  ****\n");
	printf("****5.展示通讯录   6.销毁通讯录  ****\n");
	printf("****        0.退出程序           ****\n");
}

int main()
{
	int n;
	Contact con;
	//Contacttest01();
	menu();
	do{
		scanf("%d", &n);
		switch (n)
		{
		case 1:
			ContactAdd(&con);
			break;
		case 2:
			ContactDel(&con);
			break;
		case 3:
			ContactFind(&con);
			break;
		case 4:
			ContactModify(&con);
			break;
		case 5:
			ContactShow(&con);
			break;
		case 6:
			ContactDesTroy(&con);
			break;
		case 0:
			printf("程序已退出\n");
			break;
		default:
			printf("选择错误，请重新选择！\n");
			break;
		}
	} while (n != 0);

	return 0;
}

