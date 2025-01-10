// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class AgoalFieldUpdateResponseBody extends TeaModel {
    @NameInMap("content")
    public Boolean content;

    @NameInMap("requestId")
    public String requestId;

    @NameInMap("success")
    public String success;

    public static AgoalFieldUpdateResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AgoalFieldUpdateResponseBody self = new AgoalFieldUpdateResponseBody();
        return TeaModel.build(map, self);
    }

    public AgoalFieldUpdateResponseBody setContent(Boolean content) {
        this.content = content;
        return this;
    }
    public Boolean getContent() {
        return this.content;
    }

    public AgoalFieldUpdateResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public AgoalFieldUpdateResponseBody setSuccess(String success) {
        this.success = success;
        return this;
    }
    public String getSuccess() {
        return this.success;
    }

}
