// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class SearchOranizationCustomfieldResponseBody : TeaModel {
        /// <summary>
        /// 供分页使用，下一页token，从当前页结果中获取。
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 自定义字段列表。
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<SearchOranizationCustomfieldResponseBodyResult> Result { get; set; }
        public class SearchOranizationCustomfieldResponseBodyResult : TeaModel {
            /// <summary>
            /// 高级自定义字段。
            /// </summary>
            [NameInMap("advancedCustomfield")]
            [Validation(Required=false)]
            public SearchOranizationCustomfieldResponseBodyResultAdvancedCustomfield AdvancedCustomfield { get; set; }
            public class SearchOranizationCustomfieldResponseBodyResultAdvancedCustomfield : TeaModel {
                /// <summary>
                /// 字段类型ID。
                /// </summary>
                [NameInMap("advancedCustomfieldId")]
                [Validation(Required=false)]
                public string AdvancedCustomfieldId { get; set; }

                /// <summary>
                /// 字段类型名称
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// 字段类型名称2
                /// </summary>
                [NameInMap("objectType")]
                [Validation(Required=false)]
                public string ObjectType { get; set; }

            }

            /// <summary>
            /// 如果是单选或多选字段，这里是可选项的值
            /// </summary>
            [NameInMap("choices")]
            [Validation(Required=false)]
            public List<SearchOranizationCustomfieldResponseBodyResultChoices> Choices { get; set; }
            public class SearchOranizationCustomfieldResponseBodyResultChoices : TeaModel {
                /// <summary>
                /// 选项ID。
                /// </summary>
                [NameInMap("choiceId")]
                [Validation(Required=false)]
                public string ChoiceId { get; set; }

                /// <summary>
                /// 选项值。
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

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
            /// 自定义字段ID。
            /// </summary>
            [NameInMap("customfieldsId")]
            [Validation(Required=false)]
            public string CustomfieldsId { get; set; }

            /// <summary>
            /// 字段名称。
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 用户自定义数据载体，json格式类型任意数据。
            /// </summary>
            [NameInMap("payload")]
            [Validation(Required=false)]
            public Dictionary<string, object> Payload { get; set; }

            /// <summary>
            /// 字段类型。   'number', // 数字     'date', // 日期     'text', // 文本     'work',     'multipleChoice', // 多选     'dropDown', // 下拉,     'lookup',     'commongroup',     'cascading', // 层级字段     'rtf', // 多行文本/富文本 字段 'lookup2' // 新高级字段
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// 总数。
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
