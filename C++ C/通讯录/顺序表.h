#pragma once

#include"通讯录.h"
#include<stdio.h>
#include<stdlib.h>
#include<assert.h>

typedef peoinfo SLdatatype;

typedef struct Seqlist
{
	SLdatatype* arr;
	int size;
	int capacity;
}SL;

//顺序表初始化
void SLInit(SL* ps);

//销毁
void SLDestTroy(SL* ps);

//尾插
void SLPushBack(SL* ps, SLdatatype x);

//指定位置之前删除数据
void SLErase(SL* ps, int pos);
