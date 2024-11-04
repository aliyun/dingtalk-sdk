// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrbrain_1_0.Models
{
    public class HrbrainDeleteDimissionRequest : TeaModel {
        [NameInMap("params")]
        [Validation(Required=false)]
        public List<HrbrainDeleteDimissionRequestParams> Params { get; set; }
        public class HrbrainDeleteDimissionRequestParams : TeaModel {
            [NameInMap("dimissionDate")]
            [Validation(Required=false)]
            public string DimissionDate { get; set; }

            [NameInMap("workNo")]
            [Validation(Required=false)]
            public string WorkNo { get; set; }

        }

    }

}
