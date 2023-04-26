// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class OrgGroupRecallResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public OrgGroupRecallResponseBody body;

    public static OrgGroupRecallResponse build(java.util.Map<String, ?> map) throws Exception {
        OrgGroupRecallResponse self = new OrgGroupRecallResponse();
        return TeaModel.build(map, self);
    }

    public OrgGroupRecallResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public OrgGroupRecallResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public OrgGroupRecallResponse setBody(OrgGroupRecallResponseBody body) {
        this.body = body;
        return this;
    }
    public OrgGroupRecallResponseBody getBody() {
        return this.body;
    }

}
