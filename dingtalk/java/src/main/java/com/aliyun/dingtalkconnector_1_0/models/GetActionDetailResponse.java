// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconnector_1_0.models;

import com.aliyun.tea.*;

public class GetActionDetailResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public GetActionDetailResponseBody body;

    public static GetActionDetailResponse build(java.util.Map<String, ?> map) throws Exception {
        GetActionDetailResponse self = new GetActionDetailResponse();
        return TeaModel.build(map, self);
    }

    public GetActionDetailResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetActionDetailResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetActionDetailResponse setBody(GetActionDetailResponseBody body) {
        this.body = body;
        return this;
    }
    public GetActionDetailResponseBody getBody() {
        return this.body;
    }

}
