
namespace pax.BlazorChartJs;

/// <summary>
/// Pie chart dataset <see href="https://www.chartjs.org/docs/latest/charts/doughnut.html">ChartJs docs</see>
/// </summary>
public record PieDataset : ChartJsDataset
{
    /// <summary>
    /// Color can either be a single string (css Color) or a list <see href="https://www.chartjs.org/docs/latest/general/colors.html">ChartJs docs</see>
    /// </summary>           
    public object? BackgroundColor { get; set; }
    /// <summary>
    /// BorderAlign - 'center'|'inner'
    /// </summary>      
    public string? BorderAlign { get; set; }
    /// <summary>
    /// Border Radius
    /// If this value is a number, it is applied to all corners of the arc (outerStart, outerEnd, innerStart, innerRight). If this value is an object, the outerStart property defines the outer-start corner's border radius. Similarly, the outerEnd, innerStart, and innerEnd properties can also be specified    
    /// <see href="https://www.chartjs.org/docs/latest/general/colors.html">ChartJs docs</see>
    /// </summary>           
    public object? BorderRadius { get; set; }
    /// <summary>
    /// Color can either be a single string (css Color) or a list <see href="https://www.chartjs.org/docs/latest/charts/doughnut.html#border-radius">ChartJs docs</see>
    /// </summary>
    public object? BorderColor { get; set; }
    /// <summary>
    /// This setting is used to avoid drawing the bar stroke at the base of the fill, or disable the border radius. In general, this does not need to be changed except when creating chart types that derive from a bar chart.
    ///
    ///    Note
    ///
    ///    For negative bars in a vertical chart, top and bottom are flipped. Same goes for left and right in a horizontal chart.
    ///
    ///    Options are:
    ///
    ///    'start'
    ///    'end'
    ///    'middle' (only valid on stacked bars: the borders between bars are skipped)
    ///    'bottom'
    ///    'left'
    ///    'top'
    ///    'right'
    ///    false (don't skip any borders)
    ///    true (skip all borders)
    /// <see href="https://www.chartjs.org/docs/latest/charts/bar.html#borderskipped">ChartJs docs</see>
    /// </summary>        
    // todo: can be object
    public int? BorderWidth { get; set; }
    public int? Circumference { get; set; }
    // todo: can be object
    /// <summary>
    /// can be number|object|false
    /// </summary>    
    public object? Clip { get; set; }
    /// <summary>
    /// Color can either be a single string (css Color) or a list <see href="https://www.chartjs.org/docs/latest/general/colors.html">ChartJs docs</see>
    /// </summary>      
    public object? HoverBackgroundColor { get; set; }
    /// <summary>
    /// HoverBorderJoinStyle - 'round'|'bevel'|'miter'
    /// </summary>          
    public string? HoverBorderJoinStyle { get; set; }
    /// <summary>
    /// Color can either be a single string (css Color) or a list <see href="https://www.chartjs.org/docs/latest/general/colors.html">ChartJs docs</see>
    /// </summary>      
    public int? HoverBorderWidth { get; set; }
    public int? HoverOffset { get; set; }
    public int? Offset { get; set; }
    public int? Rotation { get; set; }
    public int? Spacing { get; set; }
    public int? Weight { get; set; }
}

public record DoughnutDataset : PieDataset
{
    
}