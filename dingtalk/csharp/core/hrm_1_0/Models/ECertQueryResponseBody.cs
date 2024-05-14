// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class ECertQueryResponseBody : TeaModel {
        [NameInMap("certNO")]
        [Validation(Required=false)]
        public string CertNO { get; set; }

        [NameInMap("employJobId")]
        [Validation(Required=false)]
        public string EmployJobId { get; set; }

        [NameInMap("employJobIdLabel")]
        [Validation(Required=false)]
        public string EmployJobIdLabel { get; set; }

        [NameInMap("employPositionId")]
        [Validation(Required=false)]
        public string EmployPositionId { get; set; }

        [NameInMap("employPositionIdLabel")]
        [Validation(Required=false)]
        public string EmployPositionIdLabel { get; set; }

        [NameInMap("employPositionRankId")]
        [Validation(Required=false)]
        public string EmployPositionRankId { get; set; }

        [NameInMap("employPositionRankIdLabel")]
        [Validation(Required=false)]
        public string EmployPositionRankIdLabel { get; set; }

        [NameInMap("hiredDate")]
        [Validation(Required=false)]
        public string HiredDate { get; set; }

        [NameInMap("lastWorkDay")]
        [Validation(Required=false)]
        public string LastWorkDay { get; set; }

        [NameInMap("mainDeptId")]
        [Validation(Required=false)]
        public long? MainDeptId { get; set; }

        [NameInMap("mainDeptName")]
        [Validation(Required=false)]
        public string MainDeptName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("realName")]
        [Validation(Required=false)]
        public string RealName { get; set; }

        [NameInMap("terminationReasonPassive")]
        [Validation(Required=false)]
        public List<string> TerminationReasonPassive { get; set; }

        [NameInMap("terminationReasonVoluntary")]
        [Validation(Required=false)]
        public List<string> TerminationReasonVoluntary { get; set; }

    }

}
