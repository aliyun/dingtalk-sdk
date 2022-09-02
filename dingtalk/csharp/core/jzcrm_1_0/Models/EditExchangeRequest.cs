// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkjzcrm_1_0.Models
{
    public class EditExchangeRequest : TeaModel {
        /// <summary>
        /// 编辑数据
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public EditExchangeRequestData Data { get; set; }
        public class EditExchangeRequestData : TeaModel {
            /// <summary>
            /// 产品明细，json格式
            /// </summary>
            [NameInMap("child_mx")]
            [Validation(Required=false)]
            public string ChildMx { get; set; }

            /// <summary>
            /// 创建人
            /// </summary>
            [NameInMap("data_userid")]
            [Validation(Required=false)]
            public string DataUserid { get; set; }

            /// <summary>
            /// 对应客户
            /// </summary>
            [NameInMap("hh_customerid")]
            [Validation(Required=false)]
            public string HhCustomerid { get; set; }

            /// <summary>
            /// 换货日期
            /// </summary>
            [NameInMap("hh_date")]
            [Validation(Required=false)]
            public string HhDate { get; set; }

            /// <summary>
            /// 换入操作员
            /// </summary>
            [NameInMap("hh_inempid")]
            [Validation(Required=false)]
            public string HhInempid { get; set; }

            /// <summary>
            /// 换入仓库
            /// </summary>
            [NameInMap("hh_inlibid")]
            [Validation(Required=false)]
            public string HhInlibid { get; set; }

            /// <summary>
            /// 换入时间
            /// </summary>
            [NameInMap("hh_intime")]
            [Validation(Required=false)]
            public string HhIntime { get; set; }

            /// <summary>
            /// 换货单号
            /// </summary>
            [NameInMap("hh_number")]
            [Validation(Required=false)]
            public string HhNumber { get; set; }

            /// <summary>
            /// 合同/订单
            /// </summary>
            [NameInMap("hh_orderid")]
            [Validation(Required=false)]
            public string HhOrderid { get; set; }

            /// <summary>
            /// 换出操作员
            /// </summary>
            [NameInMap("hh_outempid")]
            [Validation(Required=false)]
            public string HhOutempid { get; set; }

            /// <summary>
            /// 换出仓库
            /// </summary>
            [NameInMap("hh_outlibid")]
            [Validation(Required=false)]
            public string HhOutlibid { get; set; }

            /// <summary>
            /// 换出时间
            /// </summary>
            [NameInMap("hh_outtime")]
            [Validation(Required=false)]
            public string HhOuttime { get; set; }

            /// <summary>
            /// 备注
            /// </summary>
            [NameInMap("hh_remark")]
            [Validation(Required=false)]
            public string HhRemark { get; set; }

            /// <summary>
            /// 状态（未执行，已入待出，已出待入，结束）
            /// </summary>
            [NameInMap("hh_state")]
            [Validation(Required=false)]
            public string HhState { get; set; }

            /// <summary>
            /// 主题
            /// </summary>
            [NameInMap("hh_title")]
            [Validation(Required=false)]
            public string HhTitle { get; set; }

            /// <summary>
            /// 分类
            /// </summary>
            [NameInMap("hh_type")]
            [Validation(Required=false)]
            public string HhType { get; set; }

        }

        /// <summary>
        /// 数据类型，固定填写228
        /// </summary>
        [NameInMap("datatype")]
        [Validation(Required=false)]
        public long? Datatype { get; set; }

        /// <summary>
        /// 数据id，不填或者填0为新增数据
        /// </summary>
        [NameInMap("msgid")]
        [Validation(Required=false)]
        public long? Msgid { get; set; }

        /// <summary>
        /// 时间戳
        /// </summary>
        [NameInMap("stamp")]
        [Validation(Required=false)]
        public long? Stamp { get; set; }

    }

}
