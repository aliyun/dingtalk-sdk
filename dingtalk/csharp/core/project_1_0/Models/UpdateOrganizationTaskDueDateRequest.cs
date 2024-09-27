// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class UpdateOrganizationTaskDueDateRequest : TeaModel {
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
        /// <para>2022-06-13T03:30:42.830Z</para>
        /// </summary>
        [NameInMap("dueDate")]
        [Validation(Required=false)]
        public string DueDate { get; set; }

    }

}
