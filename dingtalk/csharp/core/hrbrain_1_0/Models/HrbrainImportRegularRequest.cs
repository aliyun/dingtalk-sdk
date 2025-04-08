// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrbrain_1_0.Models
{
    public class HrbrainImportRegularRequest : TeaModel {
        [NameInMap("body")]
        [Validation(Required=false)]
        public List<HrbrainImportRegularRequestBody> Body { get; set; }
        public class HrbrainImportRegularRequestBody : TeaModel {
            [NameInMap("deptName")]
            [Validation(Required=false)]
            public string DeptName { get; set; }

            [NameInMap("deptNo")]
            [Validation(Required=false)]
            public string DeptNo { get; set; }

            [NameInMap("extendInfo")]
            [Validation(Required=false)]
            public Dictionary<string, object> ExtendInfo { get; set; }

            [NameInMap("jobCodeName")]
            [Validation(Required=false)]
            public string JobCodeName { get; set; }

            [NameInMap("jobLevel")]
            [Validation(Required=false)]
            public string JobLevel { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("planRegularDate")]
            [Validation(Required=false)]
            public string PlanRegularDate { get; set; }

            [NameInMap("postName")]
            [Validation(Required=false)]
            public string PostName { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("regularDate")]
            [Validation(Required=false)]
            public string RegularDate { get; set; }

            [NameInMap("superEmpId")]
            [Validation(Required=false)]
            public string SuperEmpId { get; set; }

            [NameInMap("superName")]
            [Validation(Required=false)]
            public string SuperName { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("workNo")]
            [Validation(Required=false)]
            public string WorkNo { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

    }

}
