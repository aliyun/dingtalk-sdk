// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkjzcrm_1_0.Models
{
    public class EditProductionRequest : TeaModel {
        /// <summary>
        /// 编辑数据
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public EditProductionRequestData Data { get; set; }
        public class EditProductionRequestData : TeaModel {
            /// <summary>
            /// 创建人
            /// </summary>
            [NameInMap("data_userid")]
            [Validation(Required=false)]
            public string DataUserid { get; set; }

            /// <summary>
            /// 对应客户
            /// </summary>
            [NameInMap("sch_customerid")]
            [Validation(Required=false)]
            public string SchCustomerid { get; set; }

            /// <summary>
            /// 完成日期
            /// </summary>
            [NameInMap("sch_endtime")]
            [Validation(Required=false)]
            public string SchEndtime { get; set; }

            /// <summary>
            /// 状态（未生产，生产中，生产中止，生产完成）
            /// </summary>
            [NameInMap("sch_finished")]
            [Validation(Required=false)]
            public string SchFinished { get; set; }

            /// <summary>
            /// 订单
            /// </summary>
            [NameInMap("sch_htid")]
            [Validation(Required=false)]
            public string SchHtid { get; set; }

            /// <summary>
            /// 生产人员
            /// </summary>
            [NameInMap("sch_makeemp")]
            [Validation(Required=false)]
            public string SchMakeemp { get; set; }

            /// <summary>
            /// 单号
            /// </summary>
            [NameInMap("sch_number")]
            [Validation(Required=false)]
            public string SchNumber { get; set; }

            /// <summary>
            /// 计划完成
            /// </summary>
            [NameInMap("sch_planendtime")]
            [Validation(Required=false)]
            public string SchPlanendtime { get; set; }

            /// <summary>
            /// 负责人
            /// </summary>
            [NameInMap("sch_principal")]
            [Validation(Required=false)]
            public string SchPrincipal { get; set; }

            /// <summary>
            /// 备注
            /// </summary>
            [NameInMap("sch_remark")]
            [Validation(Required=false)]
            public string SchRemark { get; set; }

            /// <summary>
            /// 开始日期
            /// </summary>
            [NameInMap("sch_starttime")]
            [Validation(Required=false)]
            public string SchStarttime { get; set; }

            /// <summary>
            /// 阶段（计划，审核，领料，生产，验收，入库/退料，结单，取消）
            /// </summary>
            [NameInMap("sch_statesstr")]
            [Validation(Required=false)]
            public string SchStatesstr { get; set; }

            /// <summary>
            /// 主题
            /// </summary>
            [NameInMap("sch_title")]
            [Validation(Required=false)]
            public string SchTitle { get; set; }

        }

        /// <summary>
        /// 数据类型，固定填写156
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
