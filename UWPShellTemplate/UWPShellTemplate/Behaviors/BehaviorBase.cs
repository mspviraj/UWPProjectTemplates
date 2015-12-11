﻿using Microsoft.Xaml.Interactivity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;

namespace UWPShellTemplate.Behaviors {
    public abstract class BehaviorBase<T> : DependencyObject, IBehavior where T : DependencyObject {
        public T AssociatedObject { get; private set; }

        DependencyObject IBehavior.AssociatedObject {
            get { return this.AssociatedObject; }
        }

        protected abstract void OnAttached();
        protected abstract void OnDetached();

        public void Attach(DependencyObject associatedObject) {
            if (associatedObject != null && !typeof(T).GetTypeInfo().IsAssignableFrom(associatedObject.GetType().GetTypeInfo()))
                throw new Exception(string.Format("associatedObject is not assignable to type:", typeof(T)));

            this.AssociatedObject = associatedObject as T;
            this.OnAttached();
        }

        public void Detach() {
            this.OnDetached();
            this.AssociatedObject = null;
        }
    }
}
