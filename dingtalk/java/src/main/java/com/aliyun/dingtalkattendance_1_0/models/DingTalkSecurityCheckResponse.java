// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class DingTalkSecurityCheckResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public DingTalkSecurityCheckResponseBody body;

    public static DingTalkSecurityCheckResponse build(java.util.Map<String, ?> map) throws Exception {
        DingTalkSecurityCheckResponse self = new DingTalkSecurityCheckResponse();
        return TeaModel.build(map, self);
    }

    public DingTalkSecurityCheckResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DingTalkSecurityCheckResponse setBody(DingTalkSecurityCheckResponseBody body) {
        this.body = body;
        return this;
    }
    public DingTalkSecurityCheckResponseBody getBody() {
        return this.body;
    }

}
