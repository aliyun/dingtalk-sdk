// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetSimpleCubeModelListResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public GetSimpleCubeModelListResponseBody body;

    public static GetSimpleCubeModelListResponse build(java.util.Map<String, ?> map) throws Exception {
        GetSimpleCubeModelListResponse self = new GetSimpleCubeModelListResponse();
        return TeaModel.build(map, self);
    }

    public GetSimpleCubeModelListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetSimpleCubeModelListResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetSimpleCubeModelListResponse setBody(GetSimpleCubeModelListResponseBody body) {
        this.body = body;
        return this;
    }
    public GetSimpleCubeModelListResponseBody getBody() {
        return this.body;
    }

}
