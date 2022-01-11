// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class NotifyPayCodePayResultRequest extends TeaModel {
    // 订单金额
    @NameInMap("amount")
    public String amount;

    // 收费金额
    @NameInMap("chargeAmount")
    public String chargeAmount;

    // 企业id
    @NameInMap("corpId")
    public String corpId;

    // 扩展信息
    @NameInMap("extInfo")
    public String extInfo;

    // 交易开始时间
    @NameInMap("gmtTradeCreate")
    public String gmtTradeCreate;

    // 交易结束时间
    @NameInMap("gmtTradeFinish")
    public String gmtTradeFinish;

    // merchantName
    @NameInMap("merchantName")
    public String merchantName;

    // 支付渠道明细信息
    @NameInMap("payChannelDetailList")
    public java.util.List<NotifyPayCodePayResultRequestPayChannelDetailList> payChannelDetailList;

    // 付款码值
    @NameInMap("payCode")
    public String payCode;

    // 订单优惠金额
    @NameInMap("promotionAmount")
    public String promotionAmount;

    // 备注
    @NameInMap("remark")
    public String remark;

    // 订单标题
    @NameInMap("title")
    public String title;

    // 支付失败错误码
    @NameInMap("tradeErrorCode")
    public String tradeErrorCode;

    // 支付失败信息
    @NameInMap("tradeErrorMsg")
    public String tradeErrorMsg;

    // 交易号
    @NameInMap("tradeNo")
    public String tradeNo;

    // 交易状态
    @NameInMap("tradeStatus")
    public String tradeStatus;

    // 用户id
    @NameInMap("userId")
    public String userId;

    public static NotifyPayCodePayResultRequest build(java.util.Map<String, ?> map) throws Exception {
        NotifyPayCodePayResultRequest self = new NotifyPayCodePayResultRequest();
        return TeaModel.build(map, self);
    }

    public NotifyPayCodePayResultRequest setAmount(String amount) {
        this.amount = amount;
        return this;
    }
    public String getAmount() {
        return this.amount;
    }

    public NotifyPayCodePayResultRequest setChargeAmount(String chargeAmount) {
        this.chargeAmount = chargeAmount;
        return this;
    }
    public String getChargeAmount() {
        return this.chargeAmount;
    }

    public NotifyPayCodePayResultRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public NotifyPayCodePayResultRequest setExtInfo(String extInfo) {
        this.extInfo = extInfo;
        return this;
    }
    public String getExtInfo() {
        return this.extInfo;
    }

    public NotifyPayCodePayResultRequest setGmtTradeCreate(String gmtTradeCreate) {
        this.gmtTradeCreate = gmtTradeCreate;
        return this;
    }
    public String getGmtTradeCreate() {
        return this.gmtTradeCreate;
    }

    public NotifyPayCodePayResultRequest setGmtTradeFinish(String gmtTradeFinish) {
        this.gmtTradeFinish = gmtTradeFinish;
        return this;
    }
    public String getGmtTradeFinish() {
        return this.gmtTradeFinish;
    }

    public NotifyPayCodePayResultRequest setMerchantName(String merchantName) {
        this.merchantName = merchantName;
        return this;
    }
    public String getMerchantName() {
        return this.merchantName;
    }

    public NotifyPayCodePayResultRequest setPayChannelDetailList(java.util.List<NotifyPayCodePayResultRequestPayChannelDetailList> payChannelDetailList) {
        this.payChannelDetailList = payChannelDetailList;
        return this;
    }
    public java.util.List<NotifyPayCodePayResultRequestPayChannelDetailList> getPayChannelDetailList() {
        return this.payChannelDetailList;
    }

    public NotifyPayCodePayResultRequest setPayCode(String payCode) {
        this.payCode = payCode;
        return this;
    }
    public String getPayCode() {
        return this.payCode;
    }

    public NotifyPayCodePayResultRequest setPromotionAmount(String promotionAmount) {
        this.promotionAmount = promotionAmount;
        return this;
    }
    public String getPromotionAmount() {
        return this.promotionAmount;
    }

    public NotifyPayCodePayResultRequest setRemark(String remark) {
        this.remark = remark;
        return this;
    }
    public String getRemark() {
        return this.remark;
    }

    public NotifyPayCodePayResultRequest setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public NotifyPayCodePayResultRequest setTradeErrorCode(String tradeErrorCode) {
        this.tradeErrorCode = tradeErrorCode;
        return this;
    }
    public String getTradeErrorCode() {
        return this.tradeErrorCode;
    }

    public NotifyPayCodePayResultRequest setTradeErrorMsg(String tradeErrorMsg) {
        this.tradeErrorMsg = tradeErrorMsg;
        return this;
    }
    public String getTradeErrorMsg() {
        return this.tradeErrorMsg;
    }

    public NotifyPayCodePayResultRequest setTradeNo(String tradeNo) {
        this.tradeNo = tradeNo;
        return this;
    }
    public String getTradeNo() {
        return this.tradeNo;
    }

    public NotifyPayCodePayResultRequest setTradeStatus(String tradeStatus) {
        this.tradeStatus = tradeStatus;
        return this;
    }
    public String getTradeStatus() {
        return this.tradeStatus;
    }

    public NotifyPayCodePayResultRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public static class NotifyPayCodePayResultRequestPayChannelDetailListFundToolDetailList extends TeaModel {
        // 1.00
        @NameInMap("amount")
        public String amount;

        // 扩展信息
        @NameInMap("extInfo")
        public String extInfo;

        // 资金渠道名称
        @NameInMap("fundToolName")
        public String fundToolName;

        // 开始时间
        @NameInMap("gmtCreate")
        public String gmtCreate;

        // 结束时间
        @NameInMap("gmtFinish")
        public String gmtFinish;

        // 是否是优惠工具
        @NameInMap("promotionFundTool")
        public Boolean promotionFundTool;

        public static NotifyPayCodePayResultRequestPayChannelDetailListFundToolDetailList build(java.util.Map<String, ?> map) throws Exception {
            NotifyPayCodePayResultRequestPayChannelDetailListFundToolDetailList self = new NotifyPayCodePayResultRequestPayChannelDetailListFundToolDetailList();
            return TeaModel.build(map, self);
        }

        public NotifyPayCodePayResultRequestPayChannelDetailListFundToolDetailList setAmount(String amount) {
            this.amount = amount;
            return this;
        }
        public String getAmount() {
            return this.amount;
        }

        public NotifyPayCodePayResultRequestPayChannelDetailListFundToolDetailList setExtInfo(String extInfo) {
            this.extInfo = extInfo;
            return this;
        }
        public String getExtInfo() {
            return this.extInfo;
        }

        public NotifyPayCodePayResultRequestPayChannelDetailListFundToolDetailList setFundToolName(String fundToolName) {
            this.fundToolName = fundToolName;
            return this;
        }
        public String getFundToolName() {
            return this.fundToolName;
        }

        public NotifyPayCodePayResultRequestPayChannelDetailListFundToolDetailList setGmtCreate(String gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public String getGmtCreate() {
            return this.gmtCreate;
        }

        public NotifyPayCodePayResultRequestPayChannelDetailListFundToolDetailList setGmtFinish(String gmtFinish) {
            this.gmtFinish = gmtFinish;
            return this;
        }
        public String getGmtFinish() {
            return this.gmtFinish;
        }

        public NotifyPayCodePayResultRequestPayChannelDetailListFundToolDetailList setPromotionFundTool(Boolean promotionFundTool) {
            this.promotionFundTool = promotionFundTool;
            return this;
        }
        public Boolean getPromotionFundTool() {
            return this.promotionFundTool;
        }

    }

    public static class NotifyPayCodePayResultRequestPayChannelDetailList extends TeaModel {
        // 支付金额
        @NameInMap("amount")
        public String amount;

        // 资金工具明细
        @NameInMap("fundToolDetailList")
        public java.util.List<NotifyPayCodePayResultRequestPayChannelDetailListFundToolDetailList> fundToolDetailList;

        // 开始时间
        @NameInMap("gmtCreate")
        public String gmtCreate;

        // 结束时间
        @NameInMap("gmtFinish")
        public String gmtFinish;

        // 支付渠道名称
        @NameInMap("payChannelName")
        public String payChannelName;

        // 支付渠道单号
        @NameInMap("payChannelOrderNo")
        public String payChannelOrderNo;

        // 支付渠道类型
        @NameInMap("payChannelType")
        public String payChannelType;

        // 优惠金额
        @NameInMap("promotionAmount")
        public String promotionAmount;

        public static NotifyPayCodePayResultRequestPayChannelDetailList build(java.util.Map<String, ?> map) throws Exception {
            NotifyPayCodePayResultRequestPayChannelDetailList self = new NotifyPayCodePayResultRequestPayChannelDetailList();
            return TeaModel.build(map, self);
        }

        public NotifyPayCodePayResultRequestPayChannelDetailList setAmount(String amount) {
            this.amount = amount;
            return this;
        }
        public String getAmount() {
            return this.amount;
        }

        public NotifyPayCodePayResultRequestPayChannelDetailList setFundToolDetailList(java.util.List<NotifyPayCodePayResultRequestPayChannelDetailListFundToolDetailList> fundToolDetailList) {
            this.fundToolDetailList = fundToolDetailList;
            return this;
        }
        public java.util.List<NotifyPayCodePayResultRequestPayChannelDetailListFundToolDetailList> getFundToolDetailList() {
            return this.fundToolDetailList;
        }

        public NotifyPayCodePayResultRequestPayChannelDetailList setGmtCreate(String gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public String getGmtCreate() {
            return this.gmtCreate;
        }

        public NotifyPayCodePayResultRequestPayChannelDetailList setGmtFinish(String gmtFinish) {
            this.gmtFinish = gmtFinish;
            return this;
        }
        public String getGmtFinish() {
            return this.gmtFinish;
        }

        public NotifyPayCodePayResultRequestPayChannelDetailList setPayChannelName(String payChannelName) {
            this.payChannelName = payChannelName;
            return this;
        }
        public String getPayChannelName() {
            return this.payChannelName;
        }

        public NotifyPayCodePayResultRequestPayChannelDetailList setPayChannelOrderNo(String payChannelOrderNo) {
            this.payChannelOrderNo = payChannelOrderNo;
            return this;
        }
        public String getPayChannelOrderNo() {
            return this.payChannelOrderNo;
        }

        public NotifyPayCodePayResultRequestPayChannelDetailList setPayChannelType(String payChannelType) {
            this.payChannelType = payChannelType;
            return this;
        }
        public String getPayChannelType() {
            return this.payChannelType;
        }

        public NotifyPayCodePayResultRequestPayChannelDetailList setPromotionAmount(String promotionAmount) {
            this.promotionAmount = promotionAmount;
            return this;
        }
        public String getPromotionAmount() {
            return this.promotionAmount;
        }

    }

}
