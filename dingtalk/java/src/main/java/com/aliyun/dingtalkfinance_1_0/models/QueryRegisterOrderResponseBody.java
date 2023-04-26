// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryRegisterOrderResponseBody extends TeaModel {
    @NameInMap("failReason")
    public String failReason;

    @NameInMap("gmtAudit")
    public String gmtAudit;

    @NameInMap("instId")
    public String instId;

    @NameInMap("orderId")
    public String orderId;

    @NameInMap("outTradeNo")
    public String outTradeNo;

    @NameInMap("status")
    public String status;

    @NameInMap("subInstId")
    public String subInstId;

    @NameInMap("subInstName")
    public String subInstName;

    public static QueryRegisterOrderResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryRegisterOrderResponseBody self = new QueryRegisterOrderResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryRegisterOrderResponseBody setFailReason(String failReason) {
        this.failReason = failReason;
        return this;
    }
    public String getFailReason() {
        return this.failReason;
    }

    public QueryRegisterOrderResponseBody setGmtAudit(String gmtAudit) {
        this.gmtAudit = gmtAudit;
        return this;
    }
    public String getGmtAudit() {
        return this.gmtAudit;
    }

    public QueryRegisterOrderResponseBody setInstId(String instId) {
        this.instId = instId;
        return this;
    }
    public String getInstId() {
        return this.instId;
    }

    public QueryRegisterOrderResponseBody setOrderId(String orderId) {
        this.orderId = orderId;
        return this;
    }
    public String getOrderId() {
        return this.orderId;
    }

    public QueryRegisterOrderResponseBody setOutTradeNo(String outTradeNo) {
        this.outTradeNo = outTradeNo;
        return this;
    }
    public String getOutTradeNo() {
        return this.outTradeNo;
    }

    public QueryRegisterOrderResponseBody setStatus(String status) {
        this.status = status;
        return this;
    }
    public String getStatus() {
        return this.status;
    }

    public QueryRegisterOrderResponseBody setSubInstId(String subInstId) {
        this.subInstId = subInstId;
        return this;
    }
    public String getSubInstId() {
        return this.subInstId;
    }

    public QueryRegisterOrderResponseBody setSubInstName(String subInstName) {
        this.subInstName = subInstName;
        return this;
    }
    public String getSubInstName() {
        return this.subInstName;
    }

}
