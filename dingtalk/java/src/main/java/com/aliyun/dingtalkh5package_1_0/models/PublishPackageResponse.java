// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh5package_1_0.models;

import com.aliyun.tea.*;

public class PublishPackageResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public PublishPackageResponse setBody(PublishPackageResponseBody body) {
        this.body = body;
        return this;
    }
    public PublishPackageResponseBody getBody() {
        return this.body;
    }

}
