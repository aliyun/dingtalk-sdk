// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class OrgGroupSendResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public OrgGroupSendResponseBody body;

    public static OrgGroupSendResponse build(java.util.Map<String, ?> map) throws Exception {
        OrgGroupSendResponse self = new OrgGroupSendResponse();
        return TeaModel.build(map, self);
    }

    public OrgGroupSendResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public OrgGroupSendResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public OrgGroupSendResponse setBody(OrgGroupSendResponseBody body) {
        this.body = body;
        return this;
    }
    public OrgGroupSendResponseBody getBody() {
        return this.body;
    }

}
