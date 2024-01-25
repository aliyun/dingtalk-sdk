// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class SendOfficialAccountSNSMessageResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SendOfficialAccountSNSMessageResponseBody body;

    public static SendOfficialAccountSNSMessageResponse build(java.util.Map<String, ?> map) throws Exception {
        SendOfficialAccountSNSMessageResponse self = new SendOfficialAccountSNSMessageResponse();
        return TeaModel.build(map, self);
    }

    public SendOfficialAccountSNSMessageResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SendOfficialAccountSNSMessageResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SendOfficialAccountSNSMessageResponse setBody(SendOfficialAccountSNSMessageResponseBody body) {
        this.body = body;
        return this;
    }
    public SendOfficialAccountSNSMessageResponseBody getBody() {
        return this.body;
    }

}
