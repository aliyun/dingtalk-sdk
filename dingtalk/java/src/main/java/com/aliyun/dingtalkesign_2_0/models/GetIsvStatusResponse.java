// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_2_0.models;

import com.aliyun.tea.*;

public class GetIsvStatusResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetIsvStatusResponseBody body;

    public static GetIsvStatusResponse build(java.util.Map<String, ?> map) throws Exception {
        GetIsvStatusResponse self = new GetIsvStatusResponse();
        return TeaModel.build(map, self);
    }

    public GetIsvStatusResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetIsvStatusResponse setBody(GetIsvStatusResponseBody body) {
        this.body = body;
        return this;
    }
    public GetIsvStatusResponseBody getBody() {
        return this.body;
    }

}
