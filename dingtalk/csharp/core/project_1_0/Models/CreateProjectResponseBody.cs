// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class CreateProjectResponseBody : TeaModel {
        /// <summary>
        /// 返回结果。
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public CreateProjectResponseBodyResult Result { get; set; }
        public class CreateProjectResponseBodyResult : TeaModel {
            /// <summary>
            /// 创建时间。
            /// </summary>
            [NameInMap("created")]
            [Validation(Required=false)]
            public string Created { get; set; }

            /// <summary>
            /// 创建人ID。
            /// </summary>
            [NameInMap("creatorId")]
            [Validation(Required=false)]
            public string CreatorId { get; set; }

            /// <summary>
            /// 自定义字段值集合。
            /// </summary>
            [NameInMap("customfields")]
            [Validation(Required=false)]
            public List<CreateProjectResponseBodyResultCustomfields> Customfields { get; set; }
            public class CreateProjectResponseBodyResultCustomfields : TeaModel {
                /// <summary>
                /// 自定义字段ID。
                /// </summary>
                [NameInMap("customfieldId")]
                [Validation(Required=false)]
                public string CustomfieldId { get; set; }

                /// <summary>
                /// 自定义字段类型。
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// 自定义字段值列表。
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public List<CreateProjectResponseBodyResultCustomfieldsValue> Value { get; set; }
                public class CreateProjectResponseBodyResultCustomfieldsValue : TeaModel {
                    /// <summary>
                    /// 自定义字段值ID。
                    /// </summary>
                    [NameInMap("fieldvalueId")]
                    [Validation(Required=false)]
                    public string FieldvalueId { get; set; }

                    /// <summary>
                    /// 自定义字段值元属性。
                    /// </summary>
                    [NameInMap("metaString")]
                    [Validation(Required=false)]
                    public string MetaString { get; set; }

                    /// <summary>
                    /// 自定义字段值内容。
                    /// </summary>
                    [NameInMap("title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

            }

            /// <summary>
            /// 项目默认文件夹ID。
            /// </summary>
            [NameInMap("defaultCollectionId")]
            [Validation(Required=false)]
            public string DefaultCollectionId { get; set; }

            /// <summary>
            /// 是否在回收站。
            /// </summary>
            [NameInMap("isArchived")]
            [Validation(Required=false)]
            public bool? IsArchived { get; set; }

            /// <summary>
            /// 是否归档。
            /// </summary>
            [NameInMap("isSuspended")]
            [Validation(Required=false)]
            public bool? IsSuspended { get; set; }

            /// <summary>
            /// 是否为模版项目。
            /// </summary>
            [NameInMap("isTemplate")]
            [Validation(Required=false)]
            public bool? IsTemplate { get; set; }

            /// <summary>
            /// 项目封面。
            /// </summary>
            [NameInMap("logo")]
            [Validation(Required=false)]
            public string Logo { get; set; }

            /// <summary>
            /// 项目名称。
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 项目类型。
            /// </summary>
            [NameInMap("normalType")]
            [Validation(Required=false)]
            public string NormalType { get; set; }

            /// <summary>
            /// 项目ID。
            /// </summary>
            [NameInMap("projectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            /// <summary>
            /// 项目根文件夹ID。
            /// </summary>
            [NameInMap("rootCollectionId")]
            [Validation(Required=false)]
            public string RootCollectionId { get; set; }

            /// <summary>
            /// 来源项目ID。
            /// </summary>
            [NameInMap("sourceId")]
            [Validation(Required=false)]
            public string SourceId { get; set; }

            /// <summary>
            /// 任务ID前缀。
            /// </summary>
            [NameInMap("uniqueIdPrefix")]
            [Validation(Required=false)]
            public string UniqueIdPrefix { get; set; }

            /// <summary>
            /// 更新时间。
            /// </summary>
            [NameInMap("updated")]
            [Validation(Required=false)]
            public string Updated { get; set; }

            /// <summary>
            /// 项目可见性。
            /// </summary>
            [NameInMap("visibility")]
            [Validation(Required=false)]
            public string Visibility { get; set; }

        }

    }

}
