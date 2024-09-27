// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkrooms_1_0.Models
{
    public class CreateDeviceCustomTemplateRequest : TeaModel {
        [NameInMap("bgImgList")]
        [Validation(Required=false)]
        public List<string> BgImgList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("bgType")]
        [Validation(Required=false)]
        public int? BgType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://img.alicdn.com/imgextra/i2/O1CN01GWWCCR1y2D9D9EHej_!!6000000006520-2-tps-1920-470.png">https://img.alicdn.com/imgextra/i2/O1CN01GWWCCR1y2D9D9EHej_!!6000000006520-2-tps-1920-470.png</a></para>
        /// </summary>
        [NameInMap("bgUrl")]
        [Validation(Required=false)]
        public string BgUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>测试文本</para>
        /// </summary>
        [NameInMap("customDoc")]
        [Validation(Required=false)]
        public string CustomDoc { get; set; }

        [NameInMap("desensitizeUserName")]
        [Validation(Required=false)]
        public bool? DesensitizeUserName { get; set; }

        [NameInMap("deviceUnionIds")]
        [Validation(Required=false)]
        public List<string> DeviceUnionIds { get; set; }

        [NameInMap("groupIds")]
        [Validation(Required=false)]
        public List<long?> GroupIds { get; set; }

        [NameInMap("hideServerCodeWhenProjecting")]
        [Validation(Required=false)]
        public bool? HideServerCodeWhenProjecting { get; set; }

        [NameInMap("instruction")]
        [Validation(Required=false)]
        public bool? Instruction { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("isPicTop")]
        [Validation(Required=false)]
        public int? IsPicTop { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>logo</para>
        /// </summary>
        [NameInMap("logo")]
        [Validation(Required=false)]
        public string Logo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>测试企业</para>
        /// </summary>
        [NameInMap("orgName")]
        [Validation(Required=false)]
        public string OrgName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("picturePlayInterval")]
        [Validation(Required=false)]
        public int? PicturePlayInterval { get; set; }

        [NameInMap("roomIds")]
        [Validation(Required=false)]
        public List<string> RoomIds { get; set; }

        [NameInMap("showCalendarCard")]
        [Validation(Required=false)]
        public bool? ShowCalendarCard { get; set; }

        [NameInMap("showCalendarTitle")]
        [Validation(Required=false)]
        public bool? ShowCalendarTitle { get; set; }

        [NameInMap("showFunctionCard")]
        [Validation(Required=false)]
        public bool? ShowFunctionCard { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试模板</para>
        /// </summary>
        [NameInMap("templateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

    }

}
