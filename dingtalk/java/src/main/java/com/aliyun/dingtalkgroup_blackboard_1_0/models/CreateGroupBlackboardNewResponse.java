// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkgroup_blackboard_1_0.models;

import com.aliyun.tea.*;

public class CreateGroupBlackboardNewResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreateGroupBlackboardNewResponseBody body;

    public static CreateGroupBlackboardNewResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateGroupBlackboardNewResponse self = new CreateGroupBlackboardNewResponse();
        return TeaModel.build(map, self);
    }

    public CreateGroupBlackboardNewResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateGroupBlackboardNewResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateGroupBlackboardNewResponse setBody(CreateGroupBlackboardNewResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateGroupBlackboardNewResponseBody getBody() {
        return this.body;
    }

}
