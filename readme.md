# About
If you've ever needed a small, simple, and powerful game-like application to test your computer, look no further. TAFM does many things, but is especially great for demonstrating differences between framerates, stress testing for long periods of time, and calibrating live streams. You install Steam, login, download a game, launch it, set the settings, and wait for the benchmark to start (if it even has one). It took forever! Not anymore.


[![Github Releases (by Release)](https://img.shields.io/github/downloads/Tylemagne/TAFM/total.svg)]()

[![GitHub repo size in bytes](https://img.shields.io/github/repo-size/Tylemagne/TAFM.svg)]()

[![GitHub last commit](https://img.shields.io/github/last-commit/Tylemagne/TAFM.svg)]()

[![GitHub top language](https://img.shields.io/github/languages/top/Tylemagne/TAFM.svg)]()

[![GitHub release](https://img.shields.io/github/release/Tylemagne/TAFM.svg?logo=data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAA0AAAAOCAYAAAD0f5bSAAAABHNCSVQICAgIfAhkiAAAAAlwSFlzAAAAfgAAAH4BavEubQAAABl0RVh0U29mdHdhcmUAd3d3Lmlua3NjYXBlLm9yZ5vuPBoAAACRSURBVCiR7ZExCkJBDETn24jgCbyE9rZ2lr+3sPQUXsFD2HkNwZNYC9rk7cJYuMXy/aho60AgIfOKSaRKEdEC7lZEtLVvoC/0h36BGmAlaV7msaRJj+8s6Vb6o2wPgX3fU7uVUjrYHkmSbDcRsX0D7Ww/xwHWPFSbM7B5GTKltAAuBbjmnJcfXQeYAidg1re/A0Qcr7zN5lQ2AAAAAElFTkSuQmCC)]()

[![Github commits (since latest release)](https://img.shields.io/github/commits-since/Tylemagne/TAFM/latest.svg)]()


# Web
[WebGL](http://htmlpreview.github.io/?https://github.com/Tylemagne/TFM/master/TFM-WebGL/index.html)


# To-do for 1.0 Full Release
Current task list:
1. Add more stress (slider for huge background fireworks)
2. UI adjustments (truncate long floats, steppers)
3. Builds for each API in releases (Vulkan, DX12, DX11, OpenGL, DX9)
4. Builds for each bitwidth in releases (32, 64)
5. Builds for each platform in releases (Windows, Mac, Linux... about 16 possible builds in all)
6. Audio testing (small background track with volume slider)
7. F12 for control/info panel, + button to hide the UI (disable canvas component)
8 . Mode presets. One click and the sliders will snap.
9 . F11 for fullscreen toggle (also toggle in dashboard)
10. Intro text fade in from black
11. Minimal UI by default, F12 for dashboard
12. Toggle controls via a checkbox in the dashboard
13. Group box for benchmarks, presets, system info, and misc controls
14. Preset buttons for 2frames, calibration60, calibration30, calibration24, slomo, pleasant, ultra, lowest, and stabilitytest
15. System info groupbox where a rough score is given to each piece of hardware
16. Benchmark mode - click ONE button and a 5-minute benchmark will run at a locked preset, and a total frames drawn score will be presented at the end using Update(). Low and high modes only. Resolution/total pixels are included in the score string.
17. Resolution dropdown in the dashboard
18. Clickable helpers on CPU, GPU, RAM, and more. Clickable helpers on CERTAIN CPUs/GPUs/APIs. "This is Vulkan. It is..."
19. Misc buttons [open URL to Repo](https://docs.unity3d.com/ScriptReference/Application.OpenURL.html)

# Considerations
1. Audio
2. Web builds hosted by GitHub?

# Download Latest
There are no builds yet. Ignore the buttons below.

Vulkan is the recommendation, but your machine may not handle it yet as Vulkan is relatively very new. DirectX 11 or OpenGL is the next best option if DirectX 12 doesn't work, since it's the same age as Vulkan.

# Windows
### Vulkan (Recommended)
[![Github All Releases](https://img.shields.io/github/downloads/Tylemagne/TAFM/total.svg?style=flat&label=🔽%20TAFM%20v1.1%20(32-bit)&colorA=00cc0a&colorB=000000)](https://github.com/Tylemagne/TAFM/releases/download/v1.1/TAFM-win-x86.zip)

[![Github All Releases](https://img.shields.io/github/downloads/Tylemagne/TAFM/total.svg?style=flat&label=🔽%20TAFM%20v1.1%20(64-bit)&colorA=00cc0a&colorB=000000)](https://github.com/Tylemagne/TAFM/releases/download/v1.1/TAFM-win-x86_64.zip)
### OpenGL
### DirectX 12
### DirectX 11
### DirectX 9

# Mac
### Metal (Recommended)
### OpenGL
[![Github All Releases](https://img.shields.io/github/downloads/Tylemagne/TAFM/total.svg?style=flat&label=🔽%20TAFM%20v1.1%20(32-bit)&colorA=00cc0a&colorB=000000)](https://github.com/Tylemagne/TAFM/releases/download/v1.1/TAFM-win-x86.zip)

[![Github All Releases](https://img.shields.io/github/downloads/Tylemagne/TAFM/total.svg?style=flat&label=🔽%20TAFM%20v1.1%20(64-bit)&colorA=00cc0a&colorB=000000)](https://github.com/Tylemagne/TAFM/releases/download/v1.1/TAFM-win-x86_64.zip)

# Linux
### OpenGL
### Vulkan (Recommended)
[![Github All Releases](https://img.shields.io/github/downloads/Tylemagne/TAFM/total.svg?style=flat&label=🔽%20TAFM%20v1.1%20(32-bit)&colorA=00cc0a&colorB=000000)](https://github.com/Tylemagne/TAFM/releases/download/v1.1/TAFM-win-x86.zip)

[![Github All Releases](https://img.shields.io/github/downloads/Tylemagne/TAFM/total.svg?style=flat&label=🔽%20TAFM%20v1.1%20(64-bit)&colorA=00cc0a&colorB=000000)](https://github.com/Tylemagne/TAFM/releases/download/v1.1/TAFM-win-x86_64.zip)
