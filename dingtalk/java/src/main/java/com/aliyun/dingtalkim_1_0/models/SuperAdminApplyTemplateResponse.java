// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class SuperAdminApplyTemplateResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SuperAdminApplyTemplateResponseBody body;

    public static SuperAdminApplyTemplateResponse build(java.util.Map<String, ?> map) throws Exception {
        SuperAdminApplyTemplateResponse self = new SuperAdminApplyTemplateResponse();
        return TeaModel.build(map, self);
    }

    public SuperAdminApplyTemplateResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SuperAdminApplyTemplateResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SuperAdminApplyTemplateResponse setBody(SuperAdminApplyTemplateResponseBody body) {
        this.body = body;
        return this;
    }
    public SuperAdminApplyTemplateResponseBody getBody() {
        return this.body;
    }

}
