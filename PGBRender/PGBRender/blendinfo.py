import bpy

scene = bpy.context.scene
print("Scene %r frame set: %d to %d for a total of %d" % (scene.name, scene.frame_start, scene.frame_end, scene.frame_end - scene.frame_start + 1))