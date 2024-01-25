// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class GetRecycleItemResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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

    public GetRecycleItemResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetRecycleItemResponse setBody(GetRecycleItemResponseBody body) {
        this.body = body;
        return this;
    }
    public GetRecycleItemResponseBody getBody() {
        return this.body;
    }

}
