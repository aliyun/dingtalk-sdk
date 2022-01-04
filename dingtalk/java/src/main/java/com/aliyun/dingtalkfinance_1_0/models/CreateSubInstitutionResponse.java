// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class CreateSubInstitutionResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CreateSubInstitutionResponseBody body;

    public static CreateSubInstitutionResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateSubInstitutionResponse self = new CreateSubInstitutionResponse();
        return TeaModel.build(map, self);
    }

    public CreateSubInstitutionResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateSubInstitutionResponse setBody(CreateSubInstitutionResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateSubInstitutionResponseBody getBody() {
        return this.body;
    }

}
