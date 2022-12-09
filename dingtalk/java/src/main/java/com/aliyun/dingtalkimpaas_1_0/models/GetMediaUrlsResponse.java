// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkimpaas_1_0.models;

import com.aliyun.tea.*;

public class GetMediaUrlsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetMediaUrlsResponseBody body;

    public static GetMediaUrlsResponse build(java.util.Map<String, ?> map) throws Exception {
        GetMediaUrlsResponse self = new GetMediaUrlsResponse();
        return TeaModel.build(map, self);
    }

    public GetMediaUrlsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetMediaUrlsResponse setBody(GetMediaUrlsResponseBody body) {
        this.body = body;
        return this;
    }
    public GetMediaUrlsResponseBody getBody() {
        return this.body;
    }

}
