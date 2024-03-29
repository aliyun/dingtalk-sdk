// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class NotifyAuthorizationResultResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public NotifyAuthorizationResultResponseBody body;

    public static NotifyAuthorizationResultResponse build(java.util.Map<String, ?> map) throws Exception {
        NotifyAuthorizationResultResponse self = new NotifyAuthorizationResultResponse();
        return TeaModel.build(map, self);
    }

    public NotifyAuthorizationResultResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public NotifyAuthorizationResultResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public NotifyAuthorizationResultResponse setBody(NotifyAuthorizationResultResponseBody body) {
        this.body = body;
        return this;
    }
    public NotifyAuthorizationResultResponseBody getBody() {
        return this.body;
    }

}
