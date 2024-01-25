// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkpackage_1_0.models;

import com.aliyun.tea.*;

public class HUploadPackageResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public HUploadPackageResponseBody body;

    public static HUploadPackageResponse build(java.util.Map<String, ?> map) throws Exception {
        HUploadPackageResponse self = new HUploadPackageResponse();
        return TeaModel.build(map, self);
    }

    public HUploadPackageResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public HUploadPackageResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public HUploadPackageResponse setBody(HUploadPackageResponseBody body) {
        this.body = body;
        return this;
    }
    public HUploadPackageResponseBody getBody() {
        return this.body;
    }

}
