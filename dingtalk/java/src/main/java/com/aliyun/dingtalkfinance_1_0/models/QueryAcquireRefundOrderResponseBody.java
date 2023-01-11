// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryAcquireRefundOrderResponseBody extends TeaModel {
    /**
     * <p>代扣金额（元）</p>
     */
    @NameInMap("amount")
    public String amount;

    /**
     * <p>订单创建日期</p>
     */
    @NameInMap("gmtCreate")
    public String gmtCreate;

    /**
     * <p>退款完成日期</p>
     */
    @NameInMap("gmtRefund")
    public String gmtRefund;

    /**
     * <p>主机构编号</p>
     */
    @NameInMap("instId")
    public String instId;

    /**
     * <p>钉钉订单号</p>
     */
    @NameInMap("orderNo")
    public String orderNo;

    /**
     * <p>原支付单外部流水号</p>
     */
    @NameInMap("originOutTradeNo")
    public String originOutTradeNo;

    /**
     * <p>外部退款订单号</p>
     */
    @NameInMap("outRefundNo")
    public String outRefundNo;

    /**
     * <p>支付渠道</p>
     */
    @NameInMap("payChannel")
    public String payChannel;

    /**
     * <p>支付渠道支付账号（脱敏后返回）</p>
     */
    @NameInMap("payChannelAccountNo")
    public String payChannelAccountNo;

    /**
     * <p>退款人userId</p>
     */
    @NameInMap("payerUserId")
    public String payerUserId;

    /**
     * <p>代扣备注</p>
     */
    @NameInMap("remark")
    public String remark;

    /**
     * <p>状态</p>
     */
    @NameInMap("status")
    public String status;

    /**
     * <p>子机构编号</p>
     */
    @NameInMap("subInstId")
    public String subInstId;

    /**
     * <p>代扣标题</p>
     */
    @NameInMap("title")
    public String title;

    public static QueryAcquireRefundOrderResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryAcquireRefundOrderResponseBody self = new QueryAcquireRefundOrderResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryAcquireRefundOrderResponseBody setAmount(String amount) {
        this.amount = amount;
        return this;
    }
    public String getAmount() {
        return this.amount;
    }

    public QueryAcquireRefundOrderResponseBody setGmtCreate(String gmtCreate) {
        this.gmtCreate = gmtCreate;
        return this;
    }
    public String getGmtCreate() {
        return this.gmtCreate;
    }

    public QueryAcquireRefundOrderResponseBody setGmtRefund(String gmtRefund) {
        this.gmtRefund = gmtRefund;
        return this;
    }
    public String getGmtRefund() {
        return this.gmtRefund;
    }

    public QueryAcquireRefundOrderResponseBody setInstId(String instId) {
        this.instId = instId;
        return this;
    }
    public String getInstId() {
        return this.instId;
    }

    public QueryAcquireRefundOrderResponseBody setOrderNo(String orderNo) {
        this.orderNo = orderNo;
        return this;
    }
    public String getOrderNo() {
        return this.orderNo;
    }

    public QueryAcquireRefundOrderResponseBody setOriginOutTradeNo(String originOutTradeNo) {
        this.originOutTradeNo = originOutTradeNo;
        return this;
    }
    public String getOriginOutTradeNo() {
        return this.originOutTradeNo;
    }

    public QueryAcquireRefundOrderResponseBody setOutRefundNo(String outRefundNo) {
        this.outRefundNo = outRefundNo;
        return this;
    }
    public String getOutRefundNo() {
        return this.outRefundNo;
    }

    public QueryAcquireRefundOrderResponseBody setPayChannel(String payChannel) {
        this.payChannel = payChannel;
        return this;
    }
    public String getPayChannel() {
        return this.payChannel;
    }

    public QueryAcquireRefundOrderResponseBody setPayChannelAccountNo(String payChannelAccountNo) {
        this.payChannelAccountNo = payChannelAccountNo;
        return this;
    }
    public String getPayChannelAccountNo() {
        return this.payChannelAccountNo;
    }

    public QueryAcquireRefundOrderResponseBody setPayerUserId(String payerUserId) {
        this.payerUserId = payerUserId;
        return this;
    }
    public String getPayerUserId() {
        return this.payerUserId;
    }

    public QueryAcquireRefundOrderResponseBody setRemark(String remark) {
        this.remark = remark;
        return this;
    }
    public String getRemark() {
        return this.remark;
    }

    public QueryAcquireRefundOrderResponseBody setStatus(String status) {
        this.status = status;
        return this;
    }
    public String getStatus() {
        return this.status;
    }

    public QueryAcquireRefundOrderResponseBody setSubInstId(String subInstId) {
        this.subInstId = subInstId;
        return this;
    }
    public String getSubInstId() {
        return this.subInstId;
    }

    public QueryAcquireRefundOrderResponseBody setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

}
