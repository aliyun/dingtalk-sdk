// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_integration_1_0.models;

import com.aliyun.tea.*;

public class SendMessageToEventGroupResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public java.util.Map<String, ?> body;

    public static SendMessageToEventGroupResponse build(java.util.Map<String, ?> map) throws Exception {
        SendMessageToEventGroupResponse self = new SendMessageToEventGroupResponse();
        return TeaModel.build(map, self);
    }

    public SendMessageToEventGroupResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SendMessageToEventGroupResponse setBody(java.util.Map<String, ?> body) {
        this.body = body;
        return this;
    }
    public java.util.Map<String, ?> getBody() {
        return this.body;
    }

}
