// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkpackage_1_0.models;

import com.aliyun.tea.*;

public class ReleaseGrayOrgSetResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public ReleaseGrayOrgSetResponseBody body;

    public static ReleaseGrayOrgSetResponse build(java.util.Map<String, ?> map) throws Exception {
        ReleaseGrayOrgSetResponse self = new ReleaseGrayOrgSetResponse();
        return TeaModel.build(map, self);
    }

    public ReleaseGrayOrgSetResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ReleaseGrayOrgSetResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ReleaseGrayOrgSetResponse setBody(ReleaseGrayOrgSetResponseBody body) {
        this.body = body;
        return this;
    }
    public ReleaseGrayOrgSetResponseBody getBody() {
        return this.body;
    }

}
