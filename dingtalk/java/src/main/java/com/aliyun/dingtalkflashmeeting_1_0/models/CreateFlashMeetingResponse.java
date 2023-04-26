// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkflashmeeting_1_0.models;

import com.aliyun.tea.*;

public class CreateFlashMeetingResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public CreateFlashMeetingResponseBody body;

    public static CreateFlashMeetingResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateFlashMeetingResponse self = new CreateFlashMeetingResponse();
        return TeaModel.build(map, self);
    }

    public CreateFlashMeetingResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateFlashMeetingResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateFlashMeetingResponse setBody(CreateFlashMeetingResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateFlashMeetingResponseBody getBody() {
        return this.body;
    }

}
