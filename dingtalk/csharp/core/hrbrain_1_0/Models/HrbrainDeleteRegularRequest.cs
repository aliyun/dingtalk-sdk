// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrbrain_1_0.Models
{
    public class HrbrainDeleteRegularRequest : TeaModel {
        [NameInMap("params")]
        [Validation(Required=false)]
        public List<HrbrainDeleteRegularRequestParams> Params { get; set; }
        public class HrbrainDeleteRegularRequestParams : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("regularDate")]
            [Validation(Required=false)]
            public string RegularDate { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("workNo")]
            [Validation(Required=false)]
            public string WorkNo { get; set; }

        }

    }

}
