// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdingmi_1_0.models;

import com.aliyun.tea.*;

public class AskRobotResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AskRobotResponseBody body;

    public static AskRobotResponse build(java.util.Map<String, ?> map) throws Exception {
        AskRobotResponse self = new AskRobotResponse();
        return TeaModel.build(map, self);
    }

    public AskRobotResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AskRobotResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AskRobotResponse setBody(AskRobotResponseBody body) {
        this.body = body;
        return this;
    }
    public AskRobotResponseBody getBody() {
        return this.body;
    }

}
