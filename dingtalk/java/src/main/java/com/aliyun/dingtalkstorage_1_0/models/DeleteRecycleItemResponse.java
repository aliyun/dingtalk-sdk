// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class DeleteRecycleItemResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
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
