// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class UpdateCustomRobotOutgoingResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateCustomRobotOutgoingResponseBody body;

    public static UpdateCustomRobotOutgoingResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateCustomRobotOutgoingResponse self = new UpdateCustomRobotOutgoingResponse();
        return TeaModel.build(map, self);
    }

    public UpdateCustomRobotOutgoingResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateCustomRobotOutgoingResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateCustomRobotOutgoingResponse setBody(UpdateCustomRobotOutgoingResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateCustomRobotOutgoingResponseBody getBody() {
        return this.body;
    }

}
