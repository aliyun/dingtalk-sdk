// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class CloseVideoConferenceResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CloseVideoConferenceResponseBody body;

    public static CloseVideoConferenceResponse build(java.util.Map<String, ?> map) throws Exception {
        CloseVideoConferenceResponse self = new CloseVideoConferenceResponse();
        return TeaModel.build(map, self);
    }

    public CloseVideoConferenceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CloseVideoConferenceResponse setBody(CloseVideoConferenceResponseBody body) {
        this.body = body;
        return this;
    }
    public CloseVideoConferenceResponseBody getBody() {
        return this.body;
    }

}
