// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrbrain_1_0.Models
{
    public class HrbrainDeleteTransferEvalRequest : TeaModel {
        [NameInMap("params")]
        [Validation(Required=false)]
        public List<HrbrainDeleteTransferEvalRequestParams> Params { get; set; }
        public class HrbrainDeleteTransferEvalRequestParams : TeaModel {
            [NameInMap("transferDate")]
            [Validation(Required=false)]
            public string TransferDate { get; set; }

            [NameInMap("transferType")]
            [Validation(Required=false)]
            public string TransferType { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("workNo")]
            [Validation(Required=false)]
            public string WorkNo { get; set; }

        }

    }

}
