// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class DeleteDentryAppPropertiesResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DeleteDentryAppPropertiesResponseBody body;

    public static DeleteDentryAppPropertiesResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteDentryAppPropertiesResponse self = new DeleteDentryAppPropertiesResponse();
        return TeaModel.build(map, self);
    }

    public DeleteDentryAppPropertiesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeleteDentryAppPropertiesResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DeleteDentryAppPropertiesResponse setBody(DeleteDentryAppPropertiesResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteDentryAppPropertiesResponseBody getBody() {
        return this.body;
    }

}
