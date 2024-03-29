// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class OrgGroupQueryResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public OrgGroupQueryResponseBody body;

    public static OrgGroupQueryResponse build(java.util.Map<String, ?> map) throws Exception {
        OrgGroupQueryResponse self = new OrgGroupQueryResponse();
        return TeaModel.build(map, self);
    }

    public OrgGroupQueryResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public OrgGroupQueryResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public OrgGroupQueryResponse setBody(OrgGroupQueryResponseBody body) {
        this.body = body;
        return this;
    }
    public OrgGroupQueryResponseBody getBody() {
        return this.body;
    }

}
