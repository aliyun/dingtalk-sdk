// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class BatchGetFormDataByIdListResponseBody : TeaModel {
        /// <summary>
        /// 表单实例数据
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<BatchGetFormDataByIdListResponseBodyResult> Result { get; set; }
        public class BatchGetFormDataByIdListResponseBodyResult : TeaModel {
            /// <summary>
            /// 创建时间
            /// </summary>
            [NameInMap("createTimeGMT")]
            [Validation(Required=false)]
            public string CreateTimeGMT { get; set; }

            /// <summary>
            /// 创建者的userId
            /// </summary>
            [NameInMap("creatorUserId")]
            [Validation(Required=false)]
            public string CreatorUserId { get; set; }

            /// <summary>
            /// 表单实例数据
            /// </summary>
            [NameInMap("formData")]
            [Validation(Required=false)]
            public Dictionary<string, object> FormData { get; set; }

            /// <summary>
            /// 表单实例id
            /// </summary>
            [NameInMap("formInstanceId")]
            [Validation(Required=false)]
            public string FormInstanceId { get; set; }

            /// <summary>
            /// 表单编码
            /// </summary>
            [NameInMap("formUuid")]
            [Validation(Required=false)]
            public string FormUuid { get; set; }

            /// <summary>
            /// 数据库表记录主键id
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// 实例数据
            /// </summary>
            [NameInMap("instanceValue")]
            [Validation(Required=false)]
            public string InstanceValue { get; set; }

            /// <summary>
            /// 修改时间
            /// </summary>
            [NameInMap("modifiedTimeGMT")]
            [Validation(Required=false)]
            public string ModifiedTimeGMT { get; set; }

            /// <summary>
            /// 修改者的钉钉userId
            /// </summary>
            [NameInMap("modifier")]
            [Validation(Required=false)]
            public string Modifier { get; set; }

            /// <summary>
            /// 修改者
            /// </summary>
            [NameInMap("modifyUser")]
            [Validation(Required=false)]
            public BatchGetFormDataByIdListResponseBodyResultModifyUser ModifyUser { get; set; }
            public class BatchGetFormDataByIdListResponseBodyResultModifyUser : TeaModel {
                [NameInMap("name")]
                [Validation(Required=false)]
                public BatchGetFormDataByIdListResponseBodyResultModifyUserName Name { get; set; }
                public class BatchGetFormDataByIdListResponseBodyResultModifyUserName : TeaModel {
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

                }
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }
            };

            /// <summary>
            /// 表单提交人
            /// </summary>
            [NameInMap("originator")]
            [Validation(Required=false)]
            public BatchGetFormDataByIdListResponseBodyResultOriginator Originator { get; set; }
            public class BatchGetFormDataByIdListResponseBodyResultOriginator : TeaModel {
                [NameInMap("name")]
                [Validation(Required=false)]
                public BatchGetFormDataByIdListResponseBodyResultOriginatorName Name { get; set; }
                public class BatchGetFormDataByIdListResponseBodyResultOriginatorName : TeaModel {
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

                }
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }
            };

            /// <summary>
            /// 该表单实例对应的批量导入的批次号(如果是通过批量导入创建的)
            /// </summary>
            [NameInMap("sequence")]
            [Validation(Required=false)]
            public string Sequence { get; set; }

            /// <summary>
            /// 流水号
            /// </summary>
            [NameInMap("serialNumber")]
            [Validation(Required=false)]
            public string SerialNumber { get; set; }

            /// <summary>
            /// 标题
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// 该表单实例对应的表单schema版本
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public long? Version { get; set; }

        }

    }

}
