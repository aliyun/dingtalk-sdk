// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class OpenBenefitPackageResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public OpenBenefitPackageResponseBody body;

    public static OpenBenefitPackageResponse build(java.util.Map<String, ?> map) throws Exception {
        OpenBenefitPackageResponse self = new OpenBenefitPackageResponse();
        return TeaModel.build(map, self);
    }

    public OpenBenefitPackageResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public OpenBenefitPackageResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public OpenBenefitPackageResponse setBody(OpenBenefitPackageResponseBody body) {
        this.body = body;
        return this;
    }
    public OpenBenefitPackageResponseBody getBody() {
        return this.body;
    }

}
