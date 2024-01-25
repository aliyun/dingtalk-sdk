// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class RemoveContactFromOrgResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public RemoveContactFromOrgResponseBody body;

    public static RemoveContactFromOrgResponse build(java.util.Map<String, ?> map) throws Exception {
        RemoveContactFromOrgResponse self = new RemoveContactFromOrgResponse();
        return TeaModel.build(map, self);
    }

    public RemoveContactFromOrgResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public RemoveContactFromOrgResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public RemoveContactFromOrgResponse setBody(RemoveContactFromOrgResponseBody body) {
        this.body = body;
        return this;
    }
    public RemoveContactFromOrgResponseBody getBody() {
        return this.body;
    }

}
