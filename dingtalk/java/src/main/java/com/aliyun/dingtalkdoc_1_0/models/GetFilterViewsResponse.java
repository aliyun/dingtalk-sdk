// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class GetFilterViewsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetFilterViewsResponseBody body;

    public static GetFilterViewsResponse build(java.util.Map<String, ?> map) throws Exception {
        GetFilterViewsResponse self = new GetFilterViewsResponse();
        return TeaModel.build(map, self);
    }

    public GetFilterViewsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetFilterViewsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetFilterViewsResponse setBody(GetFilterViewsResponseBody body) {
        this.body = body;
        return this;
    }
    public GetFilterViewsResponseBody getBody() {
        return this.body;
    }

}
