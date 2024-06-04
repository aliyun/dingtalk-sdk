// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class ListBenefitLicenseResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ListBenefitLicenseResponseBody body;

    public static ListBenefitLicenseResponse build(java.util.Map<String, ?> map) throws Exception {
        ListBenefitLicenseResponse self = new ListBenefitLicenseResponse();
        return TeaModel.build(map, self);
    }

    public ListBenefitLicenseResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListBenefitLicenseResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListBenefitLicenseResponse setBody(ListBenefitLicenseResponseBody body) {
        this.body = body;
        return this;
    }
    public ListBenefitLicenseResponseBody getBody() {
        return this.body;
    }

}
