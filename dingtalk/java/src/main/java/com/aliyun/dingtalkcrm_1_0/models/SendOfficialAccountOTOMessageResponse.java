// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class SendOfficialAccountOTOMessageResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public SendOfficialAccountOTOMessageResponse setBody(SendOfficialAccountOTOMessageResponseBody body) {
        this.body = body;
        return this;
    }
    public SendOfficialAccountOTOMessageResponseBody getBody() {
        return this.body;
    }

}
