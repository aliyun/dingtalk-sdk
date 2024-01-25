// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class GetApaasAppResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetApaasAppResponseBody body;

    public static GetApaasAppResponse build(java.util.Map<String, ?> map) throws Exception {
        GetApaasAppResponse self = new GetApaasAppResponse();
        return TeaModel.build(map, self);
    }

    public GetApaasAppResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetApaasAppResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetApaasAppResponse setBody(GetApaasAppResponseBody body) {
        this.body = body;
        return this;
    }
    public GetApaasAppResponseBody getBody() {
        return this.body;
    }

}
