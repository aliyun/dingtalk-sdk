// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class ListDentryVersionsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ListDentryVersionsResponseBody body;

    public static ListDentryVersionsResponse build(java.util.Map<String, ?> map) throws Exception {
        ListDentryVersionsResponse self = new ListDentryVersionsResponse();
        return TeaModel.build(map, self);
    }

    public ListDentryVersionsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListDentryVersionsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListDentryVersionsResponse setBody(ListDentryVersionsResponseBody body) {
        this.body = body;
        return this;
    }
    public ListDentryVersionsResponseBody getBody() {
        return this.body;
    }

}
