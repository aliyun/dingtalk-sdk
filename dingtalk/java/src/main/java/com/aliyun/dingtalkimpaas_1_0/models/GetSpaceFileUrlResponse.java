// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkimpaas_1_0.models;

import com.aliyun.tea.*;

public class GetSpaceFileUrlResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetSpaceFileUrlResponseBody body;

    public static GetSpaceFileUrlResponse build(java.util.Map<String, ?> map) throws Exception {
        GetSpaceFileUrlResponse self = new GetSpaceFileUrlResponse();
        return TeaModel.build(map, self);
    }

    public GetSpaceFileUrlResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetSpaceFileUrlResponse setBody(GetSpaceFileUrlResponseBody body) {
        this.body = body;
        return this;
    }
    public GetSpaceFileUrlResponseBody getBody() {
        return this.body;
    }

}
