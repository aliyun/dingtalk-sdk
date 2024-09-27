// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalksearch_1_0.Models
{
    public class InsertSearchItemRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>四大名著</para>
        /// </summary>
        [NameInMap("footer")]
        [Validation(Required=false)]
        public string Footer { get; set; }

        [NameInMap("icon")]
        [Validation(Required=false)]
        public string Icon { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1111</para>
        /// </summary>
        [NameInMap("itemId")]
        [Validation(Required=false)]
        public string ItemId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="http://www.baidu.com">www.baidu.com</a></para>
        /// </summary>
        [NameInMap("mobileUrl")]
        [Validation(Required=false)]
        public string MobileUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="http://www.baidu.com">www.baidu.com</a></para>
        /// </summary>
        [NameInMap("pcUrl")]
        [Validation(Required=false)]
        public string PcUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>中国古代章回体长篇小说</para>
        /// </summary>
        [NameInMap("summary")]
        [Validation(Required=false)]
        public string Summary { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>红楼梦</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="http://www.baidu.com">www.baidu.com</a></para>
        /// </summary>
        [NameInMap("url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
