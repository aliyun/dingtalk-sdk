// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkjzcrm_1_0.Models
{
    public class EditIntostockRequest : TeaModel {
        /// <summary>
        /// 编辑数据
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public EditIntostockRequestData Data { get; set; }
        public class EditIntostockRequestData : TeaModel {
            /// <summary>
            /// 入库申请人
            /// </summary>
            [NameInMap("askempid")]
            [Validation(Required=false)]
            public string Askempid { get; set; }

            /// <summary>
            /// 入库备注
            /// </summary>
            [NameInMap("auditreson")]
            [Validation(Required=false)]
            public string Auditreson { get; set; }

            /// <summary>
            /// 入库单号
            /// </summary>
            [NameInMap("billno")]
            [Validation(Required=false)]
            public string Billno { get; set; }

            /// <summary>
            /// 产品明细，json格式
            /// </summary>
            [NameInMap("child_mx")]
            [Validation(Required=false)]
            public string ChildMx { get; set; }

            /// <summary>
            /// 供应商/客户
            /// </summary>
            [NameInMap("customerid")]
            [Validation(Required=false)]
            public string Customerid { get; set; }

            /// <summary>
            /// 创建人
            /// </summary>
            [NameInMap("data_userid")]
            [Validation(Required=false)]
            public string DataUserid { get; set; }

            /// <summary>
            /// 入库经办人
            /// </summary>
            [NameInMap("empid")]
            [Validation(Required=false)]
            public string Empid { get; set; }

            /// <summary>
            /// 单据类型（入库，销售退货，生产退料，生产入库，维修退货）
            /// </summary>
            [NameInMap("inorout")]
            [Validation(Required=false)]
            public string Inorout { get; set; }

            /// <summary>
            /// 入库日期
            /// </summary>
            [NameInMap("libiodate")]
            [Validation(Required=false)]
            public string Libiodate { get; set; }

            /// <summary>
            /// 入库主题
            /// </summary>
            [NameInMap("libioname")]
            [Validation(Required=false)]
            public string Libioname { get; set; }

            /// <summary>
            /// 入库状态（未入库，已入库）
            /// </summary>
            [NameInMap("libiostate")]
            [Validation(Required=false)]
            public string Libiostate { get; set; }

            /// <summary>
            /// 对应单据
            /// </summary>
            [NameInMap("orderid")]
            [Validation(Required=false)]
            public string Orderid { get; set; }

            /// <summary>
            /// 申请备注
            /// </summary>
            [NameInMap("remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// 入库仓库
            /// </summary>
            [NameInMap("stocklibid")]
            [Validation(Required=false)]
            public string Stocklibid { get; set; }

        }

        /// <summary>
        /// 数据类型，固定填写189
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
