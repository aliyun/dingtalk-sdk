// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class ECertQueryResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>3300111192912113</para>
        /// </summary>
        [NameInMap("certNO")]
        [Validation(Required=false)]
        public string CertNO { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1123124124124</para>
        /// </summary>
        [NameInMap("employJobId")]
        [Validation(Required=false)]
        public string EmployJobId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>职务</para>
        /// </summary>
        [NameInMap("employJobIdLabel")]
        [Validation(Required=false)]
        public string EmployJobIdLabel { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1231231232313123</para>
        /// </summary>
        [NameInMap("employPositionId")]
        [Validation(Required=false)]
        public string EmployPositionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>职位</para>
        /// </summary>
        [NameInMap("employPositionIdLabel")]
        [Validation(Required=false)]
        public string EmployPositionIdLabel { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>498192313</para>
        /// </summary>
        [NameInMap("employPositionRankId")]
        [Validation(Required=false)]
        public string EmployPositionRankId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>职级</para>
        /// </summary>
        [NameInMap("employPositionRankIdLabel")]
        [Validation(Required=false)]
        public string EmployPositionRankIdLabel { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2020-03-14</para>
        /// </summary>
        [NameInMap("hiredDate")]
        [Validation(Required=false)]
        public string HiredDate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-03-14</para>
        /// </summary>
        [NameInMap("lastWorkDay")]
        [Validation(Required=false)]
        public string LastWorkDay { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("mainDeptId")]
        [Validation(Required=false)]
        public long? MainDeptId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>测试部门</para>
        /// </summary>
        [NameInMap("mainDeptName")]
        [Validation(Required=false)]
        public string MainDeptName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>李四</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>张三</para>
        /// </summary>
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
