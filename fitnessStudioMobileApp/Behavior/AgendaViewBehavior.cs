﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Syncfusion.Maui.Scheduler;
using Scheduler = Syncfusion.Maui.Scheduler.SfScheduler;
using fitnessStudioMobileApp.Model;
using fitnessStudioMobileApp.ViewModels;

namespace fitnessStudioMobileApp.Behavior
{
    internal class AgendaViewBehavior : Behavior<Scheduler>
    {
        /// <inheritdoc/>
        protected override void OnAttachedTo(Scheduler scheduler)
        {
            base.OnAttachedTo(scheduler);
            scheduler.ViewChanged += OnSchedulerViewChanged;
        }

        /// <summary>
        /// Invoks on scheduler view change and view swipe.
        /// </summary>
        /// <param name="sender">Ths scheduler.</param>
        /// <param name="e">The view changed event args.</param>
        private void OnSchedulerViewChanged(object? sender, SchedulerViewChangedEventArgs e)
        {
            if (e.NewView != SchedulerView.Agenda && sender is Scheduler scheduler)
            {
                scheduler.View = SchedulerView.Agenda;
            }
        }

        /// <inheritdoc/>
        protected override void OnDetachingFrom(Scheduler scheduler)
        {
            base.OnDetachingFrom(scheduler);
            scheduler.ViewChanged -= this.OnSchedulerViewChanged;
        }
    }
}
