# HTML tooltips in WPF apps
Who doesn't want HTML tooltips in their WPF apps! Here's a little demo on how to do just that.

## How to do it?
First, you need a control that can display HTML. The WebBrowser control is definitely too much for a tooltip, but there's the HtmlLabel contained in HtmlRenderer.WPF nuget. It's pretty light-weight and it supports transparency.

You can find the HtmlRenderer.WPF nuget here: https://www.nuget.org/packages/HtmlRenderer.WPF 
or get it with this command: `Install-Package HtmlRenderer.WPF`

Second, you propably want to use this HTML tooltip in multiple places. The easiest way to re-use it (I think) is to put it in a style.

 Like this:
```xaml
<Style TargetType="ToolTip">
    <Setter Property="ContentTemplate">
        <Setter.Value>
            <DataTemplate>
                <htmlControls:HtmlLabel Text="{TemplateBinding Content}" />
            </DataTemplate>
        </Setter.Value>
    </Setter>
</Style>
```
This style replaces the default control that displays the tooltip and displays it with the HtmlLabel instead.

Then all there's left to do is bind some HTML text to anything that has a tooltip:
```xaml
<Button
    Padding="10"
    HorizontalAlignment="Center"
    VerticalAlignment="Center"
    Content="Hover over me"
    ToolTip="{Binding HtmlTooltip}" />
```

And that's it! 
You can bind tooltips to HTML text now.

![Sample image](https://raw.githubusercontent.com/michaldivis/HtmlRendererTest/master/htmlrenderertest.png)



