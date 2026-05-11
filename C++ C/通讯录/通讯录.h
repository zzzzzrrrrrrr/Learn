#pragma once

#include"顺序表.h"

#define NAME_MAX 20
#define GENDER_MAX 10
#define TEL_MAX 20
#define ADDR_MAX 100

typedef struct personinfo
{
	char name[NAME_MAX];
	char gender[GENDER_MAX];
	int age;
	char tel[TEL_MAX];
	char addr[ADDR_MAX];

}peoinfo;

typedef struct Seqlist Contact;

//通讯录初始化
void ContactInit(Contact* con);

//通讯录添加数据
void ContactAdd(Contact* con);

//通讯录删除数据
void ContactDel(Contact* con);

//通讯录的修改
void ContactModify(Contact* con);

//通讯录的查找
void ContactFind(Contact* con);

//展示通讯录数据
void ContactShow(Contact* con);

//通讯录销毁
void ContactDesTroy(Contact* con);
