// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdatacenter_1_0.Models
{
    public class GetSoftwareCopyrightResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>[{ &quot;EntName:企业名称&quot;, &quot;CopyNum:登记号&quot;, &quot;TypeNum:分类号&quot;, &quot;ShortName:作品简称&quot;, &quot;CopyName:作品全称&quot;, &quot;Version:版本号&quot;, &quot;SuccessDate:创作完成日期&quot;, &quot;FirstDate:首次发表日期&quot;, &quot;ApprovalDate:登记批准日期&quot; }]</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
