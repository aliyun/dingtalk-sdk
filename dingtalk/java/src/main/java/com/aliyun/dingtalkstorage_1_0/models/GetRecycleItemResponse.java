// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class GetRecycleItemResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetRecycleItemResponseBody body;

    public static GetRecycleItemResponse build(java.util.Map<String, ?> map) throws Exception {
        GetRecycleItemResponse self = new GetRecycleItemResponse();
        return TeaModel.build(map, self);
    }

    public GetRecycleItemResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetRecycleItemResponse setBody(GetRecycleItemResponseBody body) {
        this.body = body;
        return this;
    }
    public GetRecycleItemResponseBody getBody() {
        return this.body;
    }

}