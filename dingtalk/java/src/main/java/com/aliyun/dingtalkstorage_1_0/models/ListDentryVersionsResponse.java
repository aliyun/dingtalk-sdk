// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class ListDentryVersionsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public ListDentryVersionsResponse setBody(ListDentryVersionsResponseBody body) {
        this.body = body;
        return this;
    }
    public ListDentryVersionsResponseBody getBody() {
        return this.body;
    }

}
