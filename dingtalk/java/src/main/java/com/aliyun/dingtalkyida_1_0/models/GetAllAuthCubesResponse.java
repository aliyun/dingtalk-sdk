// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetAllAuthCubesResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetAllAuthCubesResponseBody body;

    public static GetAllAuthCubesResponse build(java.util.Map<String, ?> map) throws Exception {
        GetAllAuthCubesResponse self = new GetAllAuthCubesResponse();
        return TeaModel.build(map, self);
    }

    public GetAllAuthCubesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetAllAuthCubesResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetAllAuthCubesResponse setBody(GetAllAuthCubesResponseBody body) {
        this.body = body;
        return this;
    }
    public GetAllAuthCubesResponseBody getBody() {
        return this.body;
    }

}
