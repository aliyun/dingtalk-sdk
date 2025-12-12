// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class SendRealAuthInviteMessageResponseBody : TeaModel {
        [NameInMap("dingOpenErrcode")]
        [Validation(Required=false)]
        public int? DingOpenErrcode { get; set; }

        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public SendRealAuthInviteMessageResponseBodyResult Result { get; set; }
        public class SendRealAuthInviteMessageResponseBodyResult : TeaModel {
            [NameInMap("hadInvitedNum")]
            [Validation(Required=false)]
            public int? HadInvitedNum { get; set; }

            [NameInMap("hadRealAuthNum")]
            [Validation(Required=false)]
            public int? HadRealAuthNum { get; set; }

            [NameInMap("successNum")]
            [Validation(Required=false)]
            public int? SuccessNum { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
