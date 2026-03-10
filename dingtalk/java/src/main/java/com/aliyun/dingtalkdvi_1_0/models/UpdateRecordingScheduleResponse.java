// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class UpdateRecordingScheduleResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateRecordingScheduleResponseBody body;

    public static UpdateRecordingScheduleResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateRecordingScheduleResponse self = new UpdateRecordingScheduleResponse();
        return TeaModel.build(map, self);
    }

    public UpdateRecordingScheduleResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateRecordingScheduleResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateRecordingScheduleResponse setBody(UpdateRecordingScheduleResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateRecordingScheduleResponseBody getBody() {
        return this.body;
    }

}
