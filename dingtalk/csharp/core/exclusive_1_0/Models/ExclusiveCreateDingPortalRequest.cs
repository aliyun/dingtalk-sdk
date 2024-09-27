// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class ExclusiveCreateDingPortalRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>XX工作台</para>
        /// </summary>
        [NameInMap("dingPortalName")]
        [Validation(Required=false)]
        public string DingPortalName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dingxxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("targetCorpId")]
        [Validation(Required=false)]
        public string TargetCorpId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TPL_APP-C97B75277B144ED7AEFE7XXXXXXXX6BA</para>
        /// </summary>
        [NameInMap("templateAppUuid")]
        [Validation(Required=false)]
        public string TemplateAppUuid { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dingxxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("templateCorpId")]
        [Validation(Required=false)]
        public string TemplateCorpId { get; set; }

    }

}
