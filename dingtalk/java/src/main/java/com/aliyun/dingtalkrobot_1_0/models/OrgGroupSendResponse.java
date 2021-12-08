// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class OrgGroupSendResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public OrgGroupSendResponse setBody(OrgGroupSendResponseBody body) {
        this.body = body;
        return this;
    }
    public OrgGroupSendResponseBody getBody() {
        return this.body;
    }

}
