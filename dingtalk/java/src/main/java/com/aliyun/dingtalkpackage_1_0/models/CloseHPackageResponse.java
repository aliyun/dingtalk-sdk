// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkpackage_1_0.models;

import com.aliyun.tea.*;

public class CloseHPackageResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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

    public CloseHPackageResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CloseHPackageResponse setBody(CloseHPackageResponseBody body) {
        this.body = body;
        return this;
    }
    public CloseHPackageResponseBody getBody() {
        return this.body;
    }

}
