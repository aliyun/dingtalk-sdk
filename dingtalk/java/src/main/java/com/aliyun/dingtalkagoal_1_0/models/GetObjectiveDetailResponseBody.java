// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class GetObjectiveDetailResponseBody extends TeaModel {
    @NameInMap("content")
    public OpenAgoalObjectiveDTO content;

    @NameInMap("requestId")
    public String requestId;

    @NameInMap("success")
    public Boolean success;

    public static GetObjectiveDetailResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetObjectiveDetailResponseBody self = new GetObjectiveDetailResponseBody();
        return TeaModel.build(map, self);
    }

    public GetObjectiveDetailResponseBody setContent(OpenAgoalObjectiveDTO content) {
        this.content = content;
        return this;
    }
    public OpenAgoalObjectiveDTO getContent() {
        return this.content;
    }

    public GetObjectiveDetailResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public GetObjectiveDetailResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
