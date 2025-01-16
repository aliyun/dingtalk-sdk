// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class AgoalOrgObjectiveQueryResponseBody extends TeaModel {
    @NameInMap("content")
    public OpenAgoalOrgObjectiveDTO content;

    @NameInMap("requestId")
    public String requestId;

    @NameInMap("success")
    public Boolean success;

    public static AgoalOrgObjectiveQueryResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AgoalOrgObjectiveQueryResponseBody self = new AgoalOrgObjectiveQueryResponseBody();
        return TeaModel.build(map, self);
    }

    public AgoalOrgObjectiveQueryResponseBody setContent(OpenAgoalOrgObjectiveDTO content) {
        this.content = content;
        return this;
    }
    public OpenAgoalOrgObjectiveDTO getContent() {
        return this.content;
    }

    public AgoalOrgObjectiveQueryResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public AgoalOrgObjectiveQueryResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
