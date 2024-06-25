// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class AgoalSendMessageResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("content")
    public Boolean content;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>7478B23C-80E8-1AD6-BE8C-09D480E0xxxx</p>
     */
    @NameInMap("requestId")
    public String requestId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static AgoalSendMessageResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AgoalSendMessageResponseBody self = new AgoalSendMessageResponseBody();
        return TeaModel.build(map, self);
    }

    public AgoalSendMessageResponseBody setContent(Boolean content) {
        this.content = content;
        return this;
    }
    public Boolean getContent() {
        return this.content;
    }

    public AgoalSendMessageResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public AgoalSendMessageResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
