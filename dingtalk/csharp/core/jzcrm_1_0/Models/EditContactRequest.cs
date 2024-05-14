// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkjzcrm_1_0.Models
{
    public class EditContactRequest : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public EditContactRequestData Data { get; set; }
        public class EditContactRequestData : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("data_userid")]
            [Validation(Required=false)]
            public string DataUserid { get; set; }

            [NameInMap("lxr_address")]
            [Validation(Required=false)]
            public string LxrAddress { get; set; }

            [NameInMap("lxr_birthday")]
            [Validation(Required=false)]
            public string LxrBirthday { get; set; }

            [NameInMap("lxr_chengwei")]
            [Validation(Required=false)]
            public string LxrChengwei { get; set; }

            [NameInMap("lxr_ctnumber")]
            [Validation(Required=false)]
            public string LxrCtnumber { get; set; }

            [NameInMap("lxr_cttype")]
            [Validation(Required=false)]
            public string LxrCttype { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("lxr_customerid")]
            [Validation(Required=false)]
            public string LxrCustomerid { get; set; }

            [NameInMap("lxr_department")]
            [Validation(Required=false)]
            public string LxrDepartment { get; set; }

            [NameInMap("lxr_dingtalk")]
            [Validation(Required=false)]
            public string LxrDingtalk { get; set; }

            [NameInMap("lxr_email")]
            [Validation(Required=false)]
            public string LxrEmail { get; set; }

            [NameInMap("lxr_fax")]
            [Validation(Required=false)]
            public string LxrFax { get; set; }

            [NameInMap("lxr_group")]
            [Validation(Required=false)]
            public string LxrGroup { get; set; }

            [NameInMap("lxr_handset")]
            [Validation(Required=false)]
            public string LxrHandset { get; set; }

            [NameInMap("lxr_headship")]
            [Validation(Required=false)]
            public string LxrHeadship { get; set; }

            [NameInMap("lxr_like")]
            [Validation(Required=false)]
            public string LxrLike { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("lxr_name")]
            [Validation(Required=false)]
            public string LxrName { get; set; }

            [NameInMap("lxr_photo")]
            [Validation(Required=false)]
            public string LxrPhoto { get; set; }

            [NameInMap("lxr_preside")]
            [Validation(Required=false)]
            public string LxrPreside { get; set; }

            [NameInMap("lxr_pst")]
            [Validation(Required=false)]
            public string LxrPst { get; set; }

            [NameInMap("lxr_qq")]
            [Validation(Required=false)]
            public string LxrQq { get; set; }

            [NameInMap("lxr_remark")]
            [Validation(Required=false)]
            public string LxrRemark { get; set; }

            [NameInMap("lxr_sex")]
            [Validation(Required=false)]
            public string LxrSex { get; set; }

            [NameInMap("lxr_skype")]
            [Validation(Required=false)]
            public string LxrSkype { get; set; }

            [NameInMap("lxr_tel")]
            [Validation(Required=false)]
            public string LxrTel { get; set; }

            [NameInMap("lxr_type")]
            [Validation(Required=false)]
            public string LxrType { get; set; }

            [NameInMap("lxr_wangwang")]
            [Validation(Required=false)]
            public string LxrWangwang { get; set; }

            [NameInMap("lxr_weixin")]
            [Validation(Required=false)]
            public string LxrWeixin { get; set; }

            [NameInMap("lxr_worktel")]
            [Validation(Required=false)]
            public string LxrWorktel { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("datatype")]
        [Validation(Required=false)]
        public long? Datatype { get; set; }

        [NameInMap("msgid")]
        [Validation(Required=false)]
        public long? Msgid { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("stamp")]
        [Validation(Required=false)]
        public long? Stamp { get; set; }

    }

}
