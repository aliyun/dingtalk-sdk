// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class UpdateRealmLicenseResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateRealmLicenseResponseBody body;

    public static UpdateRealmLicenseResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateRealmLicenseResponse self = new UpdateRealmLicenseResponse();
        return TeaModel.build(map, self);
    }

    public UpdateRealmLicenseResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateRealmLicenseResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateRealmLicenseResponse setBody(UpdateRealmLicenseResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateRealmLicenseResponseBody getBody() {
        return this.body;
    }

}
