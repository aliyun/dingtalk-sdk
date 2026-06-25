// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmcp_1_0.models;

import com.aliyun.tea.*;

public class GetMcpDetailResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetMcpDetailResponseBody body;

    public static GetMcpDetailResponse build(java.util.Map<String, ?> map) throws Exception {
        GetMcpDetailResponse self = new GetMcpDetailResponse();
        return TeaModel.build(map, self);
    }

    public GetMcpDetailResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetMcpDetailResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetMcpDetailResponse setBody(GetMcpDetailResponseBody body) {
        this.body = body;
        return this;
    }
    public GetMcpDetailResponseBody getBody() {
        return this.body;
    }

}
