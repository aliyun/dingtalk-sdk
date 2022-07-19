// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class DeleteRecycleItemsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public DeleteRecycleItemsResponse setBody(DeleteRecycleItemsResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteRecycleItemsResponseBody getBody() {
        return this.body;
    }

}
