// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class CreateEduAssetSpaceRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>目前仅支持soke</para>
        /// </summary>
        [NameInMap("bizCode")]
        [Validation(Required=false)]
        public string BizCode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>存放语文教研文件</para>
        /// </summary>
        [NameInMap("spaceDesc")]
        [Validation(Required=false)]
        public string SpaceDesc { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://gw.alicdn.com/imgextra/i4/O1CN01QGjRTl27z8YPPEQdr_!!6000000007867-2-tps-99-78.png">https://gw.alicdn.com/imgextra/i4/O1CN01QGjRTl27z8YPPEQdr_!!6000000007867-2-tps-99-78.png</a></para>
        /// </summary>
        [NameInMap("spaceIcon")]
        [Validation(Required=false)]
        public string SpaceIcon { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>语文教研组空间</para>
        /// </summary>
        [NameInMap("spaceName")]
        [Validation(Required=false)]
        public string SpaceName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aa12324</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
