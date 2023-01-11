// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryRegisterOrderResponseBody extends TeaModel {
    /**
     * <p>失败原因</p>
     */
    @NameInMap("failReason")
    public String failReason;

    /**
     * <p>审核时间</p>
     */
    @NameInMap("gmtAudit")
    public String gmtAudit;

    /**
     * <p>主机构编号</p>
     */
    @NameInMap("instId")
    public String instId;

    /**
     * <p>申请单号</p>
     */
    @NameInMap("orderId")
    public String orderId;

    /**
     * <p>外部流水号</p>
     */
    @NameInMap("outTradeNo")
    public String outTradeNo;

    /**
     * <p>申请单状态</p>
     */
    @NameInMap("status")
    public String status;

    /**
     * <p>子机构编号</p>
     */
    @NameInMap("subInstId")
    public String subInstId;

    /**
     * <p>子机构名称</p>
     */
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
