// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class AgoalCreateProgressResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("content")
    public OpenAgoalProgressDTO content;

    @NameInMap("requestId")
    public String requestId;

    @NameInMap("success")
    public Boolean success;

    public static AgoalCreateProgressResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AgoalCreateProgressResponseBody self = new AgoalCreateProgressResponseBody();
        return TeaModel.build(map, self);
    }

    public AgoalCreateProgressResponseBody setContent(OpenAgoalProgressDTO content) {
        this.content = content;
        return this;
    }
    public OpenAgoalProgressDTO getContent() {
        return this.content;
    }

    public AgoalCreateProgressResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public AgoalCreateProgressResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
