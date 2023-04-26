// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class ListRecycleItemsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public ListRecycleItemsResponseBody body;

    public static ListRecycleItemsResponse build(java.util.Map<String, ?> map) throws Exception {
        ListRecycleItemsResponse self = new ListRecycleItemsResponse();
        return TeaModel.build(map, self);
    }

    public ListRecycleItemsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListRecycleItemsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListRecycleItemsResponse setBody(ListRecycleItemsResponseBody body) {
        this.body = body;
        return this;
    }
    public ListRecycleItemsResponseBody getBody() {
        return this.body;
    }

}
