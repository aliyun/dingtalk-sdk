// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkrobot_1_0.Models
{
    public class RobotMessageFileDownloadRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mIofN681YE3f/+m+NntqpZSvSH2iMD6xP7Ow/ezdb1Wgn38tqVwL+zoRgzXipAMzmV5uhVKUlBdjKugAIvsm+TrvaPI0JYCMjvFMAlXvMWnMJsi2nZ9a0+N2c9CoV90hiB/B+fEThASPz+jmIa4J6x4WTsmmU3E/AopGsSGugE+hkHBcu52o76Yd2SCpPNUqenvdySSqjowEt1+Ddz55/9Qj8Y8ZhTryqsb7tYwzLFB+F3lsWCotXBOQvEgy3e/bEQtOyV6YrP3KG6YNSb3Q==</para>
        /// </summary>
        [NameInMap("downloadCode")]
        [Validation(Required=false)]
        public string DownloadCode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dingue4kfzdxbyn0pjqd</para>
        /// </summary>
        [NameInMap("robotCode")]
        [Validation(Required=false)]
        public string RobotCode { get; set; }

    }

}
