# 基于C++实现的学生选修课程系统

# 1.题目

**学生选修课程系统设计**

# 2.设计任务及要求
## 2.1 任务

假定有n门课程，每门课程有：课程编号，课程名称，课程性质(公共课、必修课、选修课)，总学时，授课学时，实验或上机学时，学分，开课学期等信息，学生可按要求（如总学分不得少于60）自由选课。试设计该选修课程系统。

## 2.2 要求

- 设计一个抽象类表示课程，包括课程最基本的属性和行为

- 在课程抽象类的基础上派生出选修课程类

- 设计一个学生类，表示某一个学生的选修课程的情况

- 用主程序模拟多个学生的选课过程

- 要求有文件支持选课内容的永久保存；使之能提供以下功能：
  - 系统以文本菜单方式工作
  - 对学生进行各种操作
  - 对课程信息进行各种操作

其中， 查询方式可按学分查询、按课程性质查询5、学生选修课程(可选项)。

# 3.软件环境及工具

- Microsoft Visual C++ 6.0

- Windows操作系统

# 4.课程设计内容

## 4.1 概要设计

### 4.1.1 类的介绍

**Course_ZR类**

主要功能是作为基类为子类的功能实现提供模板。

| Course_ZR                                |
| :--------------------------------------- |
| course_num、 course_name、 course_nature、 all_hours、 teach_hours、  practice_hours、 credit、 term |
| virtual void data_show()=0、   virtual void search_credit(float n)=0、  virtual void search_nature()=0、  virtual void search_hours(int h)=0;（纯虚函数）  get_course_num()函数、 get_course_name()函数、 get_course_nature()函数、          get_all_hours()函数、  get_teach_hours()函数、 get_practice_hours()函数、  get_credit()函数、get_term()函数、get_day()函数 |

**Public_course_ZR类**

主要功能为作为公共课信息储存和传递的接口。

| Public_course_ZR                         |
| :--------------------------------------- |
| course_num、 course_name、 course_nature、 all_hours、 teach_hours、practice_hours、 credit、 term、teacher |
| virtual void search_credit(float n);  virtual void search_nature();  virtual void search_hours(int h);  friend ostream & operator<<(ostream  &,Public_course_ZR &);  friend istream & operator>>(istream  &,Public_course_ZR &);  data_show()函数、 get_teacher()函数 |

**Required_course_ZR**

主要功能为作为必修课信息储存和传递的接口。

| **Required_course_ZR**                   |
| :--------------------------------------- |
| course_num、 course_name、 course_nature、 all_hours、 teach_hours、practice_hours、 credit、 term、teacher |
| virtual  void search_credit(float n);     virtual  void search_nature();     virtual  void search_hours(int h);        friend ostream &  operator<<(ostream &,Required_course_ZR &);        friend istream &  operator>>(istream &,Required_course_ZR &);         data_show()函数、  get_teacher()函数 |

**ElctiveCourse_HWN类**

主要功能为作为选修课信息储存和传递的接口。

| ElctiveCourse_HWN                        |
| :--------------------------------------- |
| course_num、 course_name、 course_nature、 all_hours、 teach_hours、practice_hours、 credit、 term、teacher |
| void search_credit(float n);//纯虚函数的实现  void  search_nature();  void search_hours(int h);  friend ostream & operator<<(ostream  &,ElctiveCourse_HWN &);  friend istream & operator>>(istream  &,ElctiveCourse_HWN &);   data_show ()函数、get_teacher()函数 |

**Student_HWN类**

主要功能为作为学生选课信息储存和传递的接口。

| Student_HWN                              |
| :--------------------------------------- |
| num、  Class、 name、    personal_num、personal_password |
| void delete_Publiccourse(int)、//退选相关函数  void delete_Requiredcourse(int)、  void delete_Elctivecourse(int)、          friend  ostream & operator<<(ostream &,Student_HWN &)、  friend istream & operator>>(istream  &,Student_HWN &)、       get_num()函数、get_Class()函数、get_name()函数、        get_personal_num()函数、   get_personal_password()函数 |

### 4.1.2 类间关系

