// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class ConfirmPaymentOrderRequest extends TeaModel {
    @NameInMap("outBizNoList")
    public java.util.List<String> outBizNoList;

    /**
     * <strong>example:</strong>
     * <p>5041123</p>
     */
    @NameInMap("userId")
    public String userId;

    public static ConfirmPaymentOrderRequest build(java.util.Map<String, ?> map) throws Exception {
        ConfirmPaymentOrderRequest self = new ConfirmPaymentOrderRequest();
        return TeaModel.build(map, self);
    }

    public ConfirmPaymentOrderRequest setOutBizNoList(java.util.List<String> outBizNoList) {
        this.outBizNoList = outBizNoList;
        return this;
    }
    public java.util.List<String> getOutBizNoList() {
        return this.outBizNoList;
    }

    public ConfirmPaymentOrderRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
