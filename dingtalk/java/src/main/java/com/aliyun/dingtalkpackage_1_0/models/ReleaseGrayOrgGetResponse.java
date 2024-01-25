// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkpackage_1_0.models;

import com.aliyun.tea.*;

public class ReleaseGrayOrgGetResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ReleaseGrayOrgGetResponseBody body;

    public static ReleaseGrayOrgGetResponse build(java.util.Map<String, ?> map) throws Exception {
        ReleaseGrayOrgGetResponse self = new ReleaseGrayOrgGetResponse();
        return TeaModel.build(map, self);
    }

    public ReleaseGrayOrgGetResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ReleaseGrayOrgGetResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ReleaseGrayOrgGetResponse setBody(ReleaseGrayOrgGetResponseBody body) {
        this.body = body;
        return this;
    }
    public ReleaseGrayOrgGetResponseBody getBody() {
        return this.body;
    }

}
