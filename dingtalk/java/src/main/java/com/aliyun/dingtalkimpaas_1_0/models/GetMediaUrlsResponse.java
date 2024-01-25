// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkimpaas_1_0.models;

import com.aliyun.tea.*;

public class GetMediaUrlsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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

    public GetMediaUrlsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetMediaUrlsResponse setBody(GetMediaUrlsResponseBody body) {
        this.body = body;
        return this;
    }
    public GetMediaUrlsResponseBody getBody() {
        return this.body;
    }

}
