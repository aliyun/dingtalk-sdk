// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh5package_1_0.models;

import com.aliyun.tea.*;

public class PublishPackageResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public PublishPackageResponseBody body;

    public static PublishPackageResponse build(java.util.Map<String, ?> map) throws Exception {
        PublishPackageResponse self = new PublishPackageResponse();
        return TeaModel.build(map, self);
    }

    public PublishPackageResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public PublishPackageResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public PublishPackageResponse setBody(PublishPackageResponseBody body) {
        this.body = body;
        return this;
    }
    public PublishPackageResponseBody getBody() {
        return this.body;
    }

}
