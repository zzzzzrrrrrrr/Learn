#define _CRT_SECURE_NO_WARNINGS

#include"顺序表.h"
#include"通讯录.h"
#include<string.h>

//通讯录初始化
void ContactInit(Contact* con)
{
	SLInit(con);
}

//通讯录添加数据
void ContactAdd(Contact* con)
{
	peoinfo info;
	printf("请输入要添加的姓名：\n");
	scanf("%s", info.name);

	printf("请输入要添加的性别：\n");
	scanf("%s", info.gender);

	printf("请输入要添加的年龄：\n");
	scanf("%d", &info.age);

	printf("请输入要添加的电话：\n");
	scanf("%s", info.tel);

	printf("请输入要添加的地址：\n");
	scanf("%s", info.addr);
}

//查找数据
int Contactfind(Contact* con,char name[])
{
	for (int i = 0; i < con->size; i++)
	{
		if (0 == strcmp(con->arr[i].name, name))
		{
			return i;
		}
	}
	return -1;
}

//通讯录删除数据
void ContactDel(Contact* con)
{
	char name[NAME_MAX];
	printf("请输入要删除的姓名：");
	scanf("%s", name);
	Contactfind(con,name);
	int find = Contactfind(con, name);
	if (find < 0)
	{
		printf("要删除的联系人数据不存在\n");
		return;
	}
	SLErase(con, find);
	printf("删除成功\n");
}

//通讯录的修改
void ContactModify(Contact* con)
{
	char name[NAME_MAX];
	printf("请输入要修改的姓名：");
	scanf("%s", name);
	Contactfind(con, name);
	int find = Contactfind(con, name);
	if (find < 0)
	{
		printf("要修改的联系人姓名不存在：\n");
		return;
	}
	printf("请输入要修改的新联系人：");
	scanf("%s %s %d %s %s",con->arr[find].name,con->arr[find].name, &con->arr[find].age, con->arr[find].tel, con->arr[find].addr);
}

//通讯录的查找
void ContactFind(Contact* con)
{
	char name[NAME_MAX];
	int find = Contactfind(con,name);
	if (find > 0)
		printf("%s %s %d %s %s",con->arr[find].name,con->arr[find].gender,con->arr[find].age,con->arr[find].tel,con->arr[find].addr);
	else
		printf("没找到\n");
}

//展示通讯录数据
void ContactShow(Contact* con)
{
	printf("%s %s %s %s %s\n", "姓名", "性别","年龄","电话","地址");
	for (int i = 0;i < con -> size; i++)
	{
		printf("%s %s %d %s %s\n", con->arr[i].name, con->arr[i].gender, con->arr[i].age, con->arr[i].tel, con->arr[i].addr);
	}
}

//通讯录销毁
void ContactDesTroy(Contact* con)
{
	SLDestTroy(con);
}
