// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class AgoalOrgObjectiveListResponseBody extends TeaModel {
    @NameInMap("content")
    public OpenAgoalOrgObjectiveListDTO content;

    @NameInMap("requestId")
    public String requestId;

    @NameInMap("success")
    public Boolean success;

    public static AgoalOrgObjectiveListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AgoalOrgObjectiveListResponseBody self = new AgoalOrgObjectiveListResponseBody();
        return TeaModel.build(map, self);
    }

    public AgoalOrgObjectiveListResponseBody setContent(OpenAgoalOrgObjectiveListDTO content) {
        this.content = content;
        return this;
    }
    public OpenAgoalOrgObjectiveListDTO getContent() {
        return this.content;
    }

    public AgoalOrgObjectiveListResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public AgoalOrgObjectiveListResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