![](http://www.writebug.com/myres/static/uploads/2021/10/19/22ee1cff23642af4d42f239811ccba94.writebug)

### 4.1.3对象字典

| 类名                 | 父类        | 提供的服务               | 需要的服务       |
| ------------------ | --------- | ------------------- | ----------- |
| Course_ZR          | 无         | 作为父类为子类的实现提供模板      | 无           |
| Student_HWN        | 无         | 作为存储学生对课程信  息的操作的存储 | 读取学生信息存储文档  |
| Public_course_ZR   | Course_ZR | 作为获取文档中有关公共课信息的媒介   | 读取公共课课程信息操作 |
| Required_course_ZR | Course_ZR | 作为获取文档中有关必修课信息的媒介   | 读取必修课课程信息操作 |
| ElctiveCourse_HWN  | Course_ZR | 作为获取文档中有关选修课信息的媒介   | 读取选修课课程信息操作 |

## 4.2 详细设计

### 4.2.1 Course_ZR类

![](http://www.writebug.com/myres/static/uploads/2021/10/19/bac90f16b3a8a71ff402e3620b4e37f3.writebug)

**属性介绍**

```c++
int course_num;        //表示课程的编号,用于体现课程信息
string course_name;    //表示课程的名称，用于体现课程信息
string  course_nature; //表示课程的性质（看是公共课，必修课，还是选修课），用于体现课程信息
int all_hours;         //表示课程的总学时，用于体现课程信息
int teach_hours;       //表示课程的授课学时，用于体现课程信息
int practice_hours;    //表示课程的实践学时，用于体现课程信息
float credit;          //表示课程的学分，用于体现课程信息
string term;           //表示课程开设在哪个学期，用于体现课程信息
string day;            //表示课程开设在星期几，用于体现课程信息
```

**接口**

- virtual void data_show()=0; 
  - 程序功能：作为所有信息的显示输出
  - 入口参数：无
  - 返回值： 无

- virtual void search_credit(float n)=0;
  - 程序功能：将符合学分为n的所有课程信息显示输出
  - 入口参数：n
  - 返回值： 无

- virtual void search_nature()=0; 
  - 程序功能：作为一个课程类型的所有课程信息的显示输出
  - 入口参数：无
  - 返回值： 无

- virtual void search_hours(int h)=0; 
  - 程序功能：作为所有信息的显示输出
  - 入口参数：无
  - 返回值： 无

- int get_course_num(){return course_num;} 
  - 程序功能：作为获取课程编号的接口
  - 入口参数：无
  - 返回值： course_num

- string get_course_name(){return course_name;} 
  - 程序功能：作为获取课程名称的接口
  - 入口参数：无
  - 返回值： course_name

- string get_course_nature(){return course_nature;} 
  - 程序功能：作为获取课程性质的接口
  - 入口参数：无
  - 返回值： course_nature

- int get_all_hours(){return all_hours;} 
  - 程序功能：作为获取课程总学时的接口
  - 入口参数：无
  - 返回值： all_hours

- int get_teach_hours(){return teach_hours;} 
  - 程序功能：作为获取课程授课学时的接口
  - 入口参数：无
  - 返回值： teach_hours

- int get_practice_hours(){return practice_hours;} 
  - 程序功能：作为获取课程实验或上机学时的接口
  - 入口参数：无
  - 返回值： practice_hours

- float get_credit(){return credit;} 
  - 程序功能：作为获取课程学分的接口
  - 入口参数：无
  - 返回值： credit

- string get_term(){return term;} 
  - 程序功能：作为获取课程学期的接口
  - 入口参数：无
  - 返回值： term

- string get_day(){return day;} 
  - 程序功能：作为获取课程日期的接口
  - 入口参数：无
  - 返回值： day

### 4.2.2 Public_course_ZR类

![](http://www.writebug.com/myres/static/uploads/2021/10/19/20ffd7aeca257aa214125c3b20e7aa40.writebug)

**属性介绍**

```c++
int course_num;         //表示公共课的编号,用于体现课程信息
string course_name;     //表示公共课的名称，用于体现课程信息
string  course_nature;  //表示公共课，用于体现课程信息
int all_hours;          //表示公共课的总学时，用于体现课程信息
int teach_hours;        //表示公共课的授课学时，用于体现课程信息
int practice_hours;     //表示公共课的实践学时，用于体现课程信息
float credit;           //表示公共课的学分，用于体现课程信息
string term;            //表示公共课开设在哪个学期，用于体现课程信息
string day;             //表示公共课开设在星期几，用于体现课程信息
string teacher;         //表示课程的老师是谁，用于学生选课时候得知该门  课程的授课老师的信息
```

**接口**

- void data_show() 
  - 程序功能：作为Public_course_ZR类对象的信息显示输出
  - 入口参数：无
  - 返回值： 无

- virtual void search_credit(float n); 
  - 程序功能：筛选出Public_course_ZR类对象符合学分要求的信息显示输出
  - 入口参数：n
  - 返回值： 无

- virtual void search_nature(); 
  - 程序功能：Public_course_ZR类对象所有的信息显示输出
  - 入口参数：无
  - 返回值： 无

- virtual void search_hours(int h); 
  - 程序功能：Public_course_ZR类对象所有符合总学时要求的信息显示输出
  - 入口参数：h
  - 返回值： 无

- string get_teacher(){return teacher;} 
  - 程序功能：Public_course_ZR类对象所有教师信息获取接口
  - 入口参数：无
  - 返回值： teacher

- ostream & operator<<(ostream &output,Public_course_ZR &a) 
  - 程序功能：对“<<”重载输出Public_course_ZR类对象
  - 入口参数：&output,&a
  - 返回值： output

- istream & operator>>(istream &input,Public_course_ZR &a) 
  - 程序功能：对“>>”重载输入Public_course_ZR类对象
  - 入口参数：&input,&a
  - 返回值： input

### 4.2.3 Required_course_ZR类

![](http://www.writebug.com/myres/static/uploads/2021/10/19/bdb63c75bb64620ff49ffe36d0cffcf1.writebug)

**属性介绍**

```c++
int course_num;         //表示必修课的编号,用于体现课程信息
string course_name;     //表示必修课的名称，用于体现课程信息
string  course_nature;  //表示必修课，用于体现课程信息
int all_hours;          //表示必修课的总学时，用于体现课程信息
int teach_hours;        //表示必修课的授课学时，用于体现课程信息
int practice_hours;     //表示必修课的实践学时，用于体现课程信息
float credit;           //表示必修课的学分，用于体现课程信息
string term;            //表示必修课开设在哪个学期，用于体现课程信息
string day;             //表示必修课开设在星期几，用于体现课程信息
string teacher;         //表示课程的老师是谁，用于学生选课时候得知该门课程的授课老师的信息
```

**接口**

- void data_show() 
  - 程序功能：Required_course_ZR类对象所有信息显示输出
  - 入口参数：无
  - 返回值： 无

- virtual void search_credit(float n); 
  - 程序功能：筛选出Required_course_ZR对象符合学分要求的信息显示输出
  - 入口参数：n
  - 返回值： 无

- virtual void search_nature(); 
  - 程序功能：Required_course_ZR类对象所有的信息显示输出
  - 入口参数：无
  - 返回值： 无

- virtual void search_hours(int h); 
  - 程序功能：Required_course_ZR类对象所有符合总学时要求的信息显示输出
  - 入口参数：h
  - 返回值： 无

- string get_teacher(){return teacher;} 
  - 程序功能：Required_course_ZR类对象所有教师信息获取接口
  - 入口参数：无
  - 返回值： teacher

- ostream & operator<<(ostream &output,Required_course_ZR &a) 
  - 程序功能：对“<<”重载输出Required_course_ZR类对象
  - 入口参数：&output,&a
  - 返回值： output

- istream & operator>>(istream &input,Required_course_ZR &a) 
  - 程序功能：对“>>”重载输入Required_course_ZR类对象
  - 入口参数：&input,&a
  - 返回值： input

### 4.2.4 ElctiveCourse_HWN类

![](http://www.writebug.com/myres/static/uploads/2021/10/19/55943c3be52694da946c59a1220e2441.writebug)

**属性介绍**

```c++
int course_num;         //表示选修课的编号,用于体现课程信息
string course_name;     //表示选修课的名称，用于体现课程信息
string  course_nature;  //表示选修课，用于体现课程信息
int all_hours;          //表示选修课的总学时，用于体现课程信息
int teach_hours;        //表示选修课的授课学时，用于体现课程信息
int practice_hours;     //表示选修课的实践学时，用于体现课程信息
float credit;           //表示必修课的学分，用于体现课程信息
string term;            //表示选修课开设在哪个学期，用于体现课程信息
string day;             //表示选修课开设在星期几，用于体现课程信息
string teacher;         //表示课程的老师是谁，用于学生选课时候得知该门课程的授课老师的信息
```

**接口**

- void data_show() 
  - 程序功能：ElctiveCourse_HWN 类对象所有信息显示输出
  - 入口参数：无
  - 返回值： 无

- virtual void search_credit(float n); 
  - 程序功能：筛选出ElctiveCourse_HWN对象符合学分要求的信息显示输出
  - 入口参数：n
  - 返回值： 无

- virtual void search_nature(); 
  - 程序功能：ElctiveCourse_HWN类对象所有的信息显示输出
  - 入口参数：无
  - 返回值： 无

- virtual void search_hours(int h); 
  - 程序功能：ElctiveCourse_HWN类对象所有符合总学时要求的信息显示输出
  - 入口参数：h
  - 返回值： 无

- string get_teacher(){return teacher;} 
  - 程序功能：ElctiveCourse_HWN类对象所有教师信息获取接口
  - 入口参数：无
  - 返回值： teacher

- ostream & operator<<(ostream & output,ElctiveCourse_HWN &EC ) 
  - 程序功能：对“<<”重载输出ElctiveCourse_HWN类对象
  - 入口参数：&output,&EC
  - 返回值： output

- istream & operator>>(istream &input,ElctiveCourse_HWN &a) 
  - 程序功能：对“>>”重载输入ElctiveCourse_HWN类对象
  - 入口参数：&input,&a
  - 返回值： input

### 4.2.5 Student_HWN类

![](http://www.writebug.com/myres/static/uploads/2021/10/19/26daa3209b8be1e44246c212bb356ea6.writebug)

**属性介绍**

```c++
Public_course_ZR Pu[5];    //表示一个公共课对象数组，用于存储学生的对公共课的相关操作（选课，查看或者退课）
Required_course_ZR Re[5];  //表示一个必修课对象数组，用于存储学生对必修课的相关操作选课，查看或者退课）
ElctiveCourse_HWN El[5];   //表示一个选修课对象数组，用于存储学生的对公共课的相关操作（选课，查看或者退课）
int num;                   //表示该学生的学号，用于表现学生的信息
string Class;              //表示该学生的班级，用于表现学生的信息
string name;               //表示该学生的名字，用于表现学生的信息
int personal_num;          //表示学生的个人学号，用于登录时候与输入的学号进行比对
int personal_password;     //表示学生的密码，用于登录时候与输入的密码进行比对
```

**接口**

- void Student_HWN::delete_Publiccourse(int a) 
  - 程序功能：筛选出要退选的公共课对象信息并删除
  - 入口参数：a
  - 返回值： 无

- void Student_HWN::delete_Requiredcourse(int a) 
  - 程序功能：筛选出要退选的必修课对象信息并删除
  - 入口参数：a
  - 返回值： 无

- void Student_HWN::delete_Elctivecourse(int a) 
  - 程序功能：筛选出要退选的选修课对象信息并删除
  - 入口参数：a
  - 返回值： 无

- int get_num(){return num;} 
  - 程序功能：作为获取学生学号信息的接口
  - 入口参数：无
  - 返回值： num

- string get_Class(){return Class;} 
  - 程序功能：作为获取学生所在班级信息的接口
  - 入口参数：无
  - 返回值： Class

- string get_name(){return name;} 
  - 程序功能：作为获取学生姓名信息的接口
  - 入口参数：无
  - 返回值：name

- int get_personal_num(){return personal_num;} 
  - 程序功能：作为获取学生登录学号信息的接口
  - 入口参数：无
  - 返回值：personal_num

- int get_personal_password(){return personal_password;} 
  - 程序功能：作为获取学生登录密码信息的接口
  - 入口参数：无
  - 返回值：personal_password

- ostream & operator<<(ostream &output,Student_HWN &a) 
  - 程序功能：对“<<”重载输出Student_HWN类对象
  - 入口参数：&output,&a
  - 返回值： output

- istream & operator>>(istream &input,Student_HWN &a) 
  - 程序功能：对“>>”重载输入Student_HWN类对象
  - 入口参数：&input,&a
  - 返回值： input

# 5.调试与测试

## 5.1 测试

### 5.1.1 密码登录界面

- 测试学号：160708283

- 测试密码：123456

![](http://www.writebug.com/myres/static/uploads/2021/10/19/fd2205fca738d8d4867ee2c2cf7ce4c5.writebug)

### 5.1.2 必修课界面

![](http://www.writebug.com/myres/static/uploads/2021/10/19/89c694d14255d7b9430fdb16087aeff4.writebug)

进入大学英语界面后进行浏览

![](http://www.writebug.com/myres/static/uploads/2021/10/19/bd6c56064f4d3f7cb88ae981525599d6.writebug)

## 5.2 系统遗留问题

- 在进行退选时候，应该再次让用户考虑一下是否真的进行退选，然后再进行退选。

- 当输入编号不存在的情况时，并没有很好的解决问题

选择的课程编号不存在：

最后没出现“没有该门课程，请重新选择”的语句报错，而是直接加了第一门课程编号。

输入编号为  201751 

![](http://www.writebug.com/myres/static/uploads/2021/10/19/ea9a8668fa1139d82e0d6fdf067b45e5.writebug)

![](http://www.writebug.com/myres/static/uploads/2021/10/19/c1665abedf2d0c06ea12354df2525d15.writebug)

- 好像如果连着输入的编号是已选或者跟那个已选课程的日期有冲突的话会出现死循环，会出现“该课程与所选课程日期冲突，请重新输入”，无论是不是冲突了

# 6.设计心得与总结

这次作为第二次的课程设计学习，收获还是很大的，很明显感觉到自己在写代码方面的进步，无论是写起来更加顺手了还是在思考上逻辑更加通畅了，这些进步都是能够鼓励我更加认真去完成项目的动力。这次的活动也算是让我有点感受到了“熟能生巧”的含义。但是这次的突破并不是很明显，在程序的内容上有些进步但是外观以及操作上还是没有什么提高。也许是和熟悉的伙伴合作的原因，这次做起项目来需要磨合的也少，所以工作效率比较高，项目进展也算比较顺利的，没有遇到什么很大的问题。很有意义的一次活动，也提升了我们彼此之间的默契。