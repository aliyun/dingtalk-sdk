// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksearch_1_0.models;

import com.aliyun.tea.*;

public class GetSearchItemResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetSearchItemResponseBody body;

    public static GetSearchItemResponse build(java.util.Map<String, ?> map) throws Exception {
        GetSearchItemResponse self = new GetSearchItemResponse();
        return TeaModel.build(map, self);
    }

    public GetSearchItemResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetSearchItemResponse setBody(GetSearchItemResponseBody body) {
        this.body = body;
        return this;
    }
    public GetSearchItemResponseBody getBody() {
        return this.body;
    }

}
