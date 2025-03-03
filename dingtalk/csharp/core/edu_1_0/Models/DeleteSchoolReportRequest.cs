// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class DeleteSchoolReportRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("bizCode")]
        [Validation(Required=false)]
        public string BizCode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("schoolReportId")]
        [Validation(Required=false)]
        public long? SchoolReportId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("teacherId")]
        [Validation(Required=false)]
        public string TeacherId { get; set; }

    }

}
