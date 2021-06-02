// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkjzcrm_1_0.models;

import com.aliyun.tea.*;

public class EditSalesRequest extends TeaModel {
    // 数据类型，固定填写158
    @NameInMap("datatype")
    public Long datatype;

    // 时间戳
    @NameInMap("stamp")
    public Long stamp;

    // 数据id，不填或者填0为新增数据
    @NameInMap("msgid")
    public Long msgid;

    // 编辑数据
    @NameInMap("data")
    public EditSalesRequestData data;

    public static EditSalesRequest build(java.util.Map<String, ?> map) throws Exception {
        EditSalesRequest self = new EditSalesRequest();
        return TeaModel.build(map, self);
    }

    public EditSalesRequest setDatatype(Long datatype) {
        this.datatype = datatype;
        return this;
    }
    public Long getDatatype() {
        return this.datatype;
    }

    public EditSalesRequest setStamp(Long stamp) {
        this.stamp = stamp;
        return this;
    }
    public Long getStamp() {
        return this.stamp;
    }

    public EditSalesRequest setMsgid(Long msgid) {
        this.msgid = msgid;
        return this;
    }
    public Long getMsgid() {
        return this.msgid;
    }

    public EditSalesRequest setData(EditSalesRequestData data) {
        this.data = data;
        return this;
    }
    public EditSalesRequestData getData() {
        return this.data;
    }

    public static class EditSalesRequestData extends TeaModel {
        // 创建人
        @NameInMap("data_userid")
        public String dataUserid;

        // 对应客户
        @NameInMap("xsh_customerid")
        public String xshCustomerid;

        // 主题
        @NameInMap("xsh_title")
        public String xshTitle;

        // 发现时间
        @NameInMap("xsh_date")
        public String xshDate;

        // 机会编号
        @NameInMap("xsh_number")
        public String xshNumber;

        // 联系人
        @NameInMap("xsh_lxrid")
        public String xshLxrid;

        // 联系方式
        @NameInMap("xsh_lianxi")
        public String xshLianxi;

        // 类型
        @NameInMap("xsh_type")
        public String xshType;

        // 来源
        @NameInMap("xsh_from")
        public String xshFrom;

        // 所有者
        @NameInMap("xsh_preside")
        public String xshPreside;

        // 提供人
        @NameInMap("xsh_provider")
        public String xshProvider;

        // 客户需求
        @NameInMap("xsh_require")
        public String xshRequire;

        // 预计签单日
        @NameInMap("xsh_expdate")
        public String xshExpdate;

        // 预期金额
        @NameInMap("xsh_expmoney")
        public String xshExpmoney;

        // 外币备注
        @NameInMap("xsh_moneynote")
        public String xshMoneynote;

        // 阶段
        @NameInMap("xsh_phase")
        public String xshPhase;

        // 可能性
        @NameInMap("xsh_knx")
        public String xshKnx;

        // 状态
        @NameInMap("xsh_state")
        public String xshState;

        // 阶段备注
        @NameInMap("xsh_phasenote")
        public String xshPhasenote;

        public static EditSalesRequestData build(java.util.Map<String, ?> map) throws Exception {
            EditSalesRequestData self = new EditSalesRequestData();
            return TeaModel.build(map, self);
        }

        public EditSalesRequestData setDataUserid(String dataUserid) {
            this.dataUserid = dataUserid;
            return this;
        }
        public String getDataUserid() {
            return this.dataUserid;
        }

        public EditSalesRequestData setXshCustomerid(String xshCustomerid) {
            this.xshCustomerid = xshCustomerid;
            return this;
        }
        public String getXshCustomerid() {
            return this.xshCustomerid;
        }

        public EditSalesRequestData setXshTitle(String xshTitle) {
            this.xshTitle = xshTitle;
            return this;
        }
        public String getXshTitle() {
            return this.xshTitle;
        }

        public EditSalesRequestData setXshDate(String xshDate) {
            this.xshDate = xshDate;
            return this;
        }
        public String getXshDate() {
            return this.xshDate;
        }

        public EditSalesRequestData setXshNumber(String xshNumber) {
            this.xshNumber = xshNumber;
            return this;
        }
        public String getXshNumber() {
            return this.xshNumber;
        }

        public EditSalesRequestData setXshLxrid(String xshLxrid) {
            this.xshLxrid = xshLxrid;
            return this;
        }
        public String getXshLxrid() {
            return this.xshLxrid;
        }

        public EditSalesRequestData setXshLianxi(String xshLianxi) {
            this.xshLianxi = xshLianxi;
            return this;
        }
        public String getXshLianxi() {
            return this.xshLianxi;
        }

        public EditSalesRequestData setXshType(String xshType) {
            this.xshType = xshType;
            return this;
        }
        public String getXshType() {
            return this.xshType;
        }

        public EditSalesRequestData setXshFrom(String xshFrom) {
            this.xshFrom = xshFrom;
            return this;
        }
        public String getXshFrom() {
            return this.xshFrom;
        }

        public EditSalesRequestData setXshPreside(String xshPreside) {
            this.xshPreside = xshPreside;
            return this;
        }
        public String getXshPreside() {
            return this.xshPreside;
        }

        public EditSalesRequestData setXshProvider(String xshProvider) {
            this.xshProvider = xshProvider;
            return this;
        }
        public String getXshProvider() {
            return this.xshProvider;
        }

        public EditSalesRequestData setXshRequire(String xshRequire) {
            this.xshRequire = xshRequire;
            return this;
        }
        public String getXshRequire() {
            return this.xshRequire;
        }

        public EditSalesRequestData setXshExpdate(String xshExpdate) {
            this.xshExpdate = xshExpdate;
            return this;
        }
        public String getXshExpdate() {
            return this.xshExpdate;
        }

        public EditSalesRequestData setXshExpmoney(String xshExpmoney) {
            this.xshExpmoney = xshExpmoney;
            return this;
        }
        public String getXshExpmoney() {
            return this.xshExpmoney;
        }

        public EditSalesRequestData setXshMoneynote(String xshMoneynote) {
            this.xshMoneynote = xshMoneynote;
            return this;
        }
        public String getXshMoneynote() {
            return this.xshMoneynote;
        }

        public EditSalesRequestData setXshPhase(String xshPhase) {
            this.xshPhase = xshPhase;
            return this;
        }
        public String getXshPhase() {
            return this.xshPhase;
        }

        public EditSalesRequestData setXshKnx(String xshKnx) {
            this.xshKnx = xshKnx;
            return this;
        }
        public String getXshKnx() {
            return this.xshKnx;
        }

        public EditSalesRequestData setXshState(String xshState) {
            this.xshState = xshState;
            return this;
        }
        public String getXshState() {
            return this.xshState;
        }

        public EditSalesRequestData setXshPhasenote(String xshPhasenote) {
            this.xshPhasenote = xshPhasenote;
            return this;
        }
        public String getXshPhasenote() {
            return this.xshPhasenote;
        }

    }

}
