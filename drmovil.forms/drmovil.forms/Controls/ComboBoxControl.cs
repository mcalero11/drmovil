﻿using drmovil.forms.Helpers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace drmovil.forms.Controls
{
    public class ComboBoxControl : View
    {
        #region Dependency property
        public static readonly BindableProperty TextColorProperty =
            BindableProperty.Create(
                nameof(TextColor),
                typeof(Color),
                typeof(ComboBoxControl),
                default(Color));

        public static readonly BindableProperty SelectedIndexProperty =
            BindableProperty.Create(
                nameof(SelectedIndex),
                typeof(int),
                typeof(ComboBoxControl),
                -1,
                BindingMode.TwoWay,
                propertyChanged: OnSelectedIndexChanged,
                coerceValue: CoerceSelectedIndex);

        public static readonly BindableProperty ItemsSourceProperty =
            BindableProperty.Create(
                nameof(ItemsSource),
                typeof(IList),
                typeof(ComboBoxControl),
                default(IList),
                propertyChanged: OnItemsSourceChanged);

        public static readonly BindableProperty SelectedItemProperty =
            BindableProperty.Create(
                nameof(SelectedItem),
                typeof(object),
                typeof(ComboBoxControl),
                null,
                BindingMode.TwoWay,
                propertyChanged: OnSelectedItemChanged);
        #endregion

        #region Properties
        public IList ItemsSource
        {
            get { return (IList)GetValue(ItemsSourceProperty); }
            set { SetValue(ItemsSourceProperty, value); }
        }

        public int SelectedIndex
        {
            get { return (int)GetValue(SelectedIndexProperty); }
            set { SetValue(SelectedIndexProperty, value); }
        }

        public object SelectedItem
        {
            get { return GetValue(SelectedItemProperty); }
            set { SetValue(SelectedItemProperty, value); }
        }

        public Color TextColor
        {
            get { return (Color)GetValue(TextColorProperty); }
            set { SetValue(TextColorProperty, value); }
        }
        #endregion

        #region Events
        public event EventHandler<SelectedIndexChangedEventArgs> SelectedIndexChanged;
        #endregion

        #region Static functions
        static object CoerceSelectedIndex(BindableObject bindable, object value)
        {
            var comboBox = (ComboBoxControl)bindable;
            if (value is int)
            {
                return comboBox.ItemsSource == null ? -1 : ((int)value).Clamp(-1, comboBox.ItemsSource.Count - 1);
            }

            throw new InvalidOperationException("Selected Index must be an interger");
        }

        static void OnSelectedIndexChanged(object bindable, object oldValue, object newValue)
        {
            var comboBox = (ComboBoxControl)bindable;
            comboBox.UpdateSelectedItem();
            comboBox.SelectedIndexChanged?.Invoke(bindable, new SelectedIndexChangedEventArgs((int)oldValue, (int)newValue));
        }

        static void OnSelectedItemChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var comboBox = (ComboBoxControl)bindable;
            comboBox.UpdateSelectedIndex(newValue);
        }

        static void OnItemsSourceChanged(BindableObject bindable, object oldValue, object newValue)
        {
            ((ComboBoxControl)bindable).OnItemsSourceChanged((IList)oldValue, (IList)newValue);
        }
        #endregion

        void OnItemsSourceChanged(IList oldValue, IList newValue)
        {
            if (oldValue is INotifyCollectionChanged oldObservable)
            {
                oldObservable.CollectionChanged -= CollectionChanged;
            }

            if (newValue is INotifyCollectionChanged newObservable)
            {
                newObservable.CollectionChanged += CollectionChanged;
            }
        }

        void CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    break;
                case NotifyCollectionChangedAction.Remove:
                    break;
                default: //Move, Replace, Reset
                    break;
            }
        }

        void UpdateSelectedIndex(object selectedItem)
        {
            if (ItemsSource != null)
            {
                SelectedIndex = ItemsSource.IndexOf(selectedItem);
                return;
            }
        }

        void UpdateSelectedItem()
        {
            if (SelectedIndex == -1)
            {
                SelectedItem = null;
            }
            else if (ItemsSource != null)
            {
                SelectedItem = ItemsSource[SelectedIndex];
            }
        }

    }
}
