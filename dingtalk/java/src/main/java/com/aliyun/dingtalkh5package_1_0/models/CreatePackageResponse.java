// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh5package_1_0.models;

import com.aliyun.tea.*;

public class CreatePackageResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CreatePackageResponseBody body;

    public static CreatePackageResponse build(java.util.Map<String, ?> map) throws Exception {
        CreatePackageResponse self = new CreatePackageResponse();
        return TeaModel.build(map, self);
    }

    public CreatePackageResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreatePackageResponse setBody(CreatePackageResponseBody body) {
        this.body = body;
        return this;
    }
    public CreatePackageResponseBody getBody() {
        return this.body;
    }

}
