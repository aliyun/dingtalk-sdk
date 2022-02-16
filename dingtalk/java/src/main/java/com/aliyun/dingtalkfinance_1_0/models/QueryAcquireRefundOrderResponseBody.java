// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryAcquireRefundOrderResponseBody extends TeaModel {
    // 代扣金额（元）
    @NameInMap("amount")
    public String amount;

    // 订单创建日期
    @NameInMap("gmtCreate")
    public String gmtCreate;

    // 退款完成日期
    @NameInMap("gmtRefund")
    public String gmtRefund;

    // 主机构编号
    @NameInMap("instId")
    public String instId;

    // 钉钉订单号
    @NameInMap("orderNo")
    public String orderNo;

    // 原支付单外部流水号
    @NameInMap("originOutTradeNo")
    public String originOutTradeNo;

    // 外部退款订单号
    @NameInMap("outRefundNo")
    public String outRefundNo;

    // 支付渠道
    @NameInMap("payChannel")
    public String payChannel;

    // 支付渠道支付账号（脱敏后返回）
    @NameInMap("payChannelAccountNo")
    public String payChannelAccountNo;

    // 退款人userId
    @NameInMap("payerUserId")
    public String payerUserId;

    // 代扣备注
    @NameInMap("remark")
    public String remark;

    // 状态
    @NameInMap("status")
    public String status;

    // 子机构编号
    @NameInMap("subInstId")
    public String subInstId;

    // 代扣标题
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
