// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_1_0.models;

import com.aliyun.tea.*;

public class GetFlowSignDetailResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetFlowSignDetailResponseBody body;

    public static GetFlowSignDetailResponse build(java.util.Map<String, ?> map) throws Exception {
        GetFlowSignDetailResponse self = new GetFlowSignDetailResponse();
        return TeaModel.build(map, self);
    }

    public GetFlowSignDetailResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetFlowSignDetailResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetFlowSignDetailResponse setBody(GetFlowSignDetailResponseBody body) {
        this.body = body;
        return this;
    }
    public GetFlowSignDetailResponseBody getBody() {
        return this.body;
    }

}
