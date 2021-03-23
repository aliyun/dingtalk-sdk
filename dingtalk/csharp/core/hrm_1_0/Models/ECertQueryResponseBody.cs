// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class ECertQueryResponseBody : TeaModel {
        /// <summary>
        /// 身份证姓名
        /// </summary>
        [NameInMap("realName")]
        [Validation(Required=false)]
        public string RealName { get; set; }

        /// <summary>
        /// 身份证号码
        /// </summary>
        [NameInMap("certNO")]
        [Validation(Required=false)]
        public string CertNO { get; set; }

        /// <summary>
        /// 主部门ID
        /// </summary>
        [NameInMap("mainDeptId")]
        [Validation(Required=false)]
        public long? MainDeptId { get; set; }

        /// <summary>
        /// 主部门
        /// </summary>
        [NameInMap("mainDeptName")]
        [Validation(Required=false)]
        public string MainDeptName { get; set; }

        /// <summary>
        /// 职务ID
        /// </summary>
        [NameInMap("employJobId")]
        [Validation(Required=false)]
        public string EmployJobId { get; set; }

        /// <summary>
        /// 职务名称
        /// </summary>
        [NameInMap("employJobIdLabel")]
        [Validation(Required=false)]
        public string EmployJobIdLabel { get; set; }

        /// <summary>
        /// 职位ID
        /// </summary>
        [NameInMap("employPositionId")]
        [Validation(Required=false)]
        public string EmployPositionId { get; set; }

        /// <summary>
        /// 职位名称
        /// </summary>
        [NameInMap("employPositionIdLabel")]
        [Validation(Required=false)]
        public string EmployPositionIdLabel { get; set; }

        /// <summary>
        /// 职级ID
        /// </summary>
        [NameInMap("employPositionRankId")]
        [Validation(Required=false)]
        public string EmployPositionRankId { get; set; }

        /// <summary>
        /// 职级名称
        /// </summary>
        [NameInMap("employPositionRankIdLabel")]
        [Validation(Required=false)]
        public string EmployPositionRankIdLabel { get; set; }

        /// <summary>
        /// 入职日期
        /// </summary>
        [NameInMap("hiredDate")]
        [Validation(Required=false)]
        public string HiredDate { get; set; }

        /// <summary>
        /// 离职日期
        /// </summary>
        [NameInMap("lastWorkDay")]
        [Validation(Required=false)]
        public string LastWorkDay { get; set; }

        /// <summary>
        /// 主动离职原因
        /// </summary>
        [NameInMap("terminationReasonVoluntary")]
        [Validation(Required=false)]
        public List<string> TerminationReasonVoluntary { get; set; }

        /// <summary>
        /// 被动离职原因
        /// </summary>
        [NameInMap("terminationReasonPassive")]
        [Validation(Required=false)]
        public List<string> TerminationReasonPassive { get; set; }

    }

}
