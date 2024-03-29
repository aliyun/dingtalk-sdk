// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkpackage_1_0.models;

import com.aliyun.tea.*;

public class HPackageListGetResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public HPackageListGetResponseBody body;

    public static HPackageListGetResponse build(java.util.Map<String, ?> map) throws Exception {
        HPackageListGetResponse self = new HPackageListGetResponse();
        return TeaModel.build(map, self);
    }

    public HPackageListGetResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public HPackageListGetResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public HPackageListGetResponse setBody(HPackageListGetResponseBody body) {
        this.body = body;
        return this;
    }
    public HPackageListGetResponseBody getBody() {
        return this.body;
    }

}
