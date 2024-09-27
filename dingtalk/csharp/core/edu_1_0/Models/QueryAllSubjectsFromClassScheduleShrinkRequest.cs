// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class QueryAllSubjectsFromClassScheduleShrinkRequest : TeaModel {
        [NameInMap("classIds")]
        [Validation(Required=false)]
        public string ClassIdsShrink { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>34524523543</para>
        /// </summary>
        [NameInMap("opUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>KINDERGARTEN</para>
        /// </summary>
        [NameInMap("periodCode")]
        [Validation(Required=false)]
        public string PeriodCode { get; set; }

    }

}
