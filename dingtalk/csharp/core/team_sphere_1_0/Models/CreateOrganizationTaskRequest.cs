// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkteam_sphere_1_0.Models
{
    public class CreateOrganizationTaskRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>明天12点前完成周报撰写</para>
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("disableActivity")]
        [Validation(Required=false)]
        public bool? DisableActivity { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("disableNotification")]
        [Validation(Required=false)]
        public bool? DisableNotification { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-08-13T07:36:50.318Z</para>
        /// </summary>
        [NameInMap("dueDate")]
        [Validation(Required=false)]
        public string DueDate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>173xxxx</para>
        /// </summary>
        [NameInMap("executorId")]
        [Validation(Required=false)]
        public string ExecutorId { get; set; }

        [NameInMap("involveMembers")]
        [Validation(Required=false)]
        public List<string> InvolveMembers { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>我是一条任务备注</para>
        /// </summary>
        [NameInMap("note")]
        [Validation(Required=false)]
        public string Note { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>involves</para>
        /// </summary>
        [NameInMap("visible")]
        [Validation(Required=false)]
        public string Visible { get; set; }

    }

}
