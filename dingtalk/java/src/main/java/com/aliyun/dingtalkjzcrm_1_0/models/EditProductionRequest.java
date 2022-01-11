// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkjzcrm_1_0.models;

import com.aliyun.tea.*;

public class EditProductionRequest extends TeaModel {
    // 编辑数据
    @NameInMap("data")
    public EditProductionRequestData data;

    // 数据类型，固定填写156
    @NameInMap("datatype")
    public Long datatype;

    // 数据id，不填或者填0为新增数据
    @NameInMap("msgid")
    public Long msgid;

    // 时间戳
    @NameInMap("stamp")
    public Long stamp;

    public static EditProductionRequest build(java.util.Map<String, ?> map) throws Exception {
        EditProductionRequest self = new EditProductionRequest();
        return TeaModel.build(map, self);
    }

    public EditProductionRequest setData(EditProductionRequestData data) {
        this.data = data;
        return this;
    }
    public EditProductionRequestData getData() {
        return this.data;
    }

    public EditProductionRequest setDatatype(Long datatype) {
        this.datatype = datatype;
        return this;
    }
    public Long getDatatype() {
        return this.datatype;
    }

    public EditProductionRequest setMsgid(Long msgid) {
        this.msgid = msgid;
        return this;
    }
    public Long getMsgid() {
        return this.msgid;
    }

    public EditProductionRequest setStamp(Long stamp) {
        this.stamp = stamp;
        return this;
    }
    public Long getStamp() {
        return this.stamp;
    }

    public static class EditProductionRequestData extends TeaModel {
        // 创建人
        @NameInMap("data_userid")
        public String dataUserid;

        // 对应客户
        @NameInMap("sch_customerid")
        public String schCustomerid;

        // 完成日期
        @NameInMap("sch_endtime")
        public String schEndtime;

        // 状态（未生产，生产中，生产中止，生产完成）
        @NameInMap("sch_finished")
        public String schFinished;

        // 订单
        @NameInMap("sch_htid")
        public String schHtid;

        // 生产人员
        @NameInMap("sch_makeemp")
        public String schMakeemp;

        // 单号
        @NameInMap("sch_number")
        public String schNumber;

        // 计划完成
        @NameInMap("sch_planendtime")
        public String schPlanendtime;

        // 负责人
        @NameInMap("sch_principal")
        public String schPrincipal;

        // 备注
        @NameInMap("sch_remark")
        public String schRemark;

        // 开始日期
        @NameInMap("sch_starttime")
        public String schStarttime;

        // 阶段（计划，审核，领料，生产，验收，入库/退料，结单，取消）
        @NameInMap("sch_statesstr")
        public String schStatesstr;

        // 主题
        @NameInMap("sch_title")
        public String schTitle;

        public static EditProductionRequestData build(java.util.Map<String, ?> map) throws Exception {
            EditProductionRequestData self = new EditProductionRequestData();
            return TeaModel.build(map, self);
        }

        public EditProductionRequestData setDataUserid(String dataUserid) {
            this.dataUserid = dataUserid;
            return this;
        }
        public String getDataUserid() {
            return this.dataUserid;
        }

        public EditProductionRequestData setSchCustomerid(String schCustomerid) {
            this.schCustomerid = schCustomerid;
            return this;
        }
        public String getSchCustomerid() {
            return this.schCustomerid;
        }

        public EditProductionRequestData setSchEndtime(String schEndtime) {
            this.schEndtime = schEndtime;
            return this;
        }
        public String getSchEndtime() {
            return this.schEndtime;
        }

        public EditProductionRequestData setSchFinished(String schFinished) {
            this.schFinished = schFinished;
            return this;
        }
        public String getSchFinished() {
            return this.schFinished;
        }

        public EditProductionRequestData setSchHtid(String schHtid) {
            this.schHtid = schHtid;
            return this;
        }
        public String getSchHtid() {
            return this.schHtid;
        }

        public EditProductionRequestData setSchMakeemp(String schMakeemp) {
            this.schMakeemp = schMakeemp;
            return this;
        }
        public String getSchMakeemp() {
            return this.schMakeemp;
        }

        public EditProductionRequestData setSchNumber(String schNumber) {
            this.schNumber = schNumber;
            return this;
        }
        public String getSchNumber() {
            return this.schNumber;
        }

        public EditProductionRequestData setSchPlanendtime(String schPlanendtime) {
            this.schPlanendtime = schPlanendtime;
            return this;
        }
        public String getSchPlanendtime() {
            return this.schPlanendtime;
        }

        public EditProductionRequestData setSchPrincipal(String schPrincipal) {
            this.schPrincipal = schPrincipal;
            return this;
        }
        public String getSchPrincipal() {
            return this.schPrincipal;
        }

        public EditProductionRequestData setSchRemark(String schRemark) {
            this.schRemark = schRemark;
            return this;
        }
        public String getSchRemark() {
            return this.schRemark;
        }

        public EditProductionRequestData setSchStarttime(String schStarttime) {
            this.schStarttime = schStarttime;
            return this;
        }
        public String getSchStarttime() {
            return this.schStarttime;
        }

        public EditProductionRequestData setSchStatesstr(String schStatesstr) {
            this.schStatesstr = schStatesstr;
            return this;
        }
        public String getSchStatesstr() {
            return this.schStatesstr;
        }

        public EditProductionRequestData setSchTitle(String schTitle) {
            this.schTitle = schTitle;
            return this;
        }
        public String getSchTitle() {
            return this.schTitle;
        }

    }

}
