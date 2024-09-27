// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkbench_1_0.Models
{
    public class ModifyWorkbenchBadgeRequest : TeaModel {
        /// <summary>
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("bizIdList")]
        [Validation(Required=false)]
        public List<string> BizIdList { get; set; }

        [NameInMap("isAdded")]
        [Validation(Required=false)]
        public bool? IsAdded { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>full</para>
        /// </summary>
        [NameInMap("modifyMode")]
        [Validation(Required=false)]
        public string ModifyMode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5000000004278081/test</para>
        /// </summary>
        [NameInMap("redDotRelationId")]
        [Validation(Required=false)]
        public string RedDotRelationId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>workbench_component</para>
        /// </summary>
        [NameInMap("redDotType")]
        [Validation(Required=false)]
        public string RedDotType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0123465</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
