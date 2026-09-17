// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class GetContractReviewStatusRequest extends TeaModel {
    @NameInMap("review_id")
    public String reviewId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("session_id")
    public String sessionId;

    public static GetContractReviewStatusRequest build(java.util.Map<String, ?> map) throws Exception {
        GetContractReviewStatusRequest self = new GetContractReviewStatusRequest();
        return TeaModel.build(map, self);
    }

    public GetContractReviewStatusRequest setReviewId(String reviewId) {
        this.reviewId = reviewId;
        return this;
    }
    public String getReviewId() {
        return this.reviewId;
    }

    public GetContractReviewStatusRequest setSessionId(String sessionId) {
        this.sessionId = sessionId;
        return this;
    }
    public String getSessionId() {
        return this.sessionId;
    }

}
