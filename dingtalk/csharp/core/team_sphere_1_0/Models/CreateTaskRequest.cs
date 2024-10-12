// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkteam_sphere_1_0.Models
{
    public class CreateTaskRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>任务标题</para>
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("customfields")]
        [Validation(Required=false)]
        public List<CreateTaskRequestCustomfields> Customfields { get; set; }
        public class CreateTaskRequestCustomfields : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>62fb0bxxxxxxx</para>
            /// </summary>
            [NameInMap("customfieldId")]
            [Validation(Required=false)]
            public string CustomfieldId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>自定义字段-文本</para>
            /// </summary>
            [NameInMap("customfieldName")]
            [Validation(Required=false)]
            public string CustomfieldName { get; set; }

            [NameInMap("value")]
            [Validation(Required=false)]
            public List<CreateTaskRequestCustomfieldsValue> Value { get; set; }
            public class CreateTaskRequestCustomfieldsValue : TeaModel {
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("thumbUrl")]
                [Validation(Required=false)]
                public string ThumbUrl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>我是自定义字段显示值</para>
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2022-06-13T07:36:50.318Z</para>
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
        /// <para>62c25e3b376exxxxxx</para>
        /// </summary>
        [NameInMap("projectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

    }

}
