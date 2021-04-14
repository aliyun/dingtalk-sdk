// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class CreateVideoConferenceResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CreateVideoConferenceResponseBody body;

    public static CreateVideoConferenceResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateVideoConferenceResponse self = new CreateVideoConferenceResponse();
        return TeaModel.build(map, self);
    }

    public CreateVideoConferenceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateVideoConferenceResponse setBody(CreateVideoConferenceResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateVideoConferenceResponseBody getBody() {
        return this.body;
    }

}
