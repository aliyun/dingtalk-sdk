// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class UpdateOrganizationTaskPriorityRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("disableActivity")]
        [Validation(Required=false)]
        public bool? DisableActivity { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("disableNotification")]
        [Validation(Required=false)]
        public bool? DisableNotification { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-10</para>
        /// </summary>
        [NameInMap("priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

    }

}
