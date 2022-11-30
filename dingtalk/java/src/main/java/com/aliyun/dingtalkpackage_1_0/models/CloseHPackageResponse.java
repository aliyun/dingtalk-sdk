// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkpackage_1_0.models;

import com.aliyun.tea.*;

public class CloseHPackageResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CloseHPackageResponseBody body;

    public static CloseHPackageResponse build(java.util.Map<String, ?> map) throws Exception {
        CloseHPackageResponse self = new CloseHPackageResponse();
        return TeaModel.build(map, self);
    }

    public CloseHPackageResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CloseHPackageResponse setBody(CloseHPackageResponseBody body) {
        this.body = body;
        return this;
    }
    public CloseHPackageResponseBody getBody() {
        return this.body;
    }

}
