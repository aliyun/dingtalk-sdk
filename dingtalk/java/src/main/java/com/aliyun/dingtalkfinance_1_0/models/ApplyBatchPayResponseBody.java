// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class ApplyBatchPayResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("orderNo")
    public String orderNo;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("payData")
    public String payData;

    public static ApplyBatchPayResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ApplyBatchPayResponseBody self = new ApplyBatchPayResponseBody();
        return TeaModel.build(map, self);
    }

    public ApplyBatchPayResponseBody setOrderNo(String orderNo) {
        this.orderNo = orderNo;
        return this;
    }
    public String getOrderNo() {
        return this.orderNo;
    }

    public ApplyBatchPayResponseBody setPayData(String payData) {
        this.payData = payData;
        return this;
    }
    public String getPayData() {
        return this.payData;
    }

}
