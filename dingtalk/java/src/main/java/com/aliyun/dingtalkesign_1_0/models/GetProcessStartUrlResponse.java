// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_1_0.models;

import com.aliyun.tea.*;

public class GetProcessStartUrlResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetProcessStartUrlResponseBody body;

    public static GetProcessStartUrlResponse build(java.util.Map<String, ?> map) throws Exception {
        GetProcessStartUrlResponse self = new GetProcessStartUrlResponse();
        return TeaModel.build(map, self);
    }

    public GetProcessStartUrlResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetProcessStartUrlResponse setBody(GetProcessStartUrlResponseBody body) {
        this.body = body;
        return this;
    }
    public GetProcessStartUrlResponseBody getBody() {
        return this.body;
    }

}
