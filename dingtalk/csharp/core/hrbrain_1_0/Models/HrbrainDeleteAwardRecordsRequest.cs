// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrbrain_1_0.Models
{
    public class HrbrainDeleteAwardRecordsRequest : TeaModel {
        [NameInMap("params")]
        [Validation(Required=false)]
        public List<HrbrainDeleteAwardRecordsRequestParams> Params { get; set; }
        public class HrbrainDeleteAwardRecordsRequestParams : TeaModel {
            [NameInMap("awardDate")]
            [Validation(Required=false)]
            public string AwardDate { get; set; }

            [NameInMap("awardName")]
            [Validation(Required=false)]
            public string AwardName { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("workNo")]
            [Validation(Required=false)]
            public string WorkNo { get; set; }

        }

    }

}
