// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class GetConvertResultResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetConvertResultResponseBody body;

    public static GetConvertResultResponse build(java.util.Map<String, ?> map) throws Exception {
        GetConvertResultResponse self = new GetConvertResultResponse();
        return TeaModel.build(map, self);
    }

    public GetConvertResultResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetConvertResultResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetConvertResultResponse setBody(GetConvertResultResponseBody body) {
        this.body = body;
        return this;
    }
    public GetConvertResultResponseBody getBody() {
        return this.body;
    }

}
