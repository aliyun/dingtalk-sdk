// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class SendOfficialAccountOTOMessageResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SendOfficialAccountOTOMessageResponseBody body;

    public static SendOfficialAccountOTOMessageResponse build(java.util.Map<String, ?> map) throws Exception {
        SendOfficialAccountOTOMessageResponse self = new SendOfficialAccountOTOMessageResponse();
        return TeaModel.build(map, self);
    }

    public SendOfficialAccountOTOMessageResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SendOfficialAccountOTOMessageResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SendOfficialAccountOTOMessageResponse setBody(SendOfficialAccountOTOMessageResponseBody body) {
        this.body = body;
        return this;
    }
    public SendOfficialAccountOTOMessageResponseBody getBody() {
        return this.body;
    }

}
