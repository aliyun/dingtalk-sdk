// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class AgoalObjectiveKeyActionListResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("content")
    public java.util.List<OpenAgoalKeyActionDTO> content;

    @NameInMap("requestId")
    public String requestId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static AgoalObjectiveKeyActionListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AgoalObjectiveKeyActionListResponseBody self = new AgoalObjectiveKeyActionListResponseBody();
        return TeaModel.build(map, self);
    }

    public AgoalObjectiveKeyActionListResponseBody setContent(java.util.List<OpenAgoalKeyActionDTO> content) {
        this.content = content;
        return this;
    }
    public java.util.List<OpenAgoalKeyActionDTO> getContent() {
        return this.content;
    }

    public AgoalObjectiveKeyActionListResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public AgoalObjectiveKeyActionListResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
