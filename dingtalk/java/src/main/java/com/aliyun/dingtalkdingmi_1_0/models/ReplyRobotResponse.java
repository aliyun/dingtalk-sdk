// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdingmi_1_0.models;

import com.aliyun.tea.*;

public class ReplyRobotResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public ReplyRobotResponseBody body;

    public static ReplyRobotResponse build(java.util.Map<String, ?> map) throws Exception {
        ReplyRobotResponse self = new ReplyRobotResponse();
        return TeaModel.build(map, self);
    }

    public ReplyRobotResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ReplyRobotResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ReplyRobotResponse setBody(ReplyRobotResponseBody body) {
        this.body = body;
        return this;
    }
    public ReplyRobotResponseBody getBody() {
        return this.body;
    }

}
