// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class SaveBenefitLicenseResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SaveBenefitLicenseResponseBody body;

    public static SaveBenefitLicenseResponse build(java.util.Map<String, ?> map) throws Exception {
        SaveBenefitLicenseResponse self = new SaveBenefitLicenseResponse();
        return TeaModel.build(map, self);
    }

    public SaveBenefitLicenseResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SaveBenefitLicenseResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SaveBenefitLicenseResponse setBody(SaveBenefitLicenseResponseBody body) {
        this.body = body;
        return this;
    }
    public SaveBenefitLicenseResponseBody getBody() {
        return this.body;
    }

}
