// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkpackage_1_0.models;

import com.aliyun.tea.*;

public class ReleaseGrayOrgGetResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public ReleaseGrayOrgGetResponse setBody(ReleaseGrayOrgGetResponseBody body) {
        this.body = body;
        return this;
    }
    public ReleaseGrayOrgGetResponseBody getBody() {
        return this.body;
    }

}
