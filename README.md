# 📇 TestReorderableInspector

## 📜 Preface

Ever drag multiple items to an inspector field and they end up in the wrong order?

Unity has an internal reorderable list control that accepts files in correct order and allows reorder... but not as easy to use as other controls.

This package 'automatically' replaces 'all' lists with reorderable lists.

![ReorderableInspector](ReorderableInspector.png "ReorderableInspector")

<https://github.com/SubjectNerd-Unity/ReorderableInspector>

I am trying to get it to work with some Tilemap tools.

## ✔️ Testing

- ### 🗺️ TileBase
  - works in inspector
  - works because i have not defined an editor because i not need for that shit
  - my CustomPropertyDrawer works here
- ### 🗺️ TileBase with Editor
- ### 🖌️ BrushEditorBase
  - works in inspector.
  - works in paint inspector without Editor .
  - my CustomPropertyDrawer works here
- ### 🖌️ BrushEditorBase with Editor

<https://github.com/rakkarage/TestReorderableInspector>

---

## ❓ **Question**

Possible to make this work with custom brushes somehow?

Please & Thanks!
