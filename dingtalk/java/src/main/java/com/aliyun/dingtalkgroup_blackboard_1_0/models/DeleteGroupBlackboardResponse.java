// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkgroup_blackboard_1_0.models;

import com.aliyun.tea.*;

public class DeleteGroupBlackboardResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public DeleteGroupBlackboardResponseBody body;

    public static DeleteGroupBlackboardResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteGroupBlackboardResponse self = new DeleteGroupBlackboardResponse();
        return TeaModel.build(map, self);
    }

    public DeleteGroupBlackboardResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeleteGroupBlackboardResponse setBody(DeleteGroupBlackboardResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteGroupBlackboardResponseBody getBody() {
        return this.body;
    }

}
