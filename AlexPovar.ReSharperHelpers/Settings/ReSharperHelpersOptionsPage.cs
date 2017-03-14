﻿using AlexPovar.ReSharperHelpers.UI;
using JetBrains.Annotations;
using JetBrains.DataFlow;
using JetBrains.ReSharper.Feature.Services.OptionPages.CodeEditing;
using JetBrains.UI.CrossFramework;
using JetBrains.UI.Options;

namespace AlexPovar.ReSharperHelpers.Settings
{
  [OptionsPage(PID, "Alex Povar ReSharper Helpers", typeof(MainThemedIcons.HelpersContextAction), ParentId = CodeEditingPage.PID)]
  public class ReSharperHelpersOptionsPage : ReSharperHelpersOptionsPageMarkup, IOptionsPage
  {
    // ReSharper disable once InconsistentNaming
    private const string PID = "AlexPovarReSharperHelpers";

    public ReSharperHelpersOptionsPage([NotNull] Lifetime lifetime, [NotNull] OptionsSettingsSmartContext settingsSmart)
    {
      this.DataContext = new ReSharperHelpersOptionsPageViewModel(lifetime, settingsSmart);

      this.Control = this;
    }

    public bool OnOk() => true;

    public bool ValidatePage() => true;

    public EitherControl Control { get; }

    public string Id => PID;
  }
}