# 如何將 Code Behind 程式碼包裝起來，可以在 ViewModel 內呼叫

在這裡，將會展示如何從原先的 Code Behind 相關處理程式碼，變更或者包裝成為 ViewModel 可以呼叫這些功能。

## XFCodeBehind 專案，使用 Code Behind 來變更顏色資源的顏色

這個專案將會說明，如何使用 Code Behind，當使用按下按鈕之後，使用動態資源的方式，變更 ContentPage 的背景顏色

下圖為該範例程式執行的螢幕截圖

![Xamarin Code Behind](Screenshot/CodeBehind1.png)

下圖為當按下的 `變更顏色` 按鈕之後，頁面背景顏色會變色的螢幕截圖

![Xamarin Code Behind](Screenshot/CodeBehind2.png)

下圖為當按下的 `變更顏色(頁面)` 按鈕之後，該按鈕背景顏色會變色的螢幕截圖

![Xamarin Code Behind](Screenshot/CodeBehind3.png)