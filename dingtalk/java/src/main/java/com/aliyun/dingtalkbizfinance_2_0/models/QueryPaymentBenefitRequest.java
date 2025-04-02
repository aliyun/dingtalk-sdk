// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class QueryPaymentBenefitRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>5042215136</p>
     */
    @NameInMap("userId")
    public String userId;

    public static QueryPaymentBenefitRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryPaymentBenefitRequest self = new QueryPaymentBenefitRequest();
        return TeaModel.build(map, self);
    }

    public QueryPaymentBenefitRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
