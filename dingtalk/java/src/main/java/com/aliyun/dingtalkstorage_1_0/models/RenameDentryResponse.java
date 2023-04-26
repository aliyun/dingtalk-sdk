// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class RenameDentryResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public RenameDentryResponseBody body;

    public static RenameDentryResponse build(java.util.Map<String, ?> map) throws Exception {
        RenameDentryResponse self = new RenameDentryResponse();
        return TeaModel.build(map, self);
    }

    public RenameDentryResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public RenameDentryResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public RenameDentryResponse setBody(RenameDentryResponseBody body) {
        this.body = body;
        return this;
    }
    public RenameDentryResponseBody getBody() {
        return this.body;
    }

}
