// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkbench_1_0.Models
{
    public class ListWorkBenchGroupRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>corpId</para>
        /// </summary>
        [NameInMap("ecologicalCorpId")]
        [Validation(Required=false)]
        public string EcologicalCorpId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>首页 = WORK_HOME 全部页 = WORK_ALL_APP</para>
        /// </summary>
        [NameInMap("groupType")]
        [Validation(Required=false)]
        public string GroupType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("opUnionId")]
        [Validation(Required=false)]
        public string OpUnionId { get; set; }

    }

}
