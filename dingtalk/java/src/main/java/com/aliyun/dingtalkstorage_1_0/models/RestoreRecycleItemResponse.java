// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class RestoreRecycleItemResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public RestoreRecycleItemResponseBody body;

    public static RestoreRecycleItemResponse build(java.util.Map<String, ?> map) throws Exception {
        RestoreRecycleItemResponse self = new RestoreRecycleItemResponse();
        return TeaModel.build(map, self);
    }

    public RestoreRecycleItemResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public RestoreRecycleItemResponse setBody(RestoreRecycleItemResponseBody body) {
        this.body = body;
        return this;
    }
    public RestoreRecycleItemResponseBody getBody() {
        return this.body;
    }

}
