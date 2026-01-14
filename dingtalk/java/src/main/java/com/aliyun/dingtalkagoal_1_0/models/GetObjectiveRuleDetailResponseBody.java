// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class GetObjectiveRuleDetailResponseBody extends TeaModel {
    @NameInMap("content")
    public OpenObjectiveRuleDTO content;

    @NameInMap("requestId")
    public String requestId;

    @NameInMap("success")
    public Boolean success;

    public static GetObjectiveRuleDetailResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetObjectiveRuleDetailResponseBody self = new GetObjectiveRuleDetailResponseBody();
        return TeaModel.build(map, self);
    }

    public GetObjectiveRuleDetailResponseBody setContent(OpenObjectiveRuleDTO content) {
        this.content = content;
        return this;
    }
    public OpenObjectiveRuleDTO getContent() {
        return this.content;
    }

    public GetObjectiveRuleDetailResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public GetObjectiveRuleDetailResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
