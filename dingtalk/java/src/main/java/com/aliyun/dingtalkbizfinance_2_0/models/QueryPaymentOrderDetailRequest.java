// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class QueryPaymentOrderDetailRequest extends TeaModel {
    @NameInMap("outBizNoList")
    public java.util.List<String> outBizNoList;

    /**
     * <strong>example:</strong>
     * <p>50455845112</p>
     */
    @NameInMap("userId")
    public String userId;

    public static QueryPaymentOrderDetailRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryPaymentOrderDetailRequest self = new QueryPaymentOrderDetailRequest();
        return TeaModel.build(map, self);
    }

    public QueryPaymentOrderDetailRequest setOutBizNoList(java.util.List<String> outBizNoList) {
        this.outBizNoList = outBizNoList;
        return this;
    }
    public java.util.List<String> getOutBizNoList() {
        return this.outBizNoList;
    }

    public QueryPaymentOrderDetailRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
