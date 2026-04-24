#include<string>
#include<iostream>
using namespace std;
class Student_HWN;
class Course_ZR
{
protected:
    int course_num;//课程编号
    string course_name;//课程名称
    string course_nature;//课程性质		
    int all_hours;//课程总学时
    int teach_hours;//课程授课学时
    int practice_hours;//课程实践学时
    float credit;//课程学分
    string term;//开设学期
	string day;//课程开设在星期几
public:
    virtual void data_show()=0;//用于输出显示信息
    virtual void search_credit(float n)=0;//用于按学分查找课程信息
	virtual void search_nature()=0;//用于查找课程类型
	virtual void search_hours(int h)=0;//用于按总学时查找课程信息
	int get_course_num()
	{
		return course_num;
	}
	string get_course_name()
	{
		return course_name;
	}
	string get_course_nature()
	{
		return course_nature;
	}
	int get_all_hours()
	{
		return all_hours;
	}
	int get_teach_hours()
	{
		return teach_hours;
	}
	int get_practice_hours()
	{
		return practice_hours;
	}
	float get_credit()
	{
		return credit;
	}
	string get_term()
	{
		return term;
	}
	string get_day()
	{
		return day;
	}
    friend Student_HWN;
};