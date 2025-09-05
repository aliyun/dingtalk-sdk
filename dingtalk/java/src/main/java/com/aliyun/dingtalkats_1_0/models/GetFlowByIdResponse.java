// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class GetFlowByIdResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetFlowByIdResponseBody body;

    public static GetFlowByIdResponse build(java.util.Map<String, ?> map) throws Exception {
        GetFlowByIdResponse self = new GetFlowByIdResponse();
        return TeaModel.build(map, self);
    }

    public GetFlowByIdResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetFlowByIdResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetFlowByIdResponse setBody(GetFlowByIdResponseBody body) {
        this.body = body;
        return this;
    }
    public GetFlowByIdResponseBody getBody() {
        return this.body;
    }

}
