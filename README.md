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
 void Update()
    {
        Movement();  //引用Movement
    }
    void Movement()
    {
        float horizontalmove;//定义移动的值
        horizontalmove= Input.GetAxis("Horizontal");//获取输入的值-1.0.1
        songshu.velocity = new Vector2(horizontalmove * speed, songshu.velocity.y);//给 rigidbady赋予值的变化，使得其移动
    }
```
> 关键内容 
> +  **Horizontal**，unity封装的移动方向的值
> + **Velocity**  ， 速度，赋予rigidbady速度的量
> + *Vector2* ,二维向量，包含 float的x和y
