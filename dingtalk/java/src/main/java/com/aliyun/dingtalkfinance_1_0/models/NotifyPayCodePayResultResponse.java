// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class NotifyPayCodePayResultResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public NotifyPayCodePayResultResponseBody body;

    public static NotifyPayCodePayResultResponse build(java.util.Map<String, ?> map) throws Exception {
        NotifyPayCodePayResultResponse self = new NotifyPayCodePayResultResponse();
        return TeaModel.build(map, self);
    }

    public NotifyPayCodePayResultResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public NotifyPayCodePayResultResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public NotifyPayCodePayResultResponse setBody(NotifyPayCodePayResultResponseBody body) {
        this.body = body;
        return this;
    }
    public NotifyPayCodePayResultResponseBody getBody() {
        return this.body;
    }

}
