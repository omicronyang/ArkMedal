# ArkMedal
《明日方舟》蚀刻章套组图片合成工具

## 环境需求
.Net Framework 4.6.1

## 使用方式

### 1. 使用 [AssetStudio](https://github.com/Perfare/AssetStudio) 导出资源

请使用 **v0.15** 版本及以上的AssetStudio，否则无法将MonoBehaviour导出成json文件

包含两组Sprite文件：

- 活动蚀刻章：Android/spritepack/ui_medal_icon_list_h1_<活动名称>.ab
- 蚀刻章套组背景：Android/spritepack/ui_medal_diy_frame_bkg_h1_0.ab

一组MonoBehaviour定义文件：

- 蚀刻章套组位置定义：Android/ui/medal/groupframe.ab
- 由于每套组的定义文件导出名均相同，可能需要自行重命名以便区分

导出时请将导出至同一位置，AssetStudio会在该位置下自动生成MonoBehaviour文件夹和Sprite文件夹，并将对应文件放置其中

### 2. 使用ArkMedal合成并导出

打开 ArkMedal，点击工作目录右侧“浏览”按钮，将工作目录设置在上一步的导出目录中，如果设置正确，下面的定义文件列表将自动显示已导出的文件

在定义文件列表中选择欲合成的文件，下方资源列表会显示该定义文件中的资源列表。如有资源缺失，会在错误列表中显示

定义文件或资源文件在程序外部更新后，可以点击对应位置的“刷新”按钮重新加载

套组名称默认为背景图的定义名称，可以自行更改