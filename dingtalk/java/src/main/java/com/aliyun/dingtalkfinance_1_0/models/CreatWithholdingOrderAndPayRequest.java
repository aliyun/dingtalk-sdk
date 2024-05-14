// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class CreatWithholdingOrderAndPayRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("amount")
    public String amount;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("instId")
    public String instId;

    @NameInMap("otherPayChannelDetailInfoList")
    public java.util.List<CreatWithholdingOrderAndPayRequestOtherPayChannelDetailInfoList> otherPayChannelDetailInfoList;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("outTradeNo")
    public String outTradeNo;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("payChannel")
    public String payChannel;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("payerUserId")
    public String payerUserId;

    @NameInMap("remark")
    public String remark;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("subInstId")
    public String subInstId;

    @NameInMap("timeOutExpress")
    public String timeOutExpress;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("title")
    public String title;

    public static CreatWithholdingOrderAndPayRequest build(java.util.Map<String, ?> map) throws Exception {
        CreatWithholdingOrderAndPayRequest self = new CreatWithholdingOrderAndPayRequest();
        return TeaModel.build(map, self);
    }

    public CreatWithholdingOrderAndPayRequest setAmount(String amount) {
        this.amount = amount;
        return this;
    }
    public String getAmount() {
        return this.amount;
    }

    public CreatWithholdingOrderAndPayRequest setInstId(String instId) {
        this.instId = instId;
        return this;
    }
    public String getInstId() {
        return this.instId;
    }

    public CreatWithholdingOrderAndPayRequest setOtherPayChannelDetailInfoList(java.util.List<CreatWithholdingOrderAndPayRequestOtherPayChannelDetailInfoList> otherPayChannelDetailInfoList) {
        this.otherPayChannelDetailInfoList = otherPayChannelDetailInfoList;
        return this;
    }
    public java.util.List<CreatWithholdingOrderAndPayRequestOtherPayChannelDetailInfoList> getOtherPayChannelDetailInfoList() {
        return this.otherPayChannelDetailInfoList;
    }

    public CreatWithholdingOrderAndPayRequest setOutTradeNo(String outTradeNo) {
        this.outTradeNo = outTradeNo;
        return this;
    }
    public String getOutTradeNo() {
        return this.outTradeNo;
    }

    public CreatWithholdingOrderAndPayRequest setPayChannel(String payChannel) {
        this.payChannel = payChannel;
        return this;
    }
    public String getPayChannel() {
        return this.payChannel;
    }

    public CreatWithholdingOrderAndPayRequest setPayerUserId(String payerUserId) {
        this.payerUserId = payerUserId;
        return this;
    }
    public String getPayerUserId() {
        return this.payerUserId;
    }

    public CreatWithholdingOrderAndPayRequest setRemark(String remark) {
        this.remark = remark;
        return this;
    }
    public String getRemark() {
        return this.remark;
    }

    public CreatWithholdingOrderAndPayRequest setSubInstId(String subInstId) {
        this.subInstId = subInstId;
        return this;
    }
    public String getSubInstId() {
        return this.subInstId;
    }

    public CreatWithholdingOrderAndPayRequest setTimeOutExpress(String timeOutExpress) {
        this.timeOutExpress = timeOutExpress;
        return this;
    }
    public String getTimeOutExpress() {
        return this.timeOutExpress;
    }

    public CreatWithholdingOrderAndPayRequest setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public static class CreatWithholdingOrderAndPayRequestOtherPayChannelDetailInfoListFundToolDetailInfoList extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("amount")
        public String amount;

        @NameInMap("extInfo")
        public String extInfo;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("fundToolName")
        public String fundToolName;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("gmtCreate")
        public String gmtCreate;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("gmtFinish")
        public String gmtFinish;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("promotionFundTool")
        public Boolean promotionFundTool;

        public static CreatWithholdingOrderAndPayRequestOtherPayChannelDetailInfoListFundToolDetailInfoList build(java.util.Map<String, ?> map) throws Exception {
            CreatWithholdingOrderAndPayRequestOtherPayChannelDetailInfoListFundToolDetailInfoList self = new CreatWithholdingOrderAndPayRequestOtherPayChannelDetailInfoListFundToolDetailInfoList();
            return TeaModel.build(map, self);
        }

        public CreatWithholdingOrderAndPayRequestOtherPayChannelDetailInfoListFundToolDetailInfoList setAmount(String amount) {
            this.amount = amount;
            return this;
        }
        public String getAmount() {
            return this.amount;
        }

        public CreatWithholdingOrderAndPayRequestOtherPayChannelDetailInfoListFundToolDetailInfoList setExtInfo(String extInfo) {
            this.extInfo = extInfo;
            return this;
        }
        public String getExtInfo() {
            return this.extInfo;
        }

        public CreatWithholdingOrderAndPayRequestOtherPayChannelDetailInfoListFundToolDetailInfoList setFundToolName(String fundToolName) {
            this.fundToolName = fundToolName;
            return this;
        }
        public String getFundToolName() {
            return this.fundToolName;
        }

        public CreatWithholdingOrderAndPayRequestOtherPayChannelDetailInfoListFundToolDetailInfoList setGmtCreate(String gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public String getGmtCreate() {
            return this.gmtCreate;
        }

        public CreatWithholdingOrderAndPayRequestOtherPayChannelDetailInfoListFundToolDetailInfoList setGmtFinish(String gmtFinish) {
            this.gmtFinish = gmtFinish;
            return this;
        }
        public String getGmtFinish() {
            return this.gmtFinish;
        }

        public CreatWithholdingOrderAndPayRequestOtherPayChannelDetailInfoListFundToolDetailInfoList setPromotionFundTool(Boolean promotionFundTool) {
            this.promotionFundTool = promotionFundTool;
            return this;
        }
        public Boolean getPromotionFundTool() {
            return this.promotionFundTool;
        }

    }

    public static class CreatWithholdingOrderAndPayRequestOtherPayChannelDetailInfoList extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("amount")
        public String amount;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("fundToolDetailInfoList")
        public java.util.List<CreatWithholdingOrderAndPayRequestOtherPayChannelDetailInfoListFundToolDetailInfoList> fundToolDetailInfoList;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("payChannelName")
        public String payChannelName;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("payChannelOrderNo")
        public String payChannelOrderNo;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("payChannelType")
        public String payChannelType;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("promotionAmount")
        public String promotionAmount;

        public static CreatWithholdingOrderAndPayRequestOtherPayChannelDetailInfoList build(java.util.Map<String, ?> map) throws Exception {
            CreatWithholdingOrderAndPayRequestOtherPayChannelDetailInfoList self = new CreatWithholdingOrderAndPayRequestOtherPayChannelDetailInfoList();
            return TeaModel.build(map, self);
        }

        public CreatWithholdingOrderAndPayRequestOtherPayChannelDetailInfoList setAmount(String amount) {
            this.amount = amount;
            return this;
        }
        public String getAmount() {
            return this.amount;
        }

        public CreatWithholdingOrderAndPayRequestOtherPayChannelDetailInfoList setFundToolDetailInfoList(java.util.List<CreatWithholdingOrderAndPayRequestOtherPayChannelDetailInfoListFundToolDetailInfoList> fundToolDetailInfoList) {
            this.fundToolDetailInfoList = fundToolDetailInfoList;
            return this;
        }
        public java.util.List<CreatWithholdingOrderAndPayRequestOtherPayChannelDetailInfoListFundToolDetailInfoList> getFundToolDetailInfoList() {
            return this.fundToolDetailInfoList;
        }

        public CreatWithholdingOrderAndPayRequestOtherPayChannelDetailInfoList setPayChannelName(String payChannelName) {
            this.payChannelName = payChannelName;
            return this;
        }
        public String getPayChannelName() {
            return this.payChannelName;
        }

        public CreatWithholdingOrderAndPayRequestOtherPayChannelDetailInfoList setPayChannelOrderNo(String payChannelOrderNo) {
            this.payChannelOrderNo = payChannelOrderNo;
            return this;
        }
        public String getPayChannelOrderNo() {
            return this.payChannelOrderNo;
        }

        public CreatWithholdingOrderAndPayRequestOtherPayChannelDetailInfoList setPayChannelType(String payChannelType) {
            this.payChannelType = payChannelType;
            return this;
        }
        public String getPayChannelType() {
            return this.payChannelType;
        }

        public CreatWithholdingOrderAndPayRequestOtherPayChannelDetailInfoList setPromotionAmount(String promotionAmount) {
            this.promotionAmount = promotionAmount;
            return this;
        }
        public String getPromotionAmount() {
            return this.promotionAmount;
        }

    }

}
