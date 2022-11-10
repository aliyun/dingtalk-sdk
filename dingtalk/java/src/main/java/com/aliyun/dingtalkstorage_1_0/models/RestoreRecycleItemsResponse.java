// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class RestoreRecycleItemsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public RestoreRecycleItemsResponseBody body;

    public static RestoreRecycleItemsResponse build(java.util.Map<String, ?> map) throws Exception {
        RestoreRecycleItemsResponse self = new RestoreRecycleItemsResponse();
        return TeaModel.build(map, self);
    }

    public RestoreRecycleItemsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public RestoreRecycleItemsResponse setBody(RestoreRecycleItemsResponseBody body) {
        this.body = body;
        return this;
    }
    public RestoreRecycleItemsResponseBody getBody() {
        return this.body;
    }

}
