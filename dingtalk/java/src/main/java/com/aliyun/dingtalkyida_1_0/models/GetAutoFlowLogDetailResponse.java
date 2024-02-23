// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetAutoFlowLogDetailResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetAutoFlowLogDetailResponseBody body;

    public static GetAutoFlowLogDetailResponse build(java.util.Map<String, ?> map) throws Exception {
        GetAutoFlowLogDetailResponse self = new GetAutoFlowLogDetailResponse();
        return TeaModel.build(map, self);
    }

    public GetAutoFlowLogDetailResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetAutoFlowLogDetailResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetAutoFlowLogDetailResponse setBody(GetAutoFlowLogDetailResponseBody body) {
        this.body = body;
        return this;
    }
    public GetAutoFlowLogDetailResponseBody getBody() {
        return this.body;
    }

}
