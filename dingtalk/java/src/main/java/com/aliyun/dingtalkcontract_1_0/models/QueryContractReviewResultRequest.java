// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class QueryContractReviewResultRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("requestId")
    public String requestId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("reviewTaskId")
    public String reviewTaskId;

    public static QueryContractReviewResultRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryContractReviewResultRequest self = new QueryContractReviewResultRequest();
        return TeaModel.build(map, self);
    }

    public QueryContractReviewResultRequest setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public QueryContractReviewResultRequest setReviewTaskId(String reviewTaskId) {
        this.reviewTaskId = reviewTaskId;
        return this;
    }
    public String getReviewTaskId() {
        return this.reviewTaskId;
    }

}
