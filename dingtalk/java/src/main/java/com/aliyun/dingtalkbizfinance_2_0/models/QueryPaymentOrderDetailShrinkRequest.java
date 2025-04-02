// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class QueryPaymentOrderDetailShrinkRequest extends TeaModel {
    @NameInMap("outBizNoList")
    public String outBizNoListShrink;

    /**
     * <strong>example:</strong>
     * <p>50455845112</p>
     */
    @NameInMap("userId")
    public String userId;

    public static QueryPaymentOrderDetailShrinkRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryPaymentOrderDetailShrinkRequest self = new QueryPaymentOrderDetailShrinkRequest();
        return TeaModel.build(map, self);
    }

    public QueryPaymentOrderDetailShrinkRequest setOutBizNoListShrink(String outBizNoListShrink) {
        this.outBizNoListShrink = outBizNoListShrink;
        return this;
    }
    public String getOutBizNoListShrink() {
        return this.outBizNoListShrink;
    }

    public QueryPaymentOrderDetailShrinkRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
