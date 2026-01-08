// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class ProcessHhOemUpdateRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("bindOemApp")]
        [Validation(Required=false)]
        public bool? BindOemApp { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("corpIdList")]
        [Validation(Required=false)]
        public List<string> CorpIdList { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("useOemApp")]
        [Validation(Required=false)]
        public bool? UseOemApp { get; set; }

    }

}
