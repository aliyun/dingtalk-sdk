// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontract_1_0.Models
{
    public class EsignQueryApprovalInfoResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public EsignQueryApprovalInfoResponseBodyResult Result { get; set; }
        public class EsignQueryApprovalInfoResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>202311081619000455501</para>
            /// </summary>
            [NameInMap("bpmsProcessBusinessId")]
            [Validation(Required=false)]
            public string BpmsProcessBusinessId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>O6wNhB4wTMajvNW8Dc_Rjg09301699431585</para>
            /// </summary>
            [NameInMap("bpmsProcessInstanceId")]
            [Validation(Required=false)]
            public string BpmsProcessInstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://aflow.dingtalk.com/dingtalk/pc/query/pchomepage.htm?corpid=ding6c3948a9e37c439c35c2f4657eb6378f&swfrom=https://n.dingtalk.com/dingding/h5-contract/contractPC/index.html#/approval?procInstId=O6wNhB4wTMajvNW8Dc_Rjg09301699431585">https://aflow.dingtalk.com/dingtalk/pc/query/pchomepage.htm?corpid=ding6c3948a9e37c439c35c2f4657eb6378f&amp;swfrom=https://n.dingtalk.com/dingding/h5-contract/contractPC/index.html#/approval?procInstId=O6wNhB4wTMajvNW8Dc_Rjg09301699431585</a></para>
            /// </summary>
            [NameInMap("bpmsProcessInstanceUrl")]
            [Validation(Required=false)]
            public string BpmsProcessInstanceUrl { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
