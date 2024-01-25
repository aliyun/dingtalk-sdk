// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class DeleteRecycleItemsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DeleteRecycleItemsResponseBody body;

    public static DeleteRecycleItemsResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteRecycleItemsResponse self = new DeleteRecycleItemsResponse();
        return TeaModel.build(map, self);
    }

    public DeleteRecycleItemsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeleteRecycleItemsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DeleteRecycleItemsResponse setBody(DeleteRecycleItemsResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteRecycleItemsResponseBody getBody() {
        return this.body;
    }

}
