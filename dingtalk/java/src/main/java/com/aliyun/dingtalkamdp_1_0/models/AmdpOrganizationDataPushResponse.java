// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkamdp_1_0.models;

import com.aliyun.tea.*;

public class AmdpOrganizationDataPushResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AmdpOrganizationDataPushResponseBody body;

    public static AmdpOrganizationDataPushResponse build(java.util.Map<String, ?> map) throws Exception {
        AmdpOrganizationDataPushResponse self = new AmdpOrganizationDataPushResponse();
        return TeaModel.build(map, self);
    }

    public AmdpOrganizationDataPushResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AmdpOrganizationDataPushResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AmdpOrganizationDataPushResponse setBody(AmdpOrganizationDataPushResponseBody body) {
        this.body = body;
        return this;
    }
    public AmdpOrganizationDataPushResponseBody getBody() {
        return this.body;
    }

}
