// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrbrain_1_0.Models
{
    public class HrbrainDeleteEduExpRequest : TeaModel {
        [NameInMap("params")]
        [Validation(Required=false)]
        public List<HrbrainDeleteEduExpRequestParams> Params { get; set; }
        public class HrbrainDeleteEduExpRequestParams : TeaModel {
            [NameInMap("eduName")]
            [Validation(Required=false)]
            public string EduName { get; set; }

            [NameInMap("endDate")]
            [Validation(Required=false)]
            public string EndDate { get; set; }

            [NameInMap("schoolName")]
            [Validation(Required=false)]
            public string SchoolName { get; set; }

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
