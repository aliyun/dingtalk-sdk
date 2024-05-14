// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class CreateTaskRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("customfields")]
        [Validation(Required=false)]
        public List<CreateTaskRequestCustomfields> Customfields { get; set; }
        public class CreateTaskRequestCustomfields : TeaModel {
            [NameInMap("customfieldId")]
            [Validation(Required=false)]
            public string CustomfieldId { get; set; }

            [NameInMap("customfieldName")]
            [Validation(Required=false)]
            public string CustomfieldName { get; set; }

            [NameInMap("value")]
            [Validation(Required=false)]
            public List<CreateTaskRequestCustomfieldsValue> Value { get; set; }
            public class CreateTaskRequestCustomfieldsValue : TeaModel {
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

        }

        [NameInMap("dueDate")]
        [Validation(Required=false)]
        public string DueDate { get; set; }

        [NameInMap("executorId")]
        [Validation(Required=false)]
        public string ExecutorId { get; set; }

        [NameInMap("note")]
        [Validation(Required=false)]
        public string Note { get; set; }

        [NameInMap("parentTaskId")]
        [Validation(Required=false)]
        public string ParentTaskId { get; set; }

        [NameInMap("priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("projectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        [NameInMap("scenariofieldconfigId")]
        [Validation(Required=false)]
        public string ScenariofieldconfigId { get; set; }

        [NameInMap("stageId")]
        [Validation(Required=false)]
        public string StageId { get; set; }

        [NameInMap("startDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        [NameInMap("visible")]
        [Validation(Required=false)]
        public string Visible { get; set; }

    }

}
