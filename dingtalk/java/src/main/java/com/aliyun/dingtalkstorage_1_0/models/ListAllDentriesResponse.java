// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class ListAllDentriesResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ListAllDentriesResponseBody body;

    public static ListAllDentriesResponse build(java.util.Map<String, ?> map) throws Exception {
        ListAllDentriesResponse self = new ListAllDentriesResponse();
        return TeaModel.build(map, self);
    }

    public ListAllDentriesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListAllDentriesResponse setBody(ListAllDentriesResponseBody body) {
        this.body = body;
        return this;
    }
    public ListAllDentriesResponseBody getBody() {
        return this.body;
    }

}
