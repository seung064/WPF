using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Layout;

namespace WFA_03_String
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            /*
            string[] strings = new string[10];
            string astring = "동해 물과 백두산이";
            strings[0] = astring.IndexOf("백두산").ToString();

            string bstring = "토요일에 먹는 토마토";
            strings[1] = bstring.LastIndexOf("토").ToString();

            string cstring = "질서 있는 퇴장";
            strings[2] = cstring.Contains("퇴").ToString();

            string dstring = "그 사람의 그림자는 그랬다";
            strings[3] = dstring.Replace("그", "이").ToString();

            string estring = "삼성 갤럭시";
            strings[4] = estring.Insert(3, "애플");

            string fstring = "오늘은 왠지 더 배고프다";
            strings[5] = fstring.Remove(5).ToString();

            string gstring = "이름, 나이, 전화번호";
            strings[6] = gstring.Split(',').ToString();
            strings[7] = gstring.Split(',').ToString();
            strings[8] = gstring.Split(',').ToString();

            string hstring = "우리 나라 만세";
            strings[9] = hstring.Substring(2, 3).ToString();


            textBox1.Text += strings[1];
            */

            // 실습 문제)
            // 1. 10칸 짜리 문자열 배열 생성
            string[] results = new string[10]; // [0,0,0,0,0,0,0,0,0,0]

            // 2. 문자열 함수 적용한 후, 배열에 할당.
            results[0] = "동해 물과 백두산이".IndexOf("백두산").ToString(); // 6
            results[1] = "토요일에 먹는 토마토".LastIndexOf("토").ToString();
            results[2] = "질서 있는 퇴장".Contains("퇴").ToString();
            results[3] = "그 사람의 그림자는 그랬다.".Replace("그", "이");
            results[4] = "삼성 갤럭시".Insert(2, "애플");
            results[5] = "오늘은 왠지 더 배고프다".Remove("오늘은 왠지 더 배고프다".IndexOf("더"), 1);

            // Split 사용
            string data = "이름, 나이, 전화번호";
            string[] splitData = data.Split(','); // [이름, 나이, 전화번호]

            // 배열 3칸에 각각 나눠서 저장
            results[6] = splitData[0].Trim();  // "이름"
            results[7] = splitData[1].Trim();  // " 나이"
            results[8] = splitData[2].Trim();  // " 전화번호"
            // Trim(): 문자열의 양쪽 끝에 있는 공백을 없애주는 함수.

            // 문자열.Substring(시작 위치, 가져올 개수)
            // 시작위치 : 어디서부터 자를지, 인덱스 지정 (0부터)
            // 가져올 개수 : 몇 글자를 가져올지 숫자로 지정
            string message = "우리 나라 만세";

            // "나라" 꺼내야함.
            string sub = message.Substring(3, 2);
            results[9] = sub;

            textBox1.Text = results[0] + "\r\n";
            textBox1.Text += results[1] + "\r\n";
            textBox1.Text += results[2] + "\r\n";
            textBox1.Text += results[3] + "\r\n";
            textBox1.Text += results[4] + "\r\n";
            textBox1.Text += results[5] + "\r\n";
            textBox1.Text += results[6] + "\r\n";
            textBox1.Text += results[7] + "\r\n";
            textBox1.Text += results[8] + "\r\n";
            textBox1.Text += results[9] + "\r\n";






        }

        public override bool AllowDrop { get => base.AllowDrop; set => base.AllowDrop = value; }
        public override AnchorStyles Anchor { get => base.Anchor; set => base.Anchor = value; }
        public override Point AutoScrollOffset { get => base.AutoScrollOffset; set => base.AutoScrollOffset = value; }

        public override LayoutEngine LayoutEngine => base.LayoutEngine;

        public override Image BackgroundImage { get => base.BackgroundImage; set => base.BackgroundImage = value; }
        public override ImageLayout BackgroundImageLayout { get => base.BackgroundImageLayout; set => base.BackgroundImageLayout = value; }
        public override ContextMenu ContextMenu { get => base.ContextMenu; set => base.ContextMenu = value; }
        public override ContextMenuStrip ContextMenuStrip { get => base.ContextMenuStrip; set => base.ContextMenuStrip = value; }
        public override Cursor Cursor { get => base.Cursor; set => base.Cursor = value; }
        public override DockStyle Dock { get => base.Dock; set => base.Dock = value; }

        public override bool Focused => base.Focused;

        public override Font Font { get => base.Font; set => base.Font = value; }
        public override Color ForeColor { get => base.ForeColor; set => base.ForeColor = value; }
        public override RightToLeft RightToLeft { get => base.RightToLeft; set => base.RightToLeft = value; }
        public override ISite Site { get => base.Site; set => base.Site = value; }

        public override Rectangle DisplayRectangle => base.DisplayRectangle;

        public override BindingContext BindingContext { get => base.BindingContext; set => base.BindingContext = value; }
        public override Size AutoScaleBaseSize { get => base.AutoScaleBaseSize; set => base.AutoScaleBaseSize = value; }
        public override bool AutoScroll { get => base.AutoScroll; set => base.AutoScroll = value; }
        public override bool AutoSize { get => base.AutoSize; set => base.AutoSize = value; }
        public override AutoValidate AutoValidate { get => base.AutoValidate; set => base.AutoValidate = value; }
        public override Color BackColor { get => base.BackColor; set => base.BackColor = value; }
        public override Size MaximumSize { get => base.MaximumSize; set => base.MaximumSize = value; }
        public override Size MinimumSize { get => base.MinimumSize; set => base.MinimumSize = value; }
        public override bool RightToLeftLayout { get => base.RightToLeftLayout; set => base.RightToLeftLayout = value; }
        public override string Text { get => base.Text; set => base.Text = value; }

        protected override bool CanRaiseEvents => base.CanRaiseEvents;

        protected override Cursor DefaultCursor => base.DefaultCursor;

        protected override Padding DefaultMargin => base.DefaultMargin;

        protected override Size DefaultMaximumSize => base.DefaultMaximumSize;

        protected override Size DefaultMinimumSize => base.DefaultMinimumSize;

        protected override Padding DefaultPadding => base.DefaultPadding;

        protected override bool DoubleBuffered { get => base.DoubleBuffered; set => base.DoubleBuffered = value; }

        protected override bool ScaleChildren => base.ScaleChildren;

        protected override bool ShowKeyboardCues => base.ShowKeyboardCues;

        protected override bool ShowFocusCues => base.ShowFocusCues;

        protected override ImeMode ImeModeBase { get => base.ImeModeBase; set => base.ImeModeBase = value; }

        protected override bool CanEnableIme => base.CanEnableIme;

        protected override CreateParams CreateParams => base.CreateParams;

        protected override ImeMode DefaultImeMode => base.DefaultImeMode;

        protected override Size DefaultSize => base.DefaultSize;

        protected override bool ShowWithoutActivation => base.ShowWithoutActivation;

        public override ObjRef CreateObjRef(Type requestedType)
        {
            return base.CreateObjRef(requestedType);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override Size GetPreferredSize(Size proposedSize)
        {
            return base.GetPreferredSize(proposedSize);
        }

        public override object InitializeLifetimeService()
        {
            return base.InitializeLifetimeService();
        }

        public override bool PreProcessMessage(ref Message msg)
        {
            return base.PreProcessMessage(ref msg);
        }

        public override void Refresh()
        {
            base.Refresh();
        }

        public override void ResetBackColor()
        {
            base.ResetBackColor();
        }

        public override void ResetCursor()
        {
            base.ResetCursor();
        }

        public override void ResetFont()
        {
            base.ResetFont();
        }

        public override void ResetForeColor()
        {
            base.ResetForeColor();
        }

        public override void ResetRightToLeft()
        {
            base.ResetRightToLeft();
        }

        public override void ResetText()
        {
            base.ResetText();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override bool ValidateChildren()
        {
            return base.ValidateChildren();
        }

        public override bool ValidateChildren(ValidationConstraints validationConstraints)
        {
            return base.ValidateChildren(validationConstraints);
        }

        protected override void AdjustFormScrollbars(bool displayScrollbars)
        {
            base.AdjustFormScrollbars(displayScrollbars);
        }

        protected override AccessibleObject CreateAccessibilityInstance()
        {
            return base.CreateAccessibilityInstance();
        }

        protected override Control.ControlCollection CreateControlsInstance()
        {
            return base.CreateControlsInstance();
        }

        protected override void CreateHandle()
        {
            base.CreateHandle();
        }

        protected override void DefWndProc(ref Message m)
        {
            base.DefWndProc(ref m);
        }

        protected override void DestroyHandle()
        {
            base.DestroyHandle();
        }

        protected override AccessibleObject GetAccessibilityObjectById(int objectId)
        {
            return base.GetAccessibilityObjectById(objectId);
        }

        protected override Rectangle GetScaledBounds(Rectangle bounds, SizeF factor, BoundsSpecified specified)
        {
            return base.GetScaledBounds(bounds, factor, specified);
        }

        protected override object GetService(Type service)
        {
            return base.GetService(service);
        }

        protected override void InitLayout()
        {
            base.InitLayout();
        }

        protected override bool IsInputChar(char charCode)
        {
            return base.IsInputChar(charCode);
        }

        protected override bool IsInputKey(Keys keyData)
        {
            return base.IsInputKey(keyData);
        }

        protected override void NotifyInvalidate(Rectangle invalidatedArea)
        {
            base.NotifyInvalidate(invalidatedArea);
        }

        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
        }

        protected override void OnAutoSizeChanged(EventArgs e)
        {
            base.OnAutoSizeChanged(e);
        }

        protected override void OnAutoValidateChanged(EventArgs e)
        {
            base.OnAutoValidateChanged(e);
        }

        protected override void OnBackColorChanged(EventArgs e)
        {
            base.OnBackColorChanged(e);
        }

        protected override void OnBackgroundImageChanged(EventArgs e)
        {
            base.OnBackgroundImageChanged(e);
        }

        protected override void OnBackgroundImageLayoutChanged(EventArgs e)
        {
            base.OnBackgroundImageLayoutChanged(e);
        }

        protected override void OnBindingContextChanged(EventArgs e)
        {
            base.OnBindingContextChanged(e);
        }

        protected override void OnCausesValidationChanged(EventArgs e)
        {
            base.OnCausesValidationChanged(e);
        }

        protected override void OnChangeUICues(UICuesEventArgs e)
        {
            base.OnChangeUICues(e);
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
        }

        protected override void OnClientSizeChanged(EventArgs e)
        {
            base.OnClientSizeChanged(e);
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
        }

        protected override void OnContextMenuChanged(EventArgs e)
        {
            base.OnContextMenuChanged(e);
        }

        protected override void OnContextMenuStripChanged(EventArgs e)
        {
            base.OnContextMenuStripChanged(e);
        }

        protected override void OnControlAdded(ControlEventArgs e)
        {
            base.OnControlAdded(e);
        }

        protected override void OnControlRemoved(ControlEventArgs e)
        {
            base.OnControlRemoved(e);
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
        }

        protected override void OnCursorChanged(EventArgs e)
        {
            base.OnCursorChanged(e);
        }

        protected override void OnDeactivate(EventArgs e)
        {
            base.OnDeactivate(e);
        }

        protected override void OnDockChanged(EventArgs e)
        {
            base.OnDockChanged(e);
        }

        protected override void OnDoubleClick(EventArgs e)
        {
            base.OnDoubleClick(e);
        }

        protected override void OnDpiChanged(DpiChangedEventArgs e)
        {
            base.OnDpiChanged(e);
        }

        protected override void OnDpiChangedAfterParent(EventArgs e)
        {
            base.OnDpiChangedAfterParent(e);
        }

        protected override void OnDpiChangedBeforeParent(EventArgs e)
        {
            base.OnDpiChangedBeforeParent(e);
        }

        protected override void OnDragDrop(DragEventArgs drgevent)
        {
            base.OnDragDrop(drgevent);
        }

        protected override void OnDragEnter(DragEventArgs drgevent)
        {
            base.OnDragEnter(drgevent);
        }

        protected override void OnDragLeave(EventArgs e)
        {
            base.OnDragLeave(e);
        }

        protected override void OnDragOver(DragEventArgs drgevent)
        {
            base.OnDragOver(drgevent);
        }

        protected override void OnEnabledChanged(EventArgs e)
        {
            base.OnEnabledChanged(e);
        }

        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
        }

        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);
        }

        protected override void OnForeColorChanged(EventArgs e)
        {
            base.OnForeColorChanged(e);
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
        }

        protected override bool OnGetDpiScaledSize(int deviceDpiOld, int deviceDpiNew, ref Size desiredSize)
        {
            return base.OnGetDpiScaledSize(deviceDpiOld, deviceDpiNew, ref desiredSize);
        }

        protected override void OnGiveFeedback(GiveFeedbackEventArgs gfbevent)
        {
            base.OnGiveFeedback(gfbevent);
        }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
        }

        protected override void OnHandleDestroyed(EventArgs e)
        {
            base.OnHandleDestroyed(e);
        }

        protected override void OnHelpButtonClicked(CancelEventArgs e)
        {
            base.OnHelpButtonClicked(e);
        }

        protected override void OnHelpRequested(HelpEventArgs hevent)
        {
            base.OnHelpRequested(hevent);
        }

        protected override void OnImeModeChanged(EventArgs e)
        {
            base.OnImeModeChanged(e);
        }

        protected override void OnInputLanguageChanged(InputLanguageChangedEventArgs e)
        {
            base.OnInputLanguageChanged(e);
        }

        protected override void OnInputLanguageChanging(InputLanguageChangingEventArgs e)
        {
            base.OnInputLanguageChanging(e);
        }

        protected override void OnInvalidated(InvalidateEventArgs e)
        {
            base.OnInvalidated(e);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyUp(e);
        }

        protected override void OnLayout(LayoutEventArgs levent)
        {
            base.OnLayout(levent);
        }

        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }

        protected override void OnLocationChanged(EventArgs e)
        {
            base.OnLocationChanged(e);
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
        }

        protected override void OnMarginChanged(EventArgs e)
        {
            base.OnMarginChanged(e);
        }

        protected override void OnMaximizedBoundsChanged(EventArgs e)
        {
            base.OnMaximizedBoundsChanged(e);
        }

        protected override void OnMaximumSizeChanged(EventArgs e)
        {
            base.OnMaximumSizeChanged(e);
        }

        protected override void OnMdiChildActivate(EventArgs e)
        {
            base.OnMdiChildActivate(e);
        }

        protected override void OnMenuComplete(EventArgs e)
        {
            base.OnMenuComplete(e);
        }

        protected override void OnMenuStart(EventArgs e)
        {
            base.OnMenuStart(e);
        }

        protected override void OnMinimumSizeChanged(EventArgs e)
        {
            base.OnMinimumSizeChanged(e);
        }

        protected override void OnMouseCaptureChanged(EventArgs e)
        {
            base.OnMouseCaptureChanged(e);
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
        }

        protected override void OnMouseDoubleClick(MouseEventArgs e)
        {
            base.OnMouseDoubleClick(e);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
        }

        protected override void OnMouseHover(EventArgs e)
        {
            base.OnMouseHover(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
        }

        protected override void OnMouseWheel(MouseEventArgs e)
        {
            base.OnMouseWheel(e);
        }

        protected override void OnMove(EventArgs e)
        {
            base.OnMove(e);
        }

        protected override void OnNotifyMessage(Message m)
        {
            base.OnNotifyMessage(m);
        }

        protected override void OnPaddingChanged(EventArgs e)
        {
            base.OnPaddingChanged(e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
        }

        protected override void OnParentBackColorChanged(EventArgs e)
        {
            base.OnParentBackColorChanged(e);
        }

        protected override void OnParentBackgroundImageChanged(EventArgs e)
        {
            base.OnParentBackgroundImageChanged(e);
        }

        protected override void OnParentBindingContextChanged(EventArgs e)
        {
            base.OnParentBindingContextChanged(e);
        }

        protected override void OnParentChanged(EventArgs e)
        {
            base.OnParentChanged(e);
        }

        protected override void OnParentCursorChanged(EventArgs e)
        {
            base.OnParentCursorChanged(e);
        }

        protected override void OnParentEnabledChanged(EventArgs e)
        {
            base.OnParentEnabledChanged(e);
        }

        protected override void OnParentFontChanged(EventArgs e)
        {
            base.OnParentFontChanged(e);
        }

        protected override void OnParentForeColorChanged(EventArgs e)
        {
            base.OnParentForeColorChanged(e);
        }

        protected override void OnParentRightToLeftChanged(EventArgs e)
        {
            base.OnParentRightToLeftChanged(e);
        }

        protected override void OnParentVisibleChanged(EventArgs e)
        {
            base.OnParentVisibleChanged(e);
        }

        protected override void OnPreviewKeyDown(PreviewKeyDownEventArgs e)
        {
            base.OnPreviewKeyDown(e);
        }

        protected override void OnPrint(PaintEventArgs e)
        {
            base.OnPrint(e);
        }

        protected override void OnQueryContinueDrag(QueryContinueDragEventArgs qcdevent)
        {
            base.OnQueryContinueDrag(qcdevent);
        }

        protected override void OnRegionChanged(EventArgs e)
        {
            base.OnRegionChanged(e);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
        }

        protected override void OnResizeBegin(EventArgs e)
        {
            base.OnResizeBegin(e);
        }

        protected override void OnResizeEnd(EventArgs e)
        {
            base.OnResizeEnd(e);
        }

        protected override void OnRightToLeftChanged(EventArgs e)
        {
            base.OnRightToLeftChanged(e);
        }

        protected override void OnRightToLeftLayoutChanged(EventArgs e)
        {
            base.OnRightToLeftLayoutChanged(e);
        }

        protected override void OnScroll(ScrollEventArgs se)
        {
            base.OnScroll(se);
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
        }

        protected override void OnStyleChanged(EventArgs e)
        {
            base.OnStyleChanged(e);
        }

        protected override void OnSystemColorsChanged(EventArgs e)
        {
            base.OnSystemColorsChanged(e);
        }

        protected override void OnTabIndexChanged(EventArgs e)
        {
            base.OnTabIndexChanged(e);
        }

        protected override void OnTabStopChanged(EventArgs e)
        {
            base.OnTabStopChanged(e);
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
        }

        protected override void OnValidated(EventArgs e)
        {
            base.OnValidated(e);
        }

        protected override void OnValidating(CancelEventArgs e)
        {
            base.OnValidating(e);
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            return base.ProcessCmdKey(ref msg, keyData);
        }

        protected override bool ProcessDialogChar(char charCode)
        {
            return base.ProcessDialogChar(charCode);
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            return base.ProcessDialogKey(keyData);
        }

        protected override bool ProcessKeyEventArgs(ref Message m)
        {
            return base.ProcessKeyEventArgs(ref m);
        }

        protected override bool ProcessKeyMessage(ref Message m)
        {
            return base.ProcessKeyMessage(ref m);
        }

        protected override bool ProcessKeyPreview(ref Message m)
        {
            return base.ProcessKeyPreview(ref m);
        }

        protected override bool ProcessMnemonic(char charCode)
        {
            return base.ProcessMnemonic(charCode);
        }

        protected override bool ProcessTabKey(bool forward)
        {
            return base.ProcessTabKey(forward);
        }

        protected override void RescaleConstantsForDpi(int deviceDpiOld, int deviceDpiNew)
        {
            base.RescaleConstantsForDpi(deviceDpiOld, deviceDpiNew);
        }

        protected override void ScaleControl(SizeF factor, BoundsSpecified specified)
        {
            base.ScaleControl(factor, specified);
        }

        protected override void ScaleCore(float x, float y)
        {
            base.ScaleCore(x, y);
        }

        protected override Point ScrollToControl(Control activeControl)
        {
            return base.ScrollToControl(activeControl);
        }

        protected override void Select(bool directed, bool forward)
        {
            base.Select(directed, forward);
        }

        protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified)
        {
            base.SetBoundsCore(x, y, width, height, specified);
        }

        protected override void SetClientSizeCore(int x, int y)
        {
            base.SetClientSizeCore(x, y);
        }

        protected override void SetVisibleCore(bool value)
        {
            base.SetVisibleCore(value);
        }

        protected override Size SizeFromClientSize(Size clientSize)
        {
            return base.SizeFromClientSize(clientSize);
        }

        protected override void UpdateDefaultButton()
        {
            base.UpdateDefaultButton();
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
        }
    }
            
}

            