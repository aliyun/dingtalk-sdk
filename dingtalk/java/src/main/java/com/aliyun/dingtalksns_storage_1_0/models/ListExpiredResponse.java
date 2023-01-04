// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksns_storage_1_0.models;

import com.aliyun.tea.*;

public class ListExpiredResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ListExpiredResponseBody body;

    public static ListExpiredResponse build(java.util.Map<String, ?> map) throws Exception {
        ListExpiredResponse self = new ListExpiredResponse();
        return TeaModel.build(map, self);
    }

    public ListExpiredResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListExpiredResponse setBody(ListExpiredResponseBody body) {
        this.body = body;
        return this;
    }
    public ListExpiredResponseBody getBody() {
        return this.body;
    }

}
