// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class RevertDentryVersionResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public RevertDentryVersionResponseBody body;

    public static RevertDentryVersionResponse build(java.util.Map<String, ?> map) throws Exception {
        RevertDentryVersionResponse self = new RevertDentryVersionResponse();
        return TeaModel.build(map, self);
    }

    public RevertDentryVersionResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public RevertDentryVersionResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public RevertDentryVersionResponse setBody(RevertDentryVersionResponseBody body) {
        this.body = body;
        return this;
    }
    public RevertDentryVersionResponseBody getBody() {
        return this.body;
    }

}
