// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class AppLoginCodeGenResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AppLoginCodeGenResponseBody body;

    public static AppLoginCodeGenResponse build(java.util.Map<String, ?> map) throws Exception {
        AppLoginCodeGenResponse self = new AppLoginCodeGenResponse();
        return TeaModel.build(map, self);
    }

    public AppLoginCodeGenResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AppLoginCodeGenResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AppLoginCodeGenResponse setBody(AppLoginCodeGenResponseBody body) {
        this.body = body;
        return this;
    }
    public AppLoginCodeGenResponseBody getBody() {
        return this.body;
    }

}
