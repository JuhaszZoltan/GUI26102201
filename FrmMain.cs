namespace GUI26102201;

public partial class FrmMain : Form
{
    public FrmMain()
    {
        InitializeComponent();

        btnDetermine.Click += BtnDetermineClick;

        nudGivenNumber.GotFocus += NudGotFocus;
        nudLowerBound.GotFocus += NudGotFocus;
        nudUpperBound.GotFocus += NudGotFocus;
    }

    private void NudGotFocus(object? sender, EventArgs e)
    {
        (sender as NumericUpDown).Select(0, $"{(sender as NumericUpDown).Value}".Length);
        lblResult.Text = string.Empty;
    }

    private void BtnDetermineClick(object? sender, EventArgs e)
    {
        lblResult.Text =
            (nudLowerBound.Value <= nudGivenNumber.Value
            && nudGivenNumber.Value <= nudUpperBound.Value)
            ? "the number is within the interval"
            : "the number is outside the interval";
    }
}
