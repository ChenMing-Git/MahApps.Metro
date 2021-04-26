// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using MahApps.Metro.ValueBoxes;

namespace MahApps.Metro.Controls
{
    public class Tile : Button
    {
        static Tile()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Tile), new FrameworkPropertyMetadata(typeof(Tile)));
        }

        public static readonly DependencyProperty TitleProperty = DependencyProperty.Register(nameof(Title), typeof(string), typeof(Tile), new PropertyMetadata(default(string)));

        public string? Title
        {
            get => (string?)GetValue(TitleProperty);
            set => SetValue(TitleProperty, value);
        }

        /// <summary> 
        /// HorizontalTitleAlignment Dependency Property.
        /// Default Value: HorizontalAlignment.Left
        /// </summary>
        public static readonly DependencyProperty HorizontalTitleAlignmentProperty =
            DependencyProperty.Register(
                nameof(HorizontalTitleAlignment),
                typeof(HorizontalAlignment),
                typeof(Tile),
                new FrameworkPropertyMetadata(HorizontalAlignment.Left));

        /// <summary> 
        /// Gets/Sets the horizontal alignment of the title.
        /// </summary> 
        [Bindable(true), Category("Layout")]
        public HorizontalAlignment HorizontalTitleAlignment
        {
            get => (HorizontalAlignment)GetValue(HorizontalTitleAlignmentProperty);
            set => SetValue(HorizontalTitleAlignmentProperty, value);
        }

        /// <summary>
        /// VerticalTitleAlignment Dependency Property. 
        /// Default Value: VerticalAlignment.Bottom
        /// </summary> 
        public static readonly DependencyProperty VerticalTitleAlignmentProperty =
            DependencyProperty.Register(
                nameof(VerticalTitleAlignment),
                typeof(VerticalAlignment),
                typeof(Tile),
                new FrameworkPropertyMetadata(VerticalAlignment.Bottom));

        /// <summary>
        /// Gets/Sets the vertical alignment of the title.
        /// </summary>
        [Bindable(true), Category("Layout")]
        public VerticalAlignment VerticalTitleAlignment
        {
            get => (VerticalAlignment)GetValue(VerticalTitleAlignmentProperty);
            set => SetValue(VerticalTitleAlignmentProperty, value);
        }

        public static readonly DependencyProperty CountProperty = DependencyProperty.Register(nameof(Count), typeof(string), typeof(Tile), new PropertyMetadata(default(string)));

        public string? Count
        {
            get => (string?)GetValue(CountProperty);
            set => SetValue(CountProperty, value);
        }

        public static readonly DependencyProperty KeepDraggingProperty = DependencyProperty.Register(nameof(KeepDragging), typeof(bool), typeof(Tile), new PropertyMetadata(BooleanBoxes.TrueBox));

        public bool KeepDragging
        {
            get => (bool)GetValue(KeepDraggingProperty);
            set => SetValue(KeepDraggingProperty, BooleanBoxes.Box(value));
        }

        public static readonly DependencyProperty TiltFactorProperty = DependencyProperty.Register(nameof(TiltFactor), typeof(int), typeof(Tile), new PropertyMetadata(5));

        public int TiltFactor
        {
            get => (Int32)GetValue(TiltFactorProperty);
            set => SetValue(TiltFactorProperty, value);
        }

        public static readonly DependencyProperty TitleFontSizeProperty = DependencyProperty.Register(nameof(TitleFontSize), typeof(double), typeof(Tile), new PropertyMetadata(16d));

        public double TitleFontSize
        {
            get => (double)GetValue(TitleFontSizeProperty);
            set => SetValue(TitleFontSizeProperty, value);
        }

        public static readonly DependencyProperty CountFontSizeProperty = DependencyProperty.Register(nameof(CountFontSize), typeof(double), typeof(Tile), new PropertyMetadata(28d));

        public double CountFontSize
        {
            get => (double)GetValue(CountFontSizeProperty);
            set => SetValue(CountFontSizeProperty, value);
        }
    }
}