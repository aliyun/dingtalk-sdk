// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_e_e_1_0.models;

import com.aliyun.tea.*;

public class RegisterCategorySourceConfigResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public RegisterCategorySourceConfigResponseBody body;

    public static RegisterCategorySourceConfigResponse build(java.util.Map<String, ?> map) throws Exception {
        RegisterCategorySourceConfigResponse self = new RegisterCategorySourceConfigResponse();
        return TeaModel.build(map, self);
    }

    public RegisterCategorySourceConfigResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public RegisterCategorySourceConfigResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public RegisterCategorySourceConfigResponse setBody(RegisterCategorySourceConfigResponseBody body) {
        this.body = body;
        return this;
    }
    public RegisterCategorySourceConfigResponseBody getBody() {
        return this.body;
    }

}
