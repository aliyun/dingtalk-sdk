// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrbrain_1_0.Models
{
    public class HrbrainDeleteDeptInfoRequest : TeaModel {
        [NameInMap("params")]
        [Validation(Required=false)]
        public List<HrbrainDeleteDeptInfoRequestParams> Params { get; set; }
        public class HrbrainDeleteDeptInfoRequestParams : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("deptNo")]
            [Validation(Required=false)]
            public string DeptNo { get; set; }

        }

    }

}
