// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class DeleteRecycleItemResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DeleteRecycleItemResponseBody body;

    public static DeleteRecycleItemResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteRecycleItemResponse self = new DeleteRecycleItemResponse();
        return TeaModel.build(map, self);
    }

    public DeleteRecycleItemResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeleteRecycleItemResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DeleteRecycleItemResponse setBody(DeleteRecycleItemResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteRecycleItemResponseBody getBody() {
        return this.body;
    }

}
