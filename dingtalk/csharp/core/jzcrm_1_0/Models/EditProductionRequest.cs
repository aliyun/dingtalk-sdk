// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkjzcrm_1_0.Models
{
    public class EditProductionRequest : TeaModel {
        /// <summary>
        /// 数据类型，固定填写156
        /// </summary>
        [NameInMap("datatype")]
        [Validation(Required=false)]
        public long? Datatype { get; set; }

        /// <summary>
        /// 时间戳
        /// </summary>
        [NameInMap("stamp")]
        [Validation(Required=false)]
        public long? Stamp { get; set; }

        /// <summary>
        /// 数据id，不填或者填0为新增数据
        /// </summary>
        [NameInMap("msgid")]
        [Validation(Required=false)]
        public long? Msgid { get; set; }

        /// <summary>
        /// 编辑数据
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public EditProductionRequestData Data { get; set; }
        public class EditProductionRequestData : TeaModel {
            [NameInMap("data_userid")]
            [Validation(Required=false)]
            public string DataUserid { get; set; }
            [NameInMap("sch_title")]
            [Validation(Required=false)]
            public string SchTitle { get; set; }
            [NameInMap("sch_number")]
            [Validation(Required=false)]
            public string SchNumber { get; set; }
            [NameInMap("sch_starttime")]
            [Validation(Required=false)]
            public string SchStarttime { get; set; }
            [NameInMap("sch_planendtime")]
            [Validation(Required=false)]
            public string SchPlanendtime { get; set; }
            [NameInMap("sch_customerid")]
            [Validation(Required=false)]
            public string SchCustomerid { get; set; }
            [NameInMap("sch_htid")]
            [Validation(Required=false)]
            public string SchHtid { get; set; }
            [NameInMap("sch_endtime")]
            [Validation(Required=false)]
            public string SchEndtime { get; set; }
            [NameInMap("sch_principal")]
            [Validation(Required=false)]
            public string SchPrincipal { get; set; }
            [NameInMap("sch_makeemp")]
            [Validation(Required=false)]
            public string SchMakeemp { get; set; }
            [NameInMap("sch_remark")]
            [Validation(Required=false)]
            public string SchRemark { get; set; }
            [NameInMap("sch_statesstr")]
            [Validation(Required=false)]
            public string SchStatesstr { get; set; }
            [NameInMap("sch_finished")]
            [Validation(Required=false)]
            public string SchFinished { get; set; }
        };

    }

}
