// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class UpdateVideoConferenceSettingResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public UpdateVideoConferenceSettingResponseBody body;

    public static UpdateVideoConferenceSettingResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateVideoConferenceSettingResponse self = new UpdateVideoConferenceSettingResponse();
        return TeaModel.build(map, self);
    }

    public UpdateVideoConferenceSettingResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateVideoConferenceSettingResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateVideoConferenceSettingResponse setBody(UpdateVideoConferenceSettingResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateVideoConferenceSettingResponseBody getBody() {
        return this.body;
    }

}
