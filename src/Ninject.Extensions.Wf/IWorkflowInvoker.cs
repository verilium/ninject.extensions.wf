//-------------------------------------------------------------------------------
// <copyright file="IWorkflowInvoker.cs" company="bbv Software Services AG">
//   Copyright (c) 2010 bbv Software Services AG
//   Author: Daniel Marbach
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//       http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
// </copyright>
//-------------------------------------------------------------------------------

namespace Ninject.Extensions.Wf
{
    using System;
    using System.Activities;
    using System.Collections.Generic;
    using Extensions;

    /// <summary>
    /// Interface definition for the workflow invoker.
    /// </summary>
    public interface IWorkflowInvoker : IResolveExtensions
    {
#pragma warning disable 1584,1658
        /// <include file='../System.Activities.xml' path='/doc/members/member[@name="M:System.Activities.WorkflowInvoker.InvokeAsync(System.Collections.Generic.IDictionary{System.String,System.Object},System.TimeSpan,System.Object)"]/*' />
        void InvokeAsync(IDictionary<string, object> inputs, TimeSpan timeout, object userState);

        /// <include file='../System.Activities.xml' path='/doc/members/member[@name="M:System.Activities.WorkflowInvoker.InvokeAsync(System.Collections.Generic.IDictionary{System.String,System.Object},System.Object)"]/*' />
        void InvokeAsync(IDictionary<string, object> inputs, object userState);

        /// <include file='../System.Activities.xml' path='/doc/members/member[@name="M:System.Activities.WorkflowInvoker.InvokeAsync(System.Collections.Generic.IDictionary{System.String,System.Object},System.TimeSpan)"]/*' />
        void InvokeAsync(IDictionary<string, object> inputs, TimeSpan timeout);

        /// <include file='../System.Activities.xml' path='/doc/members/member[@name="M:System.Activities.WorkflowInvoker.InvokeAsync(System.Collections.Generic.IDictionary{System.String,System.Object})"]/*' />
        void InvokeAsync(IDictionary<string, object> inputs);

        /// <include file='../System.Activities.xml' path='/doc/members/member[@name="M:System.Activities.WorkflowInvoker.InvokeAsync(System.TimeSpan,System.Object)"]/*' />
        void InvokeAsync(TimeSpan timeout, object userState);

        /// <include file='../System.Activities.xml' path='/doc/members/member[@name="M:System.Activities.WorkflowInvoker.InvokeAsync(System.TimeSpan)"]/*' />
        void InvokeAsync(TimeSpan timeout);

        /// <include file='../System.Activities.xml' path='/doc/members/member[@name="M:System.Activities.WorkflowInvoker.InvokeAsync"]/*' />
        void InvokeAsync();
        
        /// <summary>
        /// Initializes the invoker with the specified workflow definition.
        /// </summary>
        /// <param name="workflowDefinition">The workflow definition.</param>
        void Initialize(Activity workflowDefinition);

        /// <include file='../System.Activities.xml' path='/doc/members/member[@name="M:System.Activities.WorkflowInvoker.Invoke"]/*' />
        IDictionary<string,object> Invoke();

        /// <include file='../System.Activities.xml' path='/doc/members/member[@name="M:System.Activities.WorkflowInvoker.Invoke(System.TimeSpan)"]/*' />
        IDictionary<string,object> Invoke(TimeSpan timeout);

        /// <include file='../System.Activities.xml' path='/doc/members/member[@name="M:System.Activities.WorkflowInvoker.Invoke(System.Collections.Generic.IDictionary{System.String,System.Object})"]/*' />
        IDictionary<string,object> Invoke(IDictionary<string,object> inputs);

        /// <include file='../System.Activities.xml' path='/doc/members/member[@name="M:System.Activities.WorkflowInvoker.Invoke(System.Collections.Generic.IDictionary{System.String,System.Object},System.TimeSpan)"]/*' />
        IDictionary<string,object> Invoke(IDictionary<string,object> inputs, TimeSpan timeout);

        /// <include file='../System.Activities.xml' path='/doc/members/member[@name="M:System.Activities.WorkflowInvoker.EndInvoke(System.IAsyncResult)"]/*' />
        IDictionary<string,object> EndInvoke(IAsyncResult result);

        /// <include file='../System.Activities.xml' path='/doc/members/member[@name="M:System.Activities.WorkflowInvoker.CancelAsync(System.Object)"]/*' />
        void CancelAsync(object userState);

        /// <include file='../System.Activities.xml' path='/doc/members/member[@name="M:System.Activities.WorkflowInvoker.BeginInvoke(System.AsyncCallback,System.Object)"]/*' />
        IAsyncResult BeginInvoke(AsyncCallback callback, object state);

        /// <include file='../System.Activities.xml' path='/doc/members/member[@name="M:System.Activities.WorkflowInvoker.BeginInvoke(System.TimeSpan,System.AsyncCallback,System.Object)"]/*' />
        IAsyncResult BeginInvoke(TimeSpan timeout, AsyncCallback callback, object state);

        /// <include file='../System.Activities.xml' path='/doc/members/member[@name="M:System.Activities.WorkflowInvoker.BeginInvoke(System.Collections.Generic.IDictionary{System.String,System.Object},System.AsyncCallback,System.Object)"]/*' />
        IAsyncResult BeginInvoke(IDictionary<string,object> inputs, AsyncCallback callback, object state);

        /// <include file='../System.Activities.xml' path='/doc/members/member[@name="M:System.Activities.WorkflowInvoker.BeginInvoke(System.Collections.Generic.IDictionary{System.String,System.Object},System.TimeSpan,System.AsyncCallback,System.Object)"]/*' />
        IAsyncResult BeginInvoke(IDictionary<string,object> inputs, TimeSpan timeout, AsyncCallback callback, object state);
#pragma warning restore 1584,1658
    }
}