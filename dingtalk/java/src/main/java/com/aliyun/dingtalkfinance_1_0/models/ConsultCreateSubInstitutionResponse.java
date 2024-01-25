// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class ConsultCreateSubInstitutionResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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

    public ConsultCreateSubInstitutionResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ConsultCreateSubInstitutionResponse setBody(ConsultCreateSubInstitutionResponseBody body) {
        this.body = body;
        return this;
    }
    public ConsultCreateSubInstitutionResponseBody getBody() {
        return this.body;
    }

}
