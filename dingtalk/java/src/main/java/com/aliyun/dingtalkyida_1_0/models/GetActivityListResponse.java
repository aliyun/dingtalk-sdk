// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetActivityListResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetActivityListResponseBody body;

    public static GetActivityListResponse build(java.util.Map<String, ?> map) throws Exception {
        GetActivityListResponse self = new GetActivityListResponse();
        return TeaModel.build(map, self);
    }

    public GetActivityListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetActivityListResponse setBody(GetActivityListResponseBody body) {
        this.body = body;
        return this;
    }
    public GetActivityListResponseBody getBody() {
        return this.body;
    }

}
