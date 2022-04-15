#UnityLearn
**unity学习**
### 21.10.19 内容
+ 添加2d unity学习项目
+ 添加2d动画骨骼历项目
### 
---
### 21.10.20内容
+ 搭建了初版本的地图关卡
+ 实现了角色的左右移动功能
```c#
 void FixedUpdate()
    {
        Movement();  //引用Movement
    }
    void Movement()
    {
        float horizontalmove = Input.GetAxis("Horizontal");//给控制朝向的变量赋值
        float faceorientation = Input.GetAxisRaw("Horizontal");//给移动的变量赋值
	
        if(horizontalmove != 0){
        songshu.velocity = new Vector2(horizontalmove * speed, songshu.velocity.y);//给 rigidbady赋予值的变化，使得其移动
        }
        if (faceorientation != 0)
        {
            transform.localScale = new Vector3(faceorientation, 1, 1);//transfrom获取scale的值，x.z轴保持1不变
        }
       
    }
```
> 关键内容 
> +  **Horizontal**，unity封装的移动方向的值
> + **Velocity**  ， 速度，赋予rigidbady速度的量
> + *Vector2* ,二维向量，包含 float的x和y
> + *Vector3*，三维向量。包含x，y，z
> ### GetAxis和GetAxisRaw的区别
> + GetAxis是在—1到1之间慢慢增加
> + GetAxisRaw是获取坐标-1,0,1三个固定的值
----
### 21.10.21内容
+ 跳跃程序出现问题，Update和FixedUpdate的用法区别在但用或混用都会出现跳跃不触发or触发离谱的情况
	+ 当移动和跳跃全部都放在FixedUpdate中时，跳跃可能不触发
	+ 全都放在Update中，在FixedUpdate写触发检测，也会出现跳跃高度的bug
+ 解决了移动漂移的问题,移动不再进行判断，精简了代码：
```C#
        float horizontalmove = Input.GetAxis("Horizontal");
        float faceorientation = Input.GetAxisRaw("Horizontal");
        
        songshu.velocity = new Vector2(horizontalmove * speed * Time.deltaTime, songshu.velocity.y);
        
        if (faceorientation != 0)
        {
            transform.localScale = new Vector3(faceorientation, 1, 1);
```

---
### 21.10.22内容
+ 添加小松鼠跑动动画
+ 待机动画
+ Animator组件熟悉
```C#
public Animator Animator;//定义插槽


Animator.SetFloat("running", Mathf.Abs(faceorientation));//获取动画状态转换数值
```
SetFloat(int/string,float value)获取一个浮点数的值
Animator.SetFloat 从Animator组件中获取这个值
Mathf 数学运算，提供数学计算的函数与常量
Mathf.Abs() 取绝对值，因为动画状态不能为复，移动有复数存在，所以取faceorientation的绝对值
##### Animator组件
+ parameters触发方式：Float、int、bool、tigger
+ Base Layer 里通过Make Transition状态转换机制
+ Conditions调整触发数
---
### 21.10.24内容
+	添加跳跃动画，跳跃动画分为两种状态，起跳和落下
+	跳跃动画parameters的触发方式为bool值，
~~~C#
Animator.Setbool("jumping", ture);//跳跃状态为布尔值
~~~


