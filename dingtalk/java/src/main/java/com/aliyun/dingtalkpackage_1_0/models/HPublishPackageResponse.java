// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkpackage_1_0.models;

import com.aliyun.tea.*;

public class HPublishPackageResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public HPublishPackageResponseBody body;

    public static HPublishPackageResponse build(java.util.Map<String, ?> map) throws Exception {
        HPublishPackageResponse self = new HPublishPackageResponse();
        return TeaModel.build(map, self);
    }

    public HPublishPackageResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public HPublishPackageResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public HPublishPackageResponse setBody(HPublishPackageResponseBody body) {
        this.body = body;
        return this;
    }
    public HPublishPackageResponseBody getBody() {
        return this.body;
    }

}
