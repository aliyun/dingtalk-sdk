// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class GetInnerAppInfoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetInnerAppInfoResponseBody body;

    public static GetInnerAppInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        GetInnerAppInfoResponse self = new GetInnerAppInfoResponse();
        return TeaModel.build(map, self);
    }

    public GetInnerAppInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetInnerAppInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetInnerAppInfoResponse setBody(GetInnerAppInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public GetInnerAppInfoResponseBody getBody() {
        return this.body;
    }

}
