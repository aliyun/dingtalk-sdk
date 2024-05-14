// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class CreateAcquireRefundOrderRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("instId")
    public String instId;

    @NameInMap("operatorUserId")
    public String operatorUserId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("originOutTradeNo")
    public String originOutTradeNo;

    @NameInMap("otherPayChannelDetailInfoList")
    public java.util.List<CreateAcquireRefundOrderRequestOtherPayChannelDetailInfoList> otherPayChannelDetailInfoList;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("outRefundNo")
    public String outRefundNo;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("refundAmount")
    public String refundAmount;

    @NameInMap("remark")
    public String remark;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("subInstId")
    public String subInstId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("title")
    public String title;

    public static CreateAcquireRefundOrderRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateAcquireRefundOrderRequest self = new CreateAcquireRefundOrderRequest();
        return TeaModel.build(map, self);
    }

    public CreateAcquireRefundOrderRequest setInstId(String instId) {
        this.instId = instId;
        return this;
    }
    public String getInstId() {
        return this.instId;
    }

    public CreateAcquireRefundOrderRequest setOperatorUserId(String operatorUserId) {
        this.operatorUserId = operatorUserId;
        return this;
    }
    public String getOperatorUserId() {
        return this.operatorUserId;
    }

    public CreateAcquireRefundOrderRequest setOriginOutTradeNo(String originOutTradeNo) {
        this.originOutTradeNo = originOutTradeNo;
        return this;
    }
    public String getOriginOutTradeNo() {
        return this.originOutTradeNo;
    }

    public CreateAcquireRefundOrderRequest setOtherPayChannelDetailInfoList(java.util.List<CreateAcquireRefundOrderRequestOtherPayChannelDetailInfoList> otherPayChannelDetailInfoList) {
        this.otherPayChannelDetailInfoList = otherPayChannelDetailInfoList;
        return this;
    }
    public java.util.List<CreateAcquireRefundOrderRequestOtherPayChannelDetailInfoList> getOtherPayChannelDetailInfoList() {
        return this.otherPayChannelDetailInfoList;
    }

    public CreateAcquireRefundOrderRequest setOutRefundNo(String outRefundNo) {
        this.outRefundNo = outRefundNo;
        return this;
    }
    public String getOutRefundNo() {
        return this.outRefundNo;
    }

    public CreateAcquireRefundOrderRequest setRefundAmount(String refundAmount) {
        this.refundAmount = refundAmount;
        return this;
    }
    public String getRefundAmount() {
        return this.refundAmount;
    }

    public CreateAcquireRefundOrderRequest setRemark(String remark) {
        this.remark = remark;
        return this;
    }
    public String getRemark() {
        return this.remark;
    }

    public CreateAcquireRefundOrderRequest setSubInstId(String subInstId) {
        this.subInstId = subInstId;
        return this;
    }
    public String getSubInstId() {
        return this.subInstId;
    }

    public CreateAcquireRefundOrderRequest setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public static class CreateAcquireRefundOrderRequestOtherPayChannelDetailInfoListFundToolDetailInfoList extends TeaModel {
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

        public static CreateAcquireRefundOrderRequestOtherPayChannelDetailInfoListFundToolDetailInfoList build(java.util.Map<String, ?> map) throws Exception {
            CreateAcquireRefundOrderRequestOtherPayChannelDetailInfoListFundToolDetailInfoList self = new CreateAcquireRefundOrderRequestOtherPayChannelDetailInfoListFundToolDetailInfoList();
            return TeaModel.build(map, self);
        }

        public CreateAcquireRefundOrderRequestOtherPayChannelDetailInfoListFundToolDetailInfoList setAmount(String amount) {
            this.amount = amount;
            return this;
        }
        public String getAmount() {
            return this.amount;
        }

        public CreateAcquireRefundOrderRequestOtherPayChannelDetailInfoListFundToolDetailInfoList setExtInfo(String extInfo) {
            this.extInfo = extInfo;
            return this;
        }
        public String getExtInfo() {
            return this.extInfo;
        }

        public CreateAcquireRefundOrderRequestOtherPayChannelDetailInfoListFundToolDetailInfoList setFundToolName(String fundToolName) {
            this.fundToolName = fundToolName;
            return this;
        }
        public String getFundToolName() {
            return this.fundToolName;
        }

        public CreateAcquireRefundOrderRequestOtherPayChannelDetailInfoListFundToolDetailInfoList setGmtCreate(String gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public String getGmtCreate() {
            return this.gmtCreate;
        }

        public CreateAcquireRefundOrderRequestOtherPayChannelDetailInfoListFundToolDetailInfoList setGmtFinish(String gmtFinish) {
            this.gmtFinish = gmtFinish;
            return this;
        }
        public String getGmtFinish() {
            return this.gmtFinish;
        }

        public CreateAcquireRefundOrderRequestOtherPayChannelDetailInfoListFundToolDetailInfoList setPromotionFundTool(Boolean promotionFundTool) {
            this.promotionFundTool = promotionFundTool;
            return this;
        }
        public Boolean getPromotionFundTool() {
            return this.promotionFundTool;
        }

    }

    public static class CreateAcquireRefundOrderRequestOtherPayChannelDetailInfoList extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("amount")
        public String amount;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("fundToolDetailInfoList")
        public java.util.List<CreateAcquireRefundOrderRequestOtherPayChannelDetailInfoListFundToolDetailInfoList> fundToolDetailInfoList;

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

        public static CreateAcquireRefundOrderRequestOtherPayChannelDetailInfoList build(java.util.Map<String, ?> map) throws Exception {
            CreateAcquireRefundOrderRequestOtherPayChannelDetailInfoList self = new CreateAcquireRefundOrderRequestOtherPayChannelDetailInfoList();
            return TeaModel.build(map, self);
        }

        public CreateAcquireRefundOrderRequestOtherPayChannelDetailInfoList setAmount(String amount) {
            this.amount = amount;
            return this;
        }
        public String getAmount() {
            return this.amount;
        }

        public CreateAcquireRefundOrderRequestOtherPayChannelDetailInfoList setFundToolDetailInfoList(java.util.List<CreateAcquireRefundOrderRequestOtherPayChannelDetailInfoListFundToolDetailInfoList> fundToolDetailInfoList) {
            this.fundToolDetailInfoList = fundToolDetailInfoList;
            return this;
        }
        public java.util.List<CreateAcquireRefundOrderRequestOtherPayChannelDetailInfoListFundToolDetailInfoList> getFundToolDetailInfoList() {
            return this.fundToolDetailInfoList;
        }

        public CreateAcquireRefundOrderRequestOtherPayChannelDetailInfoList setPayChannelName(String payChannelName) {
            this.payChannelName = payChannelName;
            return this;
        }
        public String getPayChannelName() {
            return this.payChannelName;
        }

        public CreateAcquireRefundOrderRequestOtherPayChannelDetailInfoList setPayChannelOrderNo(String payChannelOrderNo) {
            this.payChannelOrderNo = payChannelOrderNo;
            return this;
        }
        public String getPayChannelOrderNo() {
            return this.payChannelOrderNo;
        }

        public CreateAcquireRefundOrderRequestOtherPayChannelDetailInfoList setPayChannelType(String payChannelType) {
            this.payChannelType = payChannelType;
            return this;
        }
        public String getPayChannelType() {
            return this.payChannelType;
        }

        public CreateAcquireRefundOrderRequestOtherPayChannelDetailInfoList setPromotionAmount(String promotionAmount) {
            this.promotionAmount = promotionAmount;
            return this;
        }
        public String getPromotionAmount() {
            return this.promotionAmount;
        }

    }

}
