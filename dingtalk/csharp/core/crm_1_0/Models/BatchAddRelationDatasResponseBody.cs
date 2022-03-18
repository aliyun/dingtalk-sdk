// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class BatchAddRelationDatasResponseBody : TeaModel {
        /// <summary>
        /// 批量插入结果列表，results的结果和要新增的数据是一一对应的，可以获取到每条数据分别是否成功。
        /// </summary>
        [NameInMap("results")]
        [Validation(Required=false)]
        public List<BatchAddRelationDatasResponseBodyResults> Results { get; set; }
        public class BatchAddRelationDatasResponseBodyResults : TeaModel {
            /// <summary>
            /// 如果因为查重导致失败，表示重复的关系数据id列表。
            /// </summary>
            [NameInMap("duplicatedRelationIds")]
            [Validation(Required=false)]
            public List<string> DuplicatedRelationIds { get; set; }

            /// <summary>
            /// 如果保存失败，则表示失败的错误码。
            /// </summary>
            [NameInMap("errorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// 如果保存失败，则表示失败的错误原因。
            /// </summary>
            [NameInMap("errorMsg")]
            [Validation(Required=false)]
            public string ErrorMsg { get; set; }

            /// <summary>
            /// 保存成功的关系id。
            /// </summary>
            [NameInMap("relationId")]
            [Validation(Required=false)]
            public string RelationId { get; set; }

            /// <summary>
            /// 数据是否保存成功。
            /// </summary>
            [NameInMap("success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

    }

}
