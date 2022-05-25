Lighting:
-----------
1)Build Settings=> Switch to android Platform
2)Build Settings=> Player Settings => Resolution and Presentation =>Orientation = Portrait,go to other settings=> Color Space=Linear
3)Build Settings=> Player Settings => Other Settings =>Identification,package name = com.CastleAsset.ColorBump3D
4)Direction Light=> Delete and create new one, Shadow Type =>Soft Shadow,Resolution = Very High Resolution
5)Direction Light=> Rotation,x = 60, y = 125, z = 0,=> intensity = 0.6,shadow type= soft shadows,mode =Realtime 
6)Lighting Tab=>Environment=make evrything default and sun source = directional light,intensity Multiplayer = 0(important)
7)Select Post Processing=> Bloom = Intensity =20
8)Main Camera=> Rendering Path =>Deffered
9)Project Setting=> Select Quality=>Shadow Projection = Stable fit,Shadow Distance = 20


Material:
---------
1)Player material=> metallic = 0.2,smooothness= 0.8,emission = intensity = 1.2