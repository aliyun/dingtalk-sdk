// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class GetUserAppDevAccessResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public GetUserAppDevAccessResponseBody body;

    public static GetUserAppDevAccessResponse build(java.util.Map<String, ?> map) throws Exception {
        GetUserAppDevAccessResponse self = new GetUserAppDevAccessResponse();
        return TeaModel.build(map, self);
    }

    public GetUserAppDevAccessResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetUserAppDevAccessResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetUserAppDevAccessResponse setBody(GetUserAppDevAccessResponseBody body) {
        this.body = body;
        return this;
    }
    public GetUserAppDevAccessResponseBody getBody() {
        return this.body;
    }

}
