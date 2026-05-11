#define _CRT_SECURE_NO_WARNINGS

#include"顺序表.h"
#include"通讯录.h"

//顺序表初始化
void SLInit(SL* ps)
{
	ps->arr = NULL;
	ps->size = ps->capacity = 0;
}

//顺序表销毁
void SLDestTroy(SL* ps)
{
	if (ps->arr)
	{
		free(ps->arr);
	}
	ps->arr = NULL;
	ps->size = ps->capacity = 0;
}

//尾插
void SLPushBack(SL* ps, SLdatatype x)
{
	//	if (ps == NULL)
	//	{
	//		return;
	//	}
	assert(ps);//assert(ps != NULL)
	//SLCheckCapacity(ps);
	ps->arr[ps->size++] = x;
}

//指定位置之前删除数据
void SLErase(SL* ps, int pos)
{
	assert(ps);
	assert(pos >= 0 && pos < ps->size);
	for (int i = pos; i <= ps->size - 1; i++)
	{
		ps->arr[i] = ps->arr[i + 1];
	}
	ps->size--;
}
