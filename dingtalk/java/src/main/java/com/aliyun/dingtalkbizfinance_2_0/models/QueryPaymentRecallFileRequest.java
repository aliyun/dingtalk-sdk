// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class QueryPaymentRecallFileRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>504</p>
     */
    @NameInMap("userId")
    public String userId;

    public static QueryPaymentRecallFileRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryPaymentRecallFileRequest self = new QueryPaymentRecallFileRequest();
        return TeaModel.build(map, self);
    }

    public QueryPaymentRecallFileRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
