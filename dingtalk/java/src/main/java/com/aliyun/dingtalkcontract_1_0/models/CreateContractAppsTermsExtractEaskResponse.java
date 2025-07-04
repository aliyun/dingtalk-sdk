// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class CreateContractAppsTermsExtractEaskResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreateContractAppsTermsExtractEaskResponseBody body;

    public static CreateContractAppsTermsExtractEaskResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateContractAppsTermsExtractEaskResponse self = new CreateContractAppsTermsExtractEaskResponse();
        return TeaModel.build(map, self);
    }

    public CreateContractAppsTermsExtractEaskResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateContractAppsTermsExtractEaskResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateContractAppsTermsExtractEaskResponse setBody(CreateContractAppsTermsExtractEaskResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateContractAppsTermsExtractEaskResponseBody getBody() {
        return this.body;
    }

}
