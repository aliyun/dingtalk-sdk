// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryRegisterOrderRequest extends TeaModel {
    /**
     * <p>主机构编号</p>
     */
    @NameInMap("instId")
    public String instId;

    /**
     * <p>申请单号，和外部流水号至少一个必填</p>
     */
    @NameInMap("orderId")
    public String orderId;

    /**
     * <p>外部流水号，和申请单编号至少一个必填</p>
     */
    @NameInMap("outTradeNo")
    public String outTradeNo;

    /**
     * <p>子机构编号</p>
     */
    @NameInMap("subInstId")
    public String subInstId;

    public static QueryRegisterOrderRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryRegisterOrderRequest self = new QueryRegisterOrderRequest();
        return TeaModel.build(map, self);
    }

    public QueryRegisterOrderRequest setInstId(String instId) {
        this.instId = instId;
        return this;
    }
    public String getInstId() {
        return this.instId;
    }

    public QueryRegisterOrderRequest setOrderId(String orderId) {
        this.orderId = orderId;
        return this;
    }
    public String getOrderId() {
        return this.orderId;
    }

    public QueryRegisterOrderRequest setOutTradeNo(String outTradeNo) {
        this.outTradeNo = outTradeNo;
        return this;
    }
    public String getOutTradeNo() {
        return this.outTradeNo;
    }

    public QueryRegisterOrderRequest setSubInstId(String subInstId) {
        this.subInstId = subInstId;
        return this;
    }
    public String getSubInstId() {
        return this.subInstId;
    }

}
