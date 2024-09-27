// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkchengfeng_1_0.Models
{
    public class OpenProgressDTO : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>48383883</para>
        /// </summary>
        [NameInMap("created")]
        [Validation(Required=false)]
        public long? Created { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("creator")]
        [Validation(Required=false)]
        public OpenUserDTO Creator { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>我的目标</para>
        /// </summary>
        [NameInMap("htmlContent")]
        [Validation(Required=false)]
        public string HtmlContent { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("modifier")]
        [Validation(Required=false)]
        public OpenUserDTO Modifier { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>48383883</para>
        /// </summary>
        [NameInMap("updated")]
        [Validation(Required=false)]
        public long? Updated { get; set; }

    }

}
