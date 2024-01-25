// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class GetInnerAppResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetInnerAppResponseBody body;

    public static GetInnerAppResponse build(java.util.Map<String, ?> map) throws Exception {
        GetInnerAppResponse self = new GetInnerAppResponse();
        return TeaModel.build(map, self);
    }

    public GetInnerAppResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetInnerAppResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetInnerAppResponse setBody(GetInnerAppResponseBody body) {
        this.body = body;
        return this;
    }
    public GetInnerAppResponseBody getBody() {
        return this.body;
    }

}
