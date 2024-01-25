// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class CreateCooperateOrgResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreateCooperateOrgResponseBody body;

    public static CreateCooperateOrgResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateCooperateOrgResponse self = new CreateCooperateOrgResponse();
        return TeaModel.build(map, self);
    }

    public CreateCooperateOrgResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateCooperateOrgResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateCooperateOrgResponse setBody(CreateCooperateOrgResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateCooperateOrgResponseBody getBody() {
        return this.body;
    }

}
