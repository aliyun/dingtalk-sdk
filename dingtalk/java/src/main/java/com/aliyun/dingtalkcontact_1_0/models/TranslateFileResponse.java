// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class TranslateFileResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public TranslateFileResponseBody body;

    public static TranslateFileResponse build(java.util.Map<String, ?> map) throws Exception {
        TranslateFileResponse self = new TranslateFileResponse();
        return TeaModel.build(map, self);
    }

    public TranslateFileResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public TranslateFileResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public TranslateFileResponse setBody(TranslateFileResponseBody body) {
        this.body = body;
        return this;
    }
    public TranslateFileResponseBody getBody() {
        return this.body;
    }

}
