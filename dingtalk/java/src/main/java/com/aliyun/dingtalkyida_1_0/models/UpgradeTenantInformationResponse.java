// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class UpgradeTenantInformationResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpgradeTenantInformationResponseBody body;

    public static UpgradeTenantInformationResponse build(java.util.Map<String, ?> map) throws Exception {
        UpgradeTenantInformationResponse self = new UpgradeTenantInformationResponse();
        return TeaModel.build(map, self);
    }

    public UpgradeTenantInformationResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpgradeTenantInformationResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpgradeTenantInformationResponse setBody(UpgradeTenantInformationResponseBody body) {
        this.body = body;
        return this;
    }
    public UpgradeTenantInformationResponseBody getBody() {
        return this.body;
    }

}
