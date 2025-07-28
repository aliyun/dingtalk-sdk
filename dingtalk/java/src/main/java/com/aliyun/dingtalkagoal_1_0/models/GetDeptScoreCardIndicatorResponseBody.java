// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class GetDeptScoreCardIndicatorResponseBody extends TeaModel {
    @NameInMap("content")
    public OpenScoreCardDimensionDTO content;

    @NameInMap("requestId")
    public String requestId;

    @NameInMap("success")
    public Boolean success;

    public static GetDeptScoreCardIndicatorResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetDeptScoreCardIndicatorResponseBody self = new GetDeptScoreCardIndicatorResponseBody();
        return TeaModel.build(map, self);
    }

    public GetDeptScoreCardIndicatorResponseBody setContent(OpenScoreCardDimensionDTO content) {
        this.content = content;
        return this;
    }
    public OpenScoreCardDimensionDTO getContent() {
        return this.content;
    }

    public GetDeptScoreCardIndicatorResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public GetDeptScoreCardIndicatorResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
