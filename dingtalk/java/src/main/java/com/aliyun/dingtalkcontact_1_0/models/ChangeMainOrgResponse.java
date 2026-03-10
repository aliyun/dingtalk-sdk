// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class ChangeMainOrgResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ChangeMainOrgResponseBody body;

    public static ChangeMainOrgResponse build(java.util.Map<String, ?> map) throws Exception {
        ChangeMainOrgResponse self = new ChangeMainOrgResponse();
        return TeaModel.build(map, self);
    }

    public ChangeMainOrgResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ChangeMainOrgResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ChangeMainOrgResponse setBody(ChangeMainOrgResponseBody body) {
        this.body = body;
        return this;
    }
    public ChangeMainOrgResponseBody getBody() {
        return this.body;
    }

}
