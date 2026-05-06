# VLiveKit StageEffect

ステージ演出用 asset / effect を UPM 化するための package container です。

## Package

- Package name: `com.toshi.vlivekit.stageeffect`
- Version: `0.0.1`
- Unity: 2022.3
- Repository: https://github.com/toshi-kundesu/VLiveKit_StageEffect
- Package root: `Assets/toshi.VLiveKit/StageEffect`

## 主な内容

- stage effect asset を置くための UPM package root
- HDRP / VFX Graph を使う演出 asset の受け皿
- 今後整理した effect を追加するための最小構成

## 依存・同梱 asset

- HDRP 14.0.8
- Visual Effect Graph 14.0.8

## インストール

Unity の `Packages/manifest.json` の `dependencies` に追加します。

```json
{
  "dependencies": {
    "com.toshi.vlivekit.stageeffect": "https://github.com/toshi-kundesu/VLiveKit_StageEffect.git?path=/Assets/toshi.VLiveKit/StageEffect#main"
  }
}
```

VLiveKit sandbox では submodule として `Packages/VLiveKit_StageEffect` に配置し、`file:` 参照で読み込んでいます。

## 注意

- まだ asset 本体は少なく、配布用の入れ物を先に整えています。

## License

この package 独自のコードと asset は repository の `LICENSE` に従います。third-party asset を含む場合は、それぞれの license / README を確認してください。
