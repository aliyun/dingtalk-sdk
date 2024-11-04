// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrbrain_1_0.Models
{
    public class HrbrainDeletePerfEvalRequest : TeaModel {
        [NameInMap("params")]
        [Validation(Required=false)]
        public List<HrbrainDeletePerfEvalRequestParams> Params { get; set; }
        public class HrbrainDeletePerfEvalRequestParams : TeaModel {
            [NameInMap("perfPlanName")]
            [Validation(Required=false)]
            public string PerfPlanName { get; set; }

            [NameInMap("period")]
            [Validation(Required=false)]
            public string Period { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("workNo")]
            [Validation(Required=false)]
            public string WorkNo { get; set; }

        }

    }

}
