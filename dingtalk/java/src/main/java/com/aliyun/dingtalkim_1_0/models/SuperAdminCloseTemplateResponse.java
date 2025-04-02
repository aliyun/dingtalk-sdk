// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class SuperAdminCloseTemplateResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SuperAdminCloseTemplateResponseBody body;

    public static SuperAdminCloseTemplateResponse build(java.util.Map<String, ?> map) throws Exception {
        SuperAdminCloseTemplateResponse self = new SuperAdminCloseTemplateResponse();
        return TeaModel.build(map, self);
    }

    public SuperAdminCloseTemplateResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SuperAdminCloseTemplateResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SuperAdminCloseTemplateResponse setBody(SuperAdminCloseTemplateResponseBody body) {
        this.body = body;
        return this;
    }
    public SuperAdminCloseTemplateResponseBody getBody() {
        return this.body;
    }

}
