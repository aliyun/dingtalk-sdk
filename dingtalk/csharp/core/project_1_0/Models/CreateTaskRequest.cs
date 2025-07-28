// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
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
            /// <para>自定义字段别名</para>
            /// </summary>
            [NameInMap("customfieldAlias")]
            [Validation(Required=false)]
            public string CustomfieldAlias { get; set; }

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
        /// <b>Example:</b>
        /// <para>62c25e3b376exxxxxx</para>
        /// </summary>
        [NameInMap("parentTaskId")]
        [Validation(Required=false)]
        public string ParentTaskId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>-10</para>
        /// </summary>
        [NameInMap("priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>通过名称填写优先级</para>
        /// </summary>
        [NameInMap("priorityName")]
        [Validation(Required=false)]
        public string PriorityName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>62c25e3b376exxxxxx</para>
        /// </summary>
        [NameInMap("projectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>通过名称填写所属项目</para>
        /// </summary>
        [NameInMap("projectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>62c25e3b376exxxxxx</para>
        /// </summary>
        [NameInMap("scenariofieldconfigId")]
        [Validation(Required=false)]
        public string ScenariofieldconfigId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>62c25e3b376exxxxxx</para>
        /// </summary>
        [NameInMap("sprintId")]
        [Validation(Required=false)]
        public string SprintId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>62c25e3b376exxxxxx</para>
        /// </summary>
        [NameInMap("stageId")]
        [Validation(Required=false)]
        public string StageId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2022-06-13T07:36:50.318Z</para>
        /// </summary>
        [NameInMap("startDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("storyPoint")]
        [Validation(Required=false)]
        public string StoryPoint { get; set; }

        [NameInMap("tagIds")]
        [Validation(Required=false)]
        public List<string> TagIds { get; set; }

        [NameInMap("tagNames")]
        [Validation(Required=false)]
        public List<string> TagNames { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>62c25e3b376exxxxxx</para>
        /// </summary>
        [NameInMap("taskflowstatusId")]
        [Validation(Required=false)]
        public string TaskflowstatusId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>62c25e3b376exxxxxx</para>
        /// </summary>
        [NameInMap("tasklistId")]
        [Validation(Required=false)]
        public string TasklistId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>通过名称填写任务状态</para>
        /// </summary>
        [NameInMap("tfsName")]
        [Validation(Required=false)]
        public string TfsName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>members</para>
        /// </summary>
        [NameInMap("visible")]
        [Validation(Required=false)]
        public string Visible { get; set; }

    }

}
