/* Generated by Myra UI Editor at 22.08.2018 4:59:25 */
using Microsoft.Xna.Framework;
using Myra.Graphics2D.UI;

namespace Myra.Graphics2D.UI
{
	partial class DebugOptionsDialog
	{
		private void BuildUI()
		{
			_checkBoxWidgetFrames = new CheckBox();
			_checkBoxWidgetFrames.Text = "Draw green frame around every widget";
			_checkBoxWidgetFrames.ImageWidthHint = 10;
			_checkBoxWidgetFrames.ImageHeightHint = 10;
			_checkBoxWidgetFrames.ContentHorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Stretch;
			_checkBoxWidgetFrames.ContentVerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Stretch;
			_checkBoxWidgetFrames.Id = "_checkBoxWidgetFrames";

			_checkBoxFocusedWidgetFrame = new CheckBox();
			_checkBoxFocusedWidgetFrame.Text = "Draw red frame around the focused widget";
			_checkBoxFocusedWidgetFrame.ImageWidthHint = 10;
			_checkBoxFocusedWidgetFrame.ImageHeightHint = 10;
			_checkBoxFocusedWidgetFrame.ContentHorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Stretch;
			_checkBoxFocusedWidgetFrame.ContentVerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Stretch;
			_checkBoxFocusedWidgetFrame.Id = "_checkBoxFocusedWidgetFrame";
			_checkBoxFocusedWidgetFrame.GridPositionY = 1;

			_checkBoxGlyphFrames = new CheckBox();
			_checkBoxGlyphFrames.Text = "Draw white frame around every letter glyph";
			_checkBoxGlyphFrames.ImageWidthHint = 10;
			_checkBoxGlyphFrames.ImageHeightHint = 10;
			_checkBoxGlyphFrames.ContentHorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Stretch;
			_checkBoxGlyphFrames.ContentVerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Stretch;
			_checkBoxGlyphFrames.Id = "_checkBoxGlyphFrames";
			_checkBoxGlyphFrames.GridPositionY = 2;

			_checkBoxDisableClipping = new CheckBox();
			_checkBoxDisableClipping.Text = "Disable clipping";
			_checkBoxDisableClipping.ImageWidthHint = 10;
			_checkBoxDisableClipping.ImageHeightHint = 10;
			_checkBoxDisableClipping.ContentHorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Stretch;
			_checkBoxDisableClipping.ContentVerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Stretch;
			_checkBoxDisableClipping.Id = "_checkBoxDisableClipping";
			_checkBoxDisableClipping.GridPositionY = 3;

			Root = new Grid();
			Root.DrawLinesColor = Color.White;
			Root.RowsProportions.Add(new Grid.Proportion());
			Root.RowsProportions.Add(new Grid.Proportion());
			Root.RowsProportions.Add(new Grid.Proportion());
			Root.RowsProportions.Add(new Grid.Proportion());
			Root.Id = "Root";
			Root.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Stretch;
			Root.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Stretch;
			Root.GridPositionY = 1;
			Root.Widgets.Add(_checkBoxWidgetFrames);
			Root.Widgets.Add(_checkBoxFocusedWidgetFrame);
			Root.Widgets.Add(_checkBoxGlyphFrames);
			Root.Widgets.Add(_checkBoxDisableClipping);

			
			Title = "Debug Options";
			TitleTextColor = Color.White;
			DrawLinesColor = Color.White;
			XHint = 285;
			YHint = 312;
			CanFocus = true;
			Content = Root;
		}

		
		public CheckBox _checkBoxWidgetFrames;
		public CheckBox _checkBoxFocusedWidgetFrame;
		public CheckBox _checkBoxGlyphFrames;
		public CheckBox _checkBoxDisableClipping;
		public Grid Root;
	}
}