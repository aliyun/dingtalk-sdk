// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class AddOrgTextEmotionRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>@123xxx</para>
        /// </summary>
        [NameInMap("backgroundMediaId")]
        [Validation(Required=false)]
        public string BackgroundMediaId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>@345xxx</para>
        /// </summary>
        [NameInMap("backgroundMediaIdForPanel")]
        [Validation(Required=false)]
        public string BackgroundMediaIdForPanel { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("deptId")]
        [Validation(Required=false)]
        public long? DeptId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>企业表情1</para>
        /// </summary>
        [NameInMap("emotionName")]
        [Validation(Required=false)]
        public string EmotionName { get; set; }

    }

}
