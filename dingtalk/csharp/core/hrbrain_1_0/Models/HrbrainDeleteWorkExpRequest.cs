// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrbrain_1_0.Models
{
    public class HrbrainDeleteWorkExpRequest : TeaModel {
        [NameInMap("params")]
        [Validation(Required=false)]
        public List<HrbrainDeleteWorkExpRequestParams> Params { get; set; }
        public class HrbrainDeleteWorkExpRequestParams : TeaModel {
            [NameInMap("companyName")]
            [Validation(Required=false)]
            public string CompanyName { get; set; }

            [NameInMap("endDate")]
            [Validation(Required=false)]
            public string EndDate { get; set; }

            [NameInMap("startDate")]
            [Validation(Required=false)]
            public string StartDate { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("workNo")]
            [Validation(Required=false)]
            public string WorkNo { get; set; }

        }

    }

}
