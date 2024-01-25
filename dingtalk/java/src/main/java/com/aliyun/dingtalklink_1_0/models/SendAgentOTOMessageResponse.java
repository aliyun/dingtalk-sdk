// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklink_1_0.models;

import com.aliyun.tea.*;

public class SendAgentOTOMessageResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SendAgentOTOMessageResponseBody body;

    public static SendAgentOTOMessageResponse build(java.util.Map<String, ?> map) throws Exception {
        SendAgentOTOMessageResponse self = new SendAgentOTOMessageResponse();
        return TeaModel.build(map, self);
    }

    public SendAgentOTOMessageResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SendAgentOTOMessageResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SendAgentOTOMessageResponse setBody(SendAgentOTOMessageResponseBody body) {
        this.body = body;
        return this;
    }
    public SendAgentOTOMessageResponseBody getBody() {
        return this.body;
    }

}
