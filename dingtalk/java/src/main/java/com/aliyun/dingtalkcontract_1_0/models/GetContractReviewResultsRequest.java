// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class GetContractReviewResultsRequest extends TeaModel {
    @NameInMap("review_id")
    public String reviewId;

    @NameInMap("session_id")
    public String sessionId;

    public static GetContractReviewResultsRequest build(java.util.Map<String, ?> map) throws Exception {
        GetContractReviewResultsRequest self = new GetContractReviewResultsRequest();
        return TeaModel.build(map, self);
    }

    public GetContractReviewResultsRequest setReviewId(String reviewId) {
        this.reviewId = reviewId;
        return this;
    }
    public String getReviewId() {
        return this.reviewId;
    }

    public GetContractReviewResultsRequest setSessionId(String sessionId) {
        this.sessionId = sessionId;
        return this;
    }
    public String getSessionId() {
        return this.sessionId;
    }

}
