// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class CreatWithholdingOrderAndPayRequest extends TeaModel {
    /**
     * <p>扣款金额</p>
     */
    @NameInMap("amount")
    public String amount;

    /**
     * <p>主机构编号</p>
     */
    @NameInMap("instId")
    public String instId;

    /**
     * <p>其他资金渠道付款明细</p>
     */
    @NameInMap("otherPayChannelDetailInfoList")
    public java.util.List<CreatWithholdingOrderAndPayRequestOtherPayChannelDetailInfoList> otherPayChannelDetailInfoList;

    /**
     * <p>外部订单号</p>
     */
    @NameInMap("outTradeNo")
    public String outTradeNo;

    /**
     * <p>支付渠道</p>
     */
    @NameInMap("payChannel")
    public String payChannel;

    /**
     * <p>付款人staffId</p>
     */
    @NameInMap("payerUserId")
    public String payerUserId;

    /**
     * <p>代扣备注</p>
     */
    @NameInMap("remark")
    public String remark;

    /**
     * <p>子机构编号</p>
     */
    @NameInMap("subInstId")
    public String subInstId;

    /**
     * <p>代扣过期时间</p>
     */
    @NameInMap("timeOutExpress")
    public String timeOutExpress;

    /**
     * <p>代扣标题</p>
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
         * <p>金额</p>
         */
        @NameInMap("amount")
        public String amount;

        /**
         * <p>扩展信息</p>
         */
        @NameInMap("extInfo")
        public String extInfo;

        /**
         * <p>资金工具名称</p>
         */
        @NameInMap("fundToolName")
        public String fundToolName;

        /**
         * <p>资金明细创建时间</p>
         */
        @NameInMap("gmtCreate")
        public String gmtCreate;

        /**
         * <p>资金明细完成时间</p>
         */
        @NameInMap("gmtFinish")
        public String gmtFinish;

        /**
         * <p>是否是优惠工具</p>
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
         * <p>渠道金额</p>
         */
        @NameInMap("amount")
        public String amount;

        /**
         * <p>资金明细列表</p>
         */
        @NameInMap("fundToolDetailInfoList")
        public java.util.List<CreatWithholdingOrderAndPayRequestOtherPayChannelDetailInfoListFundToolDetailInfoList> fundToolDetailInfoList;

        /**
         * <p>渠道名称</p>
         */
        @NameInMap("payChannelName")
        public String payChannelName;

        /**
         * <p>支付渠道单号</p>
         */
        @NameInMap("payChannelOrderNo")
        public String payChannelOrderNo;

        /**
         * <p>渠道类型</p>
         */
        @NameInMap("payChannelType")
        public String payChannelType;

        /**
         * <p>总优惠金额</p>
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
