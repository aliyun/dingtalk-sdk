// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkorg_culture_1_0.Models
{
    public class AssignOrgHoldingToEmpHoldingBatchResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public AssignOrgHoldingToEmpHoldingBatchResponseBodyResult Result { get; set; }
        public class AssignOrgHoldingToEmpHoldingBatchResponseBodyResult : TeaModel {
            [NameInMap("openPointInvokeResultDTOS")]
            [Validation(Required=false)]
            public List<AssignOrgHoldingToEmpHoldingBatchResponseBodyResultOpenPointInvokeResultDTOS> OpenPointInvokeResultDTOS { get; set; }
            public class AssignOrgHoldingToEmpHoldingBatchResponseBodyResultOpenPointInvokeResultDTOS : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SUCCESS</para>
                /// </summary>
                [NameInMap("invokeStatus")]
                [Validation(Required=false)]
                public string InvokeStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("msg")]
                [Validation(Required=false)]
                public string Msg { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>23423568784</para>
                /// </summary>
                [NameInMap("outId")]
                [Validation(Required=false)]
                public string OutId { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>01274411491620908910</para>
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
