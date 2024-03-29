// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkgroup_blackboard_1_0.models;

import com.aliyun.tea.*;

public class CreateGroupBlackboardResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreateGroupBlackboardResponseBody body;

    public static CreateGroupBlackboardResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateGroupBlackboardResponse self = new CreateGroupBlackboardResponse();
        return TeaModel.build(map, self);
    }

    public CreateGroupBlackboardResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateGroupBlackboardResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateGroupBlackboardResponse setBody(CreateGroupBlackboardResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateGroupBlackboardResponseBody getBody() {
        return this.body;
    }

}
