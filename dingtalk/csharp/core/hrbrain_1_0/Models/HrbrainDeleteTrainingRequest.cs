// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrbrain_1_0.Models
{
    public class HrbrainDeleteTrainingRequest : TeaModel {
        [NameInMap("params")]
        [Validation(Required=false)]
        public List<HrbrainDeleteTrainingRequestParams> Params { get; set; }
        public class HrbrainDeleteTrainingRequestParams : TeaModel {
            [NameInMap("trainEndDate")]
            [Validation(Required=false)]
            public string TrainEndDate { get; set; }

            [NameInMap("trainName")]
            [Validation(Required=false)]
            public string TrainName { get; set; }

            [NameInMap("trainStartDate")]
            [Validation(Required=false)]
            public string TrainStartDate { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("workNo")]
            [Validation(Required=false)]
            public string WorkNo { get; set; }

        }

    }

}
