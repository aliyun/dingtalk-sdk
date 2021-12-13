// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class MasterDataQueryResponseBody : TeaModel {
        /// <summary>
        /// 是否还有更多
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// 分页游标
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public long? NextToken { get; set; }

        /// <summary>
        /// 结果
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<MasterDataQueryResponseBodyResult> Result { get; set; }
        public class MasterDataQueryResponseBodyResult : TeaModel {
            /// <summary>
            /// 唯一id
            /// </summary>
            [NameInMap("outerId")]
            [Validation(Required=false)]
            public string OuterId { get; set; }

            /// <summary>
            /// 领域
            /// </summary>
            [NameInMap("scopeCode")]
            [Validation(Required=false)]
            public string ScopeCode { get; set; }

            /// <summary>
            /// 编码
            /// </summary>
            [NameInMap("viewEntityCode")]
            [Validation(Required=false)]
            public string ViewEntityCode { get; set; }

            /// <summary>
            /// 字段列表
            /// </summary>
            [NameInMap("viewEntityFieldVOList")]
            [Validation(Required=false)]
            public List<MasterDataQueryResponseBodyResultViewEntityFieldVOList> ViewEntityFieldVOList { get; set; }
            public class MasterDataQueryResponseBodyResultViewEntityFieldVOList : TeaModel {
                /// <summary>
                /// 字段code
                /// </summary>
                [NameInMap("fieldCode")]
                [Validation(Required=false)]
                public string FieldCode { get; set; }

                /// <summary>
                /// 字段值
                /// </summary>
                [NameInMap("fieldDataVO")]
                [Validation(Required=false)]
                public MasterDataQueryResponseBodyResultViewEntityFieldVOListFieldDataVO FieldDataVO { get; set; }
                public class MasterDataQueryResponseBodyResultViewEntityFieldVOListFieldDataVO : TeaModel {
                    [NameInMap("key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }
                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }
                };

                /// <summary>
                /// 字段名称
                /// </summary>
                [NameInMap("fieldName")]
                [Validation(Required=false)]
                public string FieldName { get; set; }

                /// <summary>
                /// 字段类型
                /// </summary>
                [NameInMap("fieldType")]
                [Validation(Required=false)]
                public string FieldType { get; set; }

            }

            /// <summary>
            /// 关联id列表，一般为userId
            /// </summary>
            [NameInMap("relationId")]
            [Validation(Required=false)]
            public string RelationId { get; set; }

        }

        /// <summary>
        /// 是否成功
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// 总条目数
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
