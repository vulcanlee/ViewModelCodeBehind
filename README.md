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

## XFDelegate 專案，使用 Delegate，從 ViewModel 內，呼叫 Code Behind 程式碼

在這個專案中，會使用 Data Binding 來綁定按鈕的點擊命令，在 ViewModel 中呼叫 Code Behind 程式碼。

我們要先在頁面 Code Behind 取得這個頁面當時使用的 ViewModel，並且將 ViewModel 的委派方法物件與 Code Behind 內的方法綁定在一起，這樣，我們就可以在 ViewModel 內，執行 Code Behind 的方法。

## XFBindProp 專案，將 Code Behind 程式碼，包裹在可綁定屬性中

在這個專案中，會產生兩個客製化控制項，一個是 ContentPage，另一個是 Button，接著，我們會在這兩個自訂控制項中，分別加入可綁定屬性。然後，便可以透過 ViewModel 來變更這些綁定於 View 中的 .NET Property，以便呼叫相關 Code Behind 程式碼。

## XFAttProp 專案，將 Code Behind 程式碼，包裹在附加屬性中

在這個專案中，會產生兩個附加屬性，一個是 ChangeBackgroundColor.ChangeAppColor，另一個是 ChangeBackgroundColor.ChangePageColor，接著，我們會將這兩個附加屬性加入到 ContentPage / Button。然後，便可以透過 ViewModel 來變更這些綁定於 View 中的 .NET Property，以便呼叫相關 Code Behind 程式碼。

