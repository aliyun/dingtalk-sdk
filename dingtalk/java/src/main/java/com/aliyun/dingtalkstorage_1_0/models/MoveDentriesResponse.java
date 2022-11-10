// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class MoveDentriesResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public MoveDentriesResponseBody body;

    public static MoveDentriesResponse build(java.util.Map<String, ?> map) throws Exception {
        MoveDentriesResponse self = new MoveDentriesResponse();
        return TeaModel.build(map, self);
    }

    public MoveDentriesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public MoveDentriesResponse setBody(MoveDentriesResponseBody body) {
        this.body = body;
        return this;
    }
    public MoveDentriesResponseBody getBody() {
        return this.body;
    }

}
