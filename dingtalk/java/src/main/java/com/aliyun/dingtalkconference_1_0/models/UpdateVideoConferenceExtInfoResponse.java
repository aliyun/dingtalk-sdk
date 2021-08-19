// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class UpdateVideoConferenceExtInfoResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public UpdateVideoConferenceExtInfoResponseBody body;

    public static UpdateVideoConferenceExtInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateVideoConferenceExtInfoResponse self = new UpdateVideoConferenceExtInfoResponse();
        return TeaModel.build(map, self);
    }

    public UpdateVideoConferenceExtInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateVideoConferenceExtInfoResponse setBody(UpdateVideoConferenceExtInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateVideoConferenceExtInfoResponseBody getBody() {
        return this.body;
    }

}
