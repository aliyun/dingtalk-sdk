// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class SendServiceGroupMessageResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public SendServiceGroupMessageResponseBody body;

    public static SendServiceGroupMessageResponse build(java.util.Map<String, ?> map) throws Exception {
        SendServiceGroupMessageResponse self = new SendServiceGroupMessageResponse();
        return TeaModel.build(map, self);
    }

    public SendServiceGroupMessageResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SendServiceGroupMessageResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SendServiceGroupMessageResponse setBody(SendServiceGroupMessageResponseBody body) {
        this.body = body;
        return this;
    }
    public SendServiceGroupMessageResponseBody getBody() {
        return this.body;
    }

}
