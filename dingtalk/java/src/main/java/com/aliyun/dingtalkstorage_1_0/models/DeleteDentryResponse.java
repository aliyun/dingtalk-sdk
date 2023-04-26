// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class DeleteDentryResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public DeleteDentryResponseBody body;

    public static DeleteDentryResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteDentryResponse self = new DeleteDentryResponse();
        return TeaModel.build(map, self);
    }

    public DeleteDentryResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeleteDentryResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DeleteDentryResponse setBody(DeleteDentryResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteDentryResponseBody getBody() {
        return this.body;
    }

}
