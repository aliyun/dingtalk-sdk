// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryWithholdingOrderResponseBody extends TeaModel {
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
     * <p>付款完成日期</p>
     */
    @NameInMap("gmtPay")
    public String gmtPay;

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
     * <p>支付渠道支付账号（脱敏后返回）</p>
     */
    @NameInMap("payChannelAccountNo")
    public String payChannelAccountNo;

    /**
     * <p>付款人userId</p>
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

    public static QueryWithholdingOrderResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryWithholdingOrderResponseBody self = new QueryWithholdingOrderResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryWithholdingOrderResponseBody setAmount(String amount) {
        this.amount = amount;
        return this;
    }
    public String getAmount() {
        return this.amount;
    }

    public QueryWithholdingOrderResponseBody setGmtCreate(String gmtCreate) {
        this.gmtCreate = gmtCreate;
        return this;
    }
    public String getGmtCreate() {
        return this.gmtCreate;
    }

    public QueryWithholdingOrderResponseBody setGmtPay(String gmtPay) {
        this.gmtPay = gmtPay;
        return this;
    }
    public String getGmtPay() {
        return this.gmtPay;
    }

    public QueryWithholdingOrderResponseBody setInstId(String instId) {
        this.instId = instId;
        return this;
    }
    public String getInstId() {
        return this.instId;
    }

    public QueryWithholdingOrderResponseBody setOrderNo(String orderNo) {
        this.orderNo = orderNo;
        return this;
    }
    public String getOrderNo() {
        return this.orderNo;
    }

    public QueryWithholdingOrderResponseBody setOutTradeNo(String outTradeNo) {
        this.outTradeNo = outTradeNo;
        return this;
    }
    public String getOutTradeNo() {
        return this.outTradeNo;
    }

    public QueryWithholdingOrderResponseBody setPayChannel(String payChannel) {
        this.payChannel = payChannel;
        return this;
    }
    public String getPayChannel() {
        return this.payChannel;
    }

    public QueryWithholdingOrderResponseBody setPayChannelAccountNo(String payChannelAccountNo) {
        this.payChannelAccountNo = payChannelAccountNo;
        return this;
    }
    public String getPayChannelAccountNo() {
        return this.payChannelAccountNo;
    }

    public QueryWithholdingOrderResponseBody setPayerUserId(String payerUserId) {
        this.payerUserId = payerUserId;
        return this;
    }
    public String getPayerUserId() {
        return this.payerUserId;
    }

    public QueryWithholdingOrderResponseBody setRemark(String remark) {
        this.remark = remark;
        return this;
    }
    public String getRemark() {
        return this.remark;
    }

    public QueryWithholdingOrderResponseBody setStatus(String status) {
        this.status = status;
        return this;
    }
    public String getStatus() {
        return this.status;
    }

    public QueryWithholdingOrderResponseBody setSubInstId(String subInstId) {
        this.subInstId = subInstId;
        return this;
    }
    public String getSubInstId() {
        return this.subInstId;
    }

    public QueryWithholdingOrderResponseBody setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

}
