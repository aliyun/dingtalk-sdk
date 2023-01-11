// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkjzcrm_1_0.models;

import com.aliyun.tea.*;

public class EditSalesRequest extends TeaModel {
    /**
     * <p>编辑数据</p>
     */
    @NameInMap("data")
    public EditSalesRequestData data;

    /**
     * <p>数据类型，固定填写158</p>
     */
    @NameInMap("datatype")
    public Long datatype;

    /**
     * <p>数据id，不填或者填0为新增数据</p>
     */
    @NameInMap("msgid")
    public Long msgid;

    /**
     * <p>时间戳</p>
     */
    @NameInMap("stamp")
    public Long stamp;

    public static EditSalesRequest build(java.util.Map<String, ?> map) throws Exception {
        EditSalesRequest self = new EditSalesRequest();
        return TeaModel.build(map, self);
    }

    public EditSalesRequest setData(EditSalesRequestData data) {
        this.data = data;
        return this;
    }
    public EditSalesRequestData getData() {
        return this.data;
    }

    public EditSalesRequest setDatatype(Long datatype) {
        this.datatype = datatype;
        return this;
    }
    public Long getDatatype() {
        return this.datatype;
    }

    public EditSalesRequest setMsgid(Long msgid) {
        this.msgid = msgid;
        return this;
    }
    public Long getMsgid() {
        return this.msgid;
    }

    public EditSalesRequest setStamp(Long stamp) {
        this.stamp = stamp;
        return this;
    }
    public Long getStamp() {
        return this.stamp;
    }

    public static class EditSalesRequestData extends TeaModel {
        /**
         * <p>创建人</p>
         */
        @NameInMap("data_userid")
        public String dataUserid;

        /**
         * <p>对应客户</p>
         */
        @NameInMap("xsh_customerid")
        public String xshCustomerid;

        /**
         * <p>发现时间</p>
         */
        @NameInMap("xsh_date")
        public String xshDate;

        /**
         * <p>预计签单日</p>
         */
        @NameInMap("xsh_expdate")
        public String xshExpdate;

        /**
         * <p>预期金额</p>
         */
        @NameInMap("xsh_expmoney")
        public String xshExpmoney;

        /**
         * <p>来源</p>
         */
        @NameInMap("xsh_from")
        public String xshFrom;

        /**
         * <p>可能性</p>
         */
        @NameInMap("xsh_knx")
        public String xshKnx;

        /**
         * <p>联系方式</p>
         */
        @NameInMap("xsh_lianxi")
        public String xshLianxi;

        /**
         * <p>联系人</p>
         */
        @NameInMap("xsh_lxrid")
        public String xshLxrid;

        /**
         * <p>外币备注</p>
         */
        @NameInMap("xsh_moneynote")
        public String xshMoneynote;

        /**
         * <p>机会编号</p>
         */
        @NameInMap("xsh_number")
        public String xshNumber;

        /**
         * <p>阶段</p>
         */
        @NameInMap("xsh_phase")
        public String xshPhase;

        /**
         * <p>阶段备注</p>
         */
        @NameInMap("xsh_phasenote")
        public String xshPhasenote;

        /**
         * <p>所有者</p>
         */
        @NameInMap("xsh_preside")
        public String xshPreside;

        /**
         * <p>提供人</p>
         */
        @NameInMap("xsh_provider")
        public String xshProvider;

        /**
         * <p>客户需求</p>
         */
        @NameInMap("xsh_require")
        public String xshRequire;

        /**
         * <p>状态</p>
         */
        @NameInMap("xsh_state")
        public String xshState;

        /**
         * <p>主题</p>
         */
        @NameInMap("xsh_title")
        public String xshTitle;

        /**
         * <p>类型</p>
         */
        @NameInMap("xsh_type")
        public String xshType;

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

        public EditSalesRequestData setXshDate(String xshDate) {
            this.xshDate = xshDate;
            return this;
        }
        public String getXshDate() {
            return this.xshDate;
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

        public EditSalesRequestData setXshFrom(String xshFrom) {
            this.xshFrom = xshFrom;
            return this;
        }
        public String getXshFrom() {
            return this.xshFrom;
        }

        public EditSalesRequestData setXshKnx(String xshKnx) {
            this.xshKnx = xshKnx;
            return this;
        }
        public String getXshKnx() {
            return this.xshKnx;
        }

        public EditSalesRequestData setXshLianxi(String xshLianxi) {
            this.xshLianxi = xshLianxi;
            return this;
        }
        public String getXshLianxi() {
            return this.xshLianxi;
        }

        public EditSalesRequestData setXshLxrid(String xshLxrid) {
            this.xshLxrid = xshLxrid;
            return this;
        }
        public String getXshLxrid() {
            return this.xshLxrid;
        }

        public EditSalesRequestData setXshMoneynote(String xshMoneynote) {
            this.xshMoneynote = xshMoneynote;
            return this;
        }
        public String getXshMoneynote() {
            return this.xshMoneynote;
        }

        public EditSalesRequestData setXshNumber(String xshNumber) {
            this.xshNumber = xshNumber;
            return this;
        }
        public String getXshNumber() {
            return this.xshNumber;
        }

        public EditSalesRequestData setXshPhase(String xshPhase) {
            this.xshPhase = xshPhase;
            return this;
        }
        public String getXshPhase() {
            return this.xshPhase;
        }

        public EditSalesRequestData setXshPhasenote(String xshPhasenote) {
            this.xshPhasenote = xshPhasenote;
            return this;
        }
        public String getXshPhasenote() {
            return this.xshPhasenote;
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

        public EditSalesRequestData setXshState(String xshState) {
            this.xshState = xshState;
            return this;
        }
        public String getXshState() {
            return this.xshState;
        }

        public EditSalesRequestData setXshTitle(String xshTitle) {
            this.xshTitle = xshTitle;
            return this;
        }
        public String getXshTitle() {
            return this.xshTitle;
        }

        public EditSalesRequestData setXshType(String xshType) {
            this.xshType = xshType;
            return this;
        }
        public String getXshType() {
            return this.xshType;
        }

    }

}
