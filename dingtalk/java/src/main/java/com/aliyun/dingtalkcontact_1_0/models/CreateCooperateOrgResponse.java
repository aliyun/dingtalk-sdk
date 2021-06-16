// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class CreateCooperateOrgResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public CreateCooperateOrgResponse setBody(CreateCooperateOrgResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateCooperateOrgResponseBody getBody() {
        return this.body;
    }

}
