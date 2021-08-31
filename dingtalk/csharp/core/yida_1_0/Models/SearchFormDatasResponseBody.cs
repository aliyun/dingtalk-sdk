// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class SearchFormDatasResponseBody : TeaModel {
        /// <summary>
        /// 当前页
        /// </summary>
        [NameInMap("currentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        /// <summary>
        /// 符合条件的实例总数
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// 实例详情列表
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<SearchFormDatasResponseBodyData> Data { get; set; }
        public class SearchFormDatasResponseBodyData : TeaModel {
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// 实例ID
            /// </summary>
            [NameInMap("formInstId")]
            [Validation(Required=false)]
            public string FormInstId { get; set; }

            /// <summary>
            /// 数据创建时间
            /// </summary>
            [NameInMap("createdTimeGMT")]
            [Validation(Required=false)]
            public string CreatedTimeGMT { get; set; }

            /// <summary>
            /// 最近修改时间
            /// </summary>
            [NameInMap("modifiedTimeGMT")]
            [Validation(Required=false)]
            public string ModifiedTimeGMT { get; set; }

            /// <summary>
            /// 表单id
            /// </summary>
            [NameInMap("formUuid")]
            [Validation(Required=false)]
            public string FormUuid { get; set; }

            /// <summary>
            /// 模型id
            /// </summary>
            [NameInMap("modelUuid")]
            [Validation(Required=false)]
            public string ModelUuid { get; set; }

            /// <summary>
            /// 发起人
            /// </summary>
            [NameInMap("originator")]
            [Validation(Required=false)]
            public SearchFormDatasResponseBodyDataOriginator Originator { get; set; }
            public class SearchFormDatasResponseBodyDataOriginator : TeaModel {
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }
                [NameInMap("name")]
                [Validation(Required=false)]
                public SearchFormDatasResponseBodyDataOriginatorName Name { get; set; }
                public class SearchFormDatasResponseBodyDataOriginatorName : TeaModel {
                    /// <summary>
                    /// 中文名称
                    /// </summary>
                    [NameInMap("nameInChinese")]
                    [Validation(Required=false)]
                    public string NameInChinese { get; set; }

                    /// <summary>
                    /// 英文名称
                    /// </summary>
                    [NameInMap("nameInEnglish")]
                    [Validation(Required=false)]
                    public string NameInEnglish { get; set; }

                    /// <summary>
                    /// 国际化
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }
                [NameInMap("departmentName")]
                [Validation(Required=false)]
                public string DepartmentName { get; set; }
                [NameInMap("email")]
                [Validation(Required=false)]
                public string Email { get; set; }
            };

            /// <summary>
            /// 修改者
            /// </summary>
            [NameInMap("modifyUser")]
            [Validation(Required=false)]
            public SearchFormDatasResponseBodyDataModifyUser ModifyUser { get; set; }
            public class SearchFormDatasResponseBodyDataModifyUser : TeaModel {
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }
                [NameInMap("name")]
                [Validation(Required=false)]
                public SearchFormDatasResponseBodyDataModifyUserName Name { get; set; }
                public class SearchFormDatasResponseBodyDataModifyUserName : TeaModel {
                    /// <summary>
                    /// 中文名称
                    /// </summary>
                    [NameInMap("nameInChinese")]
                    [Validation(Required=false)]
                    public string NameInChinese { get; set; }

                    /// <summary>
                    /// 英文名称
                    /// </summary>
                    [NameInMap("nameInEnglish")]
                    [Validation(Required=false)]
                    public string NameInEnglish { get; set; }

                    /// <summary>
                    /// 国际化
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }
                [NameInMap("departmentName")]
                [Validation(Required=false)]
                public string DepartmentName { get; set; }
                [NameInMap("email")]
                [Validation(Required=false)]
                public string Email { get; set; }
            };

            /// <summary>
            /// 表单数据
            /// </summary>
            [NameInMap("formData")]
            [Validation(Required=false)]
            public Dictionary<string, object> FormData { get; set; }

            /// <summary>
            /// 标题
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// 流水号
            /// </summary>
            [NameInMap("serialNo")]
            [Validation(Required=false)]
            public string SerialNo { get; set; }

            /// <summary>
            /// 表单实例原始格式值
            /// </summary>
            [NameInMap("instanceValue")]
            [Validation(Required=false)]
            public string InstanceValue { get; set; }

            /// <summary>
            /// 数据版本
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public long? Version { get; set; }

            /// <summary>
            /// 创建人
            /// </summary>
            [NameInMap("creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// 修改人
            /// </summary>
            [NameInMap("modifier")]
            [Validation(Required=false)]
            public string Modifier { get; set; }

            /// <summary>
            /// 批次号
            /// </summary>
            [NameInMap("sequence")]
            [Validation(Required=false)]
            public string Sequence { get; set; }

        }

    }

}
