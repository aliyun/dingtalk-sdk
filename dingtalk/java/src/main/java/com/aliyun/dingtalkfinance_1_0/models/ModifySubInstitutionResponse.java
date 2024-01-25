// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class ModifySubInstitutionResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ModifySubInstitutionResponseBody body;

    public static ModifySubInstitutionResponse build(java.util.Map<String, ?> map) throws Exception {
        ModifySubInstitutionResponse self = new ModifySubInstitutionResponse();
        return TeaModel.build(map, self);
    }

    public ModifySubInstitutionResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ModifySubInstitutionResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ModifySubInstitutionResponse setBody(ModifySubInstitutionResponseBody body) {
        this.body = body;
        return this;
    }
    public ModifySubInstitutionResponseBody getBody() {
        return this.body;
    }

}
