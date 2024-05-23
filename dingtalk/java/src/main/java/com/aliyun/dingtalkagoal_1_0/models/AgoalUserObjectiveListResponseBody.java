// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class AgoalUserObjectiveListResponseBody extends TeaModel {
    @NameInMap("content")
    public java.util.List<OpenAgoalObjectiveDTO> content;

    @NameInMap("requestId")
    public String requestId;

    @NameInMap("success")
    public Boolean success;

    public static AgoalUserObjectiveListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AgoalUserObjectiveListResponseBody self = new AgoalUserObjectiveListResponseBody();
        return TeaModel.build(map, self);
    }

    public AgoalUserObjectiveListResponseBody setContent(java.util.List<OpenAgoalObjectiveDTO> content) {
        this.content = content;
        return this;
    }
    public java.util.List<OpenAgoalObjectiveDTO> getContent() {
        return this.content;
    }

    public AgoalUserObjectiveListResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public AgoalUserObjectiveListResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
