// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkagoal_1_0.Models
{
    public class OpenAgoalLatestProgressDTO : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1716952481672</para>
        /// </summary>
        [NameInMap("created")]
        [Validation(Required=false)]
        public long? Created { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("creator")]
        [Validation(Required=false)]
        public OpenAgoalUserDTO Creator { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <article class=\"4ever-article\"><p style=\"text-align:left;text-indent:0;margin-left:0;margin-top:0;margin-bottom:0\"><span>xxx</span></para></article>
        /// </summary>
        [NameInMap("htmldescription")]
        [Validation(Required=false)]
        public string Htmldescription { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6444f5e9a4261c6e699dxxxx</para>
        /// </summary>
        [NameInMap("progressId")]
        [Validation(Required=false)]
        public string ProgressId { get; set; }

    }

}
