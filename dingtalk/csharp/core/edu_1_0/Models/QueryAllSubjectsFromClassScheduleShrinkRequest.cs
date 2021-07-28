// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class QueryAllSubjectsFromClassScheduleShrinkRequest : TeaModel {
        /// <summary>
        /// 班级ID。
        /// </summary>
        [NameInMap("classIds")]
        [Validation(Required=false)]
        public string ClassIdsShrink { get; set; }

        /// <summary>
        /// 操作者的userid。
        /// </summary>
        [NameInMap("opUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

        /// <summary>
        /// 学段编码：KINDERGARTEN：小学 PRIMARY_SCHOOL：小学 MODDLE_SCHOOL： 初中 HIGH_SCHOOL： 高中 UNIVERSITY：大学 NOT_SCHOOL：无学段
        /// </summary>
        [NameInMap("periodCode")]
        [Validation(Required=false)]
        public string PeriodCode { get; set; }

    }

}
