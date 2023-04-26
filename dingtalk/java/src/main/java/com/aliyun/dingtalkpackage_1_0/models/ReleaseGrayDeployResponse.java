// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkpackage_1_0.models;

import com.aliyun.tea.*;

public class ReleaseGrayDeployResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public ReleaseGrayDeployResponseBody body;

    public static ReleaseGrayDeployResponse build(java.util.Map<String, ?> map) throws Exception {
        ReleaseGrayDeployResponse self = new ReleaseGrayDeployResponse();
        return TeaModel.build(map, self);
    }

    public ReleaseGrayDeployResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ReleaseGrayDeployResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ReleaseGrayDeployResponse setBody(ReleaseGrayDeployResponseBody body) {
        this.body = body;
        return this;
    }
    public ReleaseGrayDeployResponseBody getBody() {
        return this.body;
    }

}
