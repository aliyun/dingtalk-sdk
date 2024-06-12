// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdatacenter_1_0.Models
{
    public class CreateDataDeliverRequest : TeaModel {
        [NameInMap("bizcode")]
        [Validation(Required=false)]
        public string Bizcode { get; set; }

        [NameInMap("param")]
        [Validation(Required=false)]
        public string Param { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        [NameInMap("dispatchingCycle")]
        [Validation(Required=false)]
        public string DispatchingCycle { get; set; }

        [NameInMap("dispatchingItemType")]
        [Validation(Required=false)]
        public string DispatchingItemType { get; set; }

        [NameInMap("dispatchingStartDate")]
        [Validation(Required=false)]
        public long? DispatchingStartDate { get; set; }

    }

}
