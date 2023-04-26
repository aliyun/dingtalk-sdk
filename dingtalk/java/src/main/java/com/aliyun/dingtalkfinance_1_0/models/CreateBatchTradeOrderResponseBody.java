// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class CreateBatchTradeOrderResponseBody extends TeaModel {
    @NameInMap("orderNo")
    public String orderNo;

    @NameInMap("orderStatus")
    public String orderStatus;

    @NameInMap("outBatchNo")
    public String outBatchNo;

    public static CreateBatchTradeOrderResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateBatchTradeOrderResponseBody self = new CreateBatchTradeOrderResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateBatchTradeOrderResponseBody setOrderNo(String orderNo) {
        this.orderNo = orderNo;
        return this;
    }
    public String getOrderNo() {
        return this.orderNo;
    }

    public CreateBatchTradeOrderResponseBody setOrderStatus(String orderStatus) {
        this.orderStatus = orderStatus;
        return this;
    }
    public String getOrderStatus() {
        return this.orderStatus;
    }

    public CreateBatchTradeOrderResponseBody setOutBatchNo(String outBatchNo) {
        this.outBatchNo = outBatchNo;
        return this;
    }
    public String getOutBatchNo() {
        return this.outBatchNo;
    }

}
