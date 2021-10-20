# QxwUnityLearn
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
