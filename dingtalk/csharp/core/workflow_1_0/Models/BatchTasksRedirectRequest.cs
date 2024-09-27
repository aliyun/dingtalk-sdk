// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class BatchTasksRedirectRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>staffId-B</para>
        /// </summary>
        [NameInMap("handoverUserId")]
        [Validation(Required=false)]
        public string HandoverUserId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>manager-12</para>
        /// </summary>
        [NameInMap("managerUserId")]
        [Validation(Required=false)]
        public string ManagerUserId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("taskIds")]
        [Validation(Required=false)]
        public List<long?> TaskIds { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>staffId-A</para>
        /// </summary>
        [NameInMap("transfereeUserId")]
        [Validation(Required=false)]
        public string TransfereeUserId { get; set; }

    }

}
