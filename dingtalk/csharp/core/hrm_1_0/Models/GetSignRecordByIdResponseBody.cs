// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class GetSignRecordByIdResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<GetSignRecordByIdResponseBodyResult> Result { get; set; }
        public class GetSignRecordByIdResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>ding12345678</para>
            /// </summary>
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>员工签署中</para>
            /// </summary>
            [NameInMap("remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1723534265000</para>
            /// </summary>
            [NameInMap("signExpireTime")]
            [Validation(Required=false)]
            public long? SignExpireTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxxx-合同文件.pdf</para>
            /// </summary>
            [NameInMap("signFileName")]
            [Validation(Required=false)]
            public string SignFileName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1723534265000</para>
            /// </summary>
            [NameInMap("signFinishTime")]
            [Validation(Required=false)]
            public long? SignFinishTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxxx有限公司</para>
            /// </summary>
            [NameInMap("signLegalEntityName")]
            [Validation(Required=false)]
            public string SignLegalEntityName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>6fe06f57ab5a45078f3219be8fd829c6</para>
            /// </summary>
            [NameInMap("signRecordId")]
            [Validation(Required=false)]
            public string SignRecordId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1723534265000</para>
            /// </summary>
            [NameInMap("signStartTime")]
            [Validation(Required=false)]
            public long? SignStartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SIGNING</para>
            /// </summary>
            [NameInMap("signStatus")]
            [Validation(Required=false)]
            public string SignStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>签署中</para>
            /// </summary>
            [NameInMap("signStatusRemarks")]
            [Validation(Required=false)]
            public string SignStatusRemarks { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CONTRACT</para>
            /// </summary>
            [NameInMap("signTemplateType")]
            [Validation(Required=false)]
            public string SignTemplateType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>400873120394</para>
            /// </summary>
            [NameInMap("signUserId")]
            [Validation(Required=false)]
            public string SignUserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xiaoming</para>
            /// </summary>
            [NameInMap("signUserName")]
            [Validation(Required=false)]
            public string SignUserName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ON_LINE</para>
            /// </summary>
            [NameInMap("signWay")]
            [Validation(Required=false)]
            public string SignWay { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
