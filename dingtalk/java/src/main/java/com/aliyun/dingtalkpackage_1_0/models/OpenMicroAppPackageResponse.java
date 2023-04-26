// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkpackage_1_0.models;

import com.aliyun.tea.*;

public class OpenMicroAppPackageResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public OpenMicroAppPackageResponseBody body;

    public static OpenMicroAppPackageResponse build(java.util.Map<String, ?> map) throws Exception {
        OpenMicroAppPackageResponse self = new OpenMicroAppPackageResponse();
        return TeaModel.build(map, self);
    }

    public OpenMicroAppPackageResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public OpenMicroAppPackageResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public OpenMicroAppPackageResponse setBody(OpenMicroAppPackageResponseBody body) {
        this.body = body;
        return this;
    }
    public OpenMicroAppPackageResponseBody getBody() {
        return this.body;
    }

}
