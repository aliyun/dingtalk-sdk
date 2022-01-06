// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class ConsultCreateSubInstitutionResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ConsultCreateSubInstitutionResponseBody body;

    public static ConsultCreateSubInstitutionResponse build(java.util.Map<String, ?> map) throws Exception {
        ConsultCreateSubInstitutionResponse self = new ConsultCreateSubInstitutionResponse();
        return TeaModel.build(map, self);
    }

    public ConsultCreateSubInstitutionResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ConsultCreateSubInstitutionResponse setBody(ConsultCreateSubInstitutionResponseBody body) {
        this.body = body;
        return this;
    }
    public ConsultCreateSubInstitutionResponseBody getBody() {
        return this.body;
    }

}