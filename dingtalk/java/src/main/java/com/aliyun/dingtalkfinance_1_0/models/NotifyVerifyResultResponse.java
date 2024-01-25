// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class NotifyVerifyResultResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public NotifyVerifyResultResponseBody body;

    public static NotifyVerifyResultResponse build(java.util.Map<String, ?> map) throws Exception {
        NotifyVerifyResultResponse self = new NotifyVerifyResultResponse();
        return TeaModel.build(map, self);
    }

    public NotifyVerifyResultResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public NotifyVerifyResultResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public NotifyVerifyResultResponse setBody(NotifyVerifyResultResponseBody body) {
        this.body = body;
        return this;
    }
    public NotifyVerifyResultResponseBody getBody() {
        return this.body;
    }

}
