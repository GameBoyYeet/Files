﻿using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Windows.UI.Xaml.Controls;
using System;

namespace Files.Controls
{
    public class RibbonViewModel : ViewModelBase
    {
        private bool _ShowRibbonContent = true;
        private string _ToggleRibbonIcon = "";
        private CommandBarLabelPosition _ItemLabelPosition = CommandBarLabelPosition.Default;
        private Windows.UI.Xaml.Visibility _AppBarSeparatorVisibility = Windows.UI.Xaml.Visibility.Visible;

        public string ToggleRibbonIcon
        {
            get => _ToggleRibbonIcon;
            set => Set(ref _ToggleRibbonIcon, value);
        }

        public bool ShowRibbonContent
        {
            get => _ShowRibbonContent;
            set => Set(ref _ShowRibbonContent, value);
        }

        public CommandBarLabelPosition ItemLabelPosition
        {
            get => _ItemLabelPosition;
            set => Set(ref _ItemLabelPosition, value);
        }

        public Windows.UI.Xaml.Visibility AppBarSeparatorVisibility
        {
            get => _AppBarSeparatorVisibility;
            set => Set(ref _AppBarSeparatorVisibility, value);
        }

        private RelayCommand toggleRibbon;
        public RelayCommand ToggleRibbon => toggleRibbon = new RelayCommand(() =>
        {
            ShowRibbonContent = !ShowRibbonContent;

            UpdateToggleIcon();
        });

        private RelayCommand showRibbonCommand;
        public RelayCommand ShowRibbonCommand => showRibbonCommand = new RelayCommand(() =>
        {
            if (ShowRibbonContent == false)
            {
                ShowRibbonContent = true;
                
                UpdateToggleIcon();
            }
        });

        public void UpdateToggleIcon()
        {
            if (ShowRibbonContent)
            {
                ToggleRibbonIcon = ""; //This is the hide icon
            }
            else
            {
                ToggleRibbonIcon = ""; //This is the show icon
            }
        }

        public void HideItemLabels()
        {
            ItemLabelPosition = CommandBarLabelPosition.Collapsed;
        }

        public void ShowItemLabels()
        {
            ItemLabelPosition = CommandBarLabelPosition.Default;
        }

        public void HideAppBarSeparator()
        {
            AppBarSeparatorVisibility = Windows.UI.Xaml.Visibility.Collapsed;
        }

        public void ShowAppBarSeparator()
        {
            AppBarSeparatorVisibility = Windows.UI.Xaml.Visibility.Visible;
        }
    }
}
