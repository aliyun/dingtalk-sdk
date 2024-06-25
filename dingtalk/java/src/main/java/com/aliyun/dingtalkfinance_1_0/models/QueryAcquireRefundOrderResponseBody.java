// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryAcquireRefundOrderResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>10.01</p>
     */
    @NameInMap("amount")
    public String amount;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>2021-11-15 10:10:09</p>
     */
    @NameInMap("gmtCreate")
    public String gmtCreate;

    /**
     * <strong>example:</strong>
     * <p>2021-11-15 10:10:10</p>
     */
    @NameInMap("gmtRefund")
    public String gmtRefund;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>202111010001</p>
     */
    @NameInMap("instId")
    public String instId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>202121241343151</p>
     */
    @NameInMap("orderNo")
    public String orderNo;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>202111020001</p>
     */
    @NameInMap("originOutTradeNo")
    public String originOutTradeNo;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>r202111020001</p>
     */
    @NameInMap("outRefundNo")
    public String outRefundNo;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>ALIPAY</p>
     */
    @NameInMap("payChannel")
    public String payChannel;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>13****09</p>
     */
    @NameInMap("payChannelAccountNo")
    public String payChannelAccountNo;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>123124</p>
     */
    @NameInMap("payerUserId")
    public String payerUserId;

    /**
     * <strong>example:</strong>
     * <p>备注</p>
     */
    @NameInMap("remark")
    public String remark;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>SUCCESS</p>
     */
    @NameInMap("status")
    public String status;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1001</p>
     */
    @NameInMap("subInstId")
    public String subInstId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>餐费</p>
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
