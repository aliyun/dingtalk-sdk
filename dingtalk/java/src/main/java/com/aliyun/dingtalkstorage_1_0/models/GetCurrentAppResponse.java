// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class GetCurrentAppResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetCurrentAppResponseBody body;

    public static GetCurrentAppResponse build(java.util.Map<String, ?> map) throws Exception {
        GetCurrentAppResponse self = new GetCurrentAppResponse();
        return TeaModel.build(map, self);
    }

    public GetCurrentAppResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetCurrentAppResponse setBody(GetCurrentAppResponseBody body) {
        this.body = body;
        return this;
    }
    public GetCurrentAppResponseBody getBody() {
        return this.body;
    }

}
