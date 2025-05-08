// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class BatchUpdateExternalTitleRequest : TeaModel {
        [NameInMap("operatorUserId")]
        [Validation(Required=false)]
        public string OperatorUserId { get; set; }

        [NameInMap("updateTitleModelList")]
        [Validation(Required=false)]
        public List<BatchUpdateExternalTitleRequestUpdateTitleModelList> UpdateTitleModelList { get; set; }
        public class BatchUpdateExternalTitleRequestUpdateTitleModelList : TeaModel {
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
