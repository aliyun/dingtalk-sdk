// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class GetUserSignedRecordsByOuterIdResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<GetUserSignedRecordsByOuterIdResponseBodyResult> Result { get; set; }
        public class GetUserSignedRecordsByOuterIdResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>ding33a9d1a6e9647854a39a90f97fcb1e09</para>
            /// </summary>
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>测试</para>
            /// </summary>
            [NameInMap("remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1720775436000</para>
            /// </summary>
            [NameInMap("signExpireTime")]
            [Validation(Required=false)]
            public string SignExpireTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>小明-劳动合同-20240808.pdf</para>
            /// </summary>
            [NameInMap("signFileName")]
            [Validation(Required=false)]
            public string SignFileName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://n.dingtalk.com/xxx">https://n.dingtalk.com/xxx</a></para>
            /// </summary>
            [NameInMap("signFileUrl")]
            [Validation(Required=false)]
            public string SignFileUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1720775436000</para>
            /// </summary>
            [NameInMap("signFinishTime")]
            [Validation(Required=false)]
            public string SignFinishTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xx公司</para>
            /// </summary>
            [NameInMap("signLegalEntityName")]
            [Validation(Required=false)]
            public string SignLegalEntityName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>fb1a9c4adaba4f52b7cab7941008b9dd</para>
            /// </summary>
            [NameInMap("signRecordId")]
            [Validation(Required=false)]
            public string SignRecordId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1720775436000</para>
            /// </summary>
            [NameInMap("signStartTime")]
            [Validation(Required=false)]
            public string SignStartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>FINISHED</para>
            /// </summary>
            [NameInMap("signStatus")]
            [Validation(Required=false)]
            public string SignStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>法人公司未开通</para>
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
            /// <para>userId123</para>
            /// </summary>
            [NameInMap("signUserId")]
            [Validation(Required=false)]
            public string SignUserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>userName</para>
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

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
