// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksns_storage_1_0.models;

import com.aliyun.tea.*;

public class ListDentriesResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ListDentriesResponseBody body;

    public static ListDentriesResponse build(java.util.Map<String, ?> map) throws Exception {
        ListDentriesResponse self = new ListDentriesResponse();
        return TeaModel.build(map, self);
    }

    public ListDentriesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListDentriesResponse setBody(ListDentriesResponseBody body) {
        this.body = body;
        return this;
    }
    public ListDentriesResponseBody getBody() {
        return this.body;
    }

}
