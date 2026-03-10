// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class QueryPaymentRecallFileVTwoRequest extends TeaModel {
    @NameInMap("userId")
    public String userId;

    public static QueryPaymentRecallFileVTwoRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryPaymentRecallFileVTwoRequest self = new QueryPaymentRecallFileVTwoRequest();
        return TeaModel.build(map, self);
    }

    public QueryPaymentRecallFileVTwoRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
