// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class CreateRecordingScheduleResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreateRecordingScheduleResponseBody body;

    public static CreateRecordingScheduleResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateRecordingScheduleResponse self = new CreateRecordingScheduleResponse();
        return TeaModel.build(map, self);
    }

    public CreateRecordingScheduleResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateRecordingScheduleResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateRecordingScheduleResponse setBody(CreateRecordingScheduleResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateRecordingScheduleResponseBody getBody() {
        return this.body;
    }

}
