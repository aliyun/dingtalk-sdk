// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksearch_1_0.models;

import com.aliyun.tea.*;

public class GetSearchTabResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetSearchTabResponseBody body;

    public static GetSearchTabResponse build(java.util.Map<String, ?> map) throws Exception {
        GetSearchTabResponse self = new GetSearchTabResponse();
        return TeaModel.build(map, self);
    }

    public GetSearchTabResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetSearchTabResponse setBody(GetSearchTabResponseBody body) {
        this.body = body;
        return this;
    }
    public GetSearchTabResponseBody getBody() {
        return this.body;
    }

}
