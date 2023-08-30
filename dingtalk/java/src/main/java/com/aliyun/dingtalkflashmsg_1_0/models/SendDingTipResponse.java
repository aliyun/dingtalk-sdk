// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkflashmsg_1_0.models;

import com.aliyun.tea.*;

public class SendDingTipResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public SendDingTipResponseBody body;

    public static SendDingTipResponse build(java.util.Map<String, ?> map) throws Exception {
        SendDingTipResponse self = new SendDingTipResponse();
        return TeaModel.build(map, self);
    }

    public SendDingTipResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SendDingTipResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SendDingTipResponse setBody(SendDingTipResponseBody body) {
        this.body = body;
        return this;
    }
    public SendDingTipResponseBody getBody() {
        return this.body;
    }

}
