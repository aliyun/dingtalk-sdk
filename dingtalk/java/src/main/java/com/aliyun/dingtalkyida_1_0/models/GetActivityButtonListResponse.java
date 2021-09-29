// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetActivityButtonListResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetActivityButtonListResponseBody body;

    public static GetActivityButtonListResponse build(java.util.Map<String, ?> map) throws Exception {
        GetActivityButtonListResponse self = new GetActivityButtonListResponse();
        return TeaModel.build(map, self);
    }

    public GetActivityButtonListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetActivityButtonListResponse setBody(GetActivityButtonListResponseBody body) {
        this.body = body;
        return this;
    }
    public GetActivityButtonListResponseBody getBody() {
        return this.body;
    }

}
