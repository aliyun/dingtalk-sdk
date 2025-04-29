// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class GetSignRecordByUserIdResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetSignRecordByUserIdResponseBodyResult Result { get; set; }
        public class GetSignRecordByUserIdResponseBodyResult : TeaModel {
            [NameInMap("data")]
            [Validation(Required=false)]
            public List<GetSignRecordByUserIdResponseBodyResultData> Data { get; set; }
            public class GetSignRecordByUserIdResponseBodyResultData : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>ding57935b18bfd13e9735c2f4657eb6378f</para>
                /// </summary>
                [NameInMap("corpId")]
                [Validation(Required=false)]
                public string CorpId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CONTRACT_123456</para>
                /// </summary>
                [NameInMap("outerId")]
                [Validation(Required=false)]
                public string OuterId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>劳动合同电子签签署备注</para>
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
                public long? SignExpireTime { get; set; }

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
                public long? SignFinishTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xxx有限公司</para>
                /// </summary>
                [NameInMap("signLegalEntityName")]
                [Validation(Required=false)]
                public string SignLegalEntityName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>38bc7b69bb6a46b8a69b9001d5c0bdf3</para>
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
                public long? SignStartTime { get; set; }

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
                /// <para>660658</para>
                /// </summary>
                [NameInMap("signUserId")]
                [Validation(Required=false)]
                public string SignUserId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>小明</para>
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

            [NameInMap("hasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }

            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public long? NextToken { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
