// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkgroup_blackboard_1_0.models;

import com.aliyun.tea.*;

public class DeleteGroupBlackboardResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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

    public DeleteGroupBlackboardResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DeleteGroupBlackboardResponse setBody(DeleteGroupBlackboardResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteGroupBlackboardResponseBody getBody() {
        return this.body;
    }

}
