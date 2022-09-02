// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class QueryAllFormInstancesResponseBody : TeaModel {
        /// <summary>
        /// 分页结果
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public QueryAllFormInstancesResponseBodyResult Result { get; set; }
        public class QueryAllFormInstancesResponseBodyResult : TeaModel {
            /// <summary>
            /// 是否有更多数据
            /// </summary>
            [NameInMap("hasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }

            /// <summary>
            /// 分页大小
            /// </summary>
            [NameInMap("maxResults")]
            [Validation(Required=false)]
            public long? MaxResults { get; set; }

            /// <summary>
            /// 下一页的游标
            /// </summary>
            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// 表单列表
            /// </summary>
            [NameInMap("values")]
            [Validation(Required=false)]
            public List<QueryAllFormInstancesResponseBodyResultValues> Values { get; set; }
            public class QueryAllFormInstancesResponseBodyResultValues : TeaModel {
                /// <summary>
                /// 应用搭建id
                /// </summary>
                [NameInMap("appUuid")]
                [Validation(Required=false)]
                public string AppUuid { get; set; }

                /// <summary>
                /// 扩展信息
                /// </summary>
                [NameInMap("attributes")]
                [Validation(Required=false)]
                public Dictionary<string, object> Attributes { get; set; }

                /// <summary>
                /// 创建时间
                /// </summary>
                [NameInMap("createTimestamp")]
                [Validation(Required=false)]
                public long? CreateTimestamp { get; set; }

                /// <summary>
                /// 创建人
                /// </summary>
                [NameInMap("creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                /// <summary>
                /// 表单模板code
                /// </summary>
                [NameInMap("formCode")]
                [Validation(Required=false)]
                public string FormCode { get; set; }

                /// <summary>
                /// 表单实例数据
                /// </summary>
                [NameInMap("formInstDataList")]
                [Validation(Required=false)]
                public List<QueryAllFormInstancesResponseBodyResultValuesFormInstDataList> FormInstDataList { get; set; }
                public class QueryAllFormInstancesResponseBodyResultValuesFormInstDataList : TeaModel {
                    /// <summary>
                    /// 控件别名
                    /// </summary>
                    [NameInMap("bizAlias")]
                    [Validation(Required=false)]
                    public string BizAlias { get; set; }

                    /// <summary>
                    /// 控件类型
                    /// </summary>
                    [NameInMap("componentType")]
                    [Validation(Required=false)]
                    public string ComponentType { get; set; }

                    /// <summary>
                    /// 表单控件扩展数据
                    /// </summary>
                    [NameInMap("extendValue")]
                    [Validation(Required=false)]
                    public string ExtendValue { get; set; }

                    /// <summary>
                    /// 控件唯一id
                    /// </summary>
                    [NameInMap("key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// 控件名称
                    /// </summary>
                    [NameInMap("label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    /// <summary>
                    /// 控件填写的数据
                    /// </summary>
                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// 表单实例id
                /// </summary>
                [NameInMap("formInstanceId")]
                [Validation(Required=false)]
                public string FormInstanceId { get; set; }

                /// <summary>
                /// 修改人
                /// </summary>
                [NameInMap("modifier")]
                [Validation(Required=false)]
                public string Modifier { get; set; }

                /// <summary>
                /// 修改时间
                /// </summary>
                [NameInMap("modifyTimestamp")]
                [Validation(Required=false)]
                public long? ModifyTimestamp { get; set; }

                /// <summary>
                /// 外部业务编码
                /// </summary>
                [NameInMap("outBizCode")]
                [Validation(Required=false)]
                public string OutBizCode { get; set; }

                /// <summary>
                /// 外部实例编码
                /// </summary>
                [NameInMap("outInstanceId")]
                [Validation(Required=false)]
                public string OutInstanceId { get; set; }

                /// <summary>
                /// 标题
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

        }

    }

}
