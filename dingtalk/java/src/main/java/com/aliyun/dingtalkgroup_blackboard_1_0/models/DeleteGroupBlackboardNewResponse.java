// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkgroup_blackboard_1_0.models;

import com.aliyun.tea.*;

public class DeleteGroupBlackboardNewResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DeleteGroupBlackboardNewResponseBody body;

    public static DeleteGroupBlackboardNewResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteGroupBlackboardNewResponse self = new DeleteGroupBlackboardNewResponse();
        return TeaModel.build(map, self);
    }

    public DeleteGroupBlackboardNewResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeleteGroupBlackboardNewResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DeleteGroupBlackboardNewResponse setBody(DeleteGroupBlackboardNewResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteGroupBlackboardNewResponseBody getBody() {
        return this.body;
    }

}
