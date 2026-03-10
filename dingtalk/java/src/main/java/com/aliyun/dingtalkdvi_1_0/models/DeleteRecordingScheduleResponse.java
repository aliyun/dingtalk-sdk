// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class DeleteRecordingScheduleResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DeleteRecordingScheduleResponseBody body;

    public static DeleteRecordingScheduleResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteRecordingScheduleResponse self = new DeleteRecordingScheduleResponse();
        return TeaModel.build(map, self);
    }

    public DeleteRecordingScheduleResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeleteRecordingScheduleResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DeleteRecordingScheduleResponse setBody(DeleteRecordingScheduleResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteRecordingScheduleResponseBody getBody() {
        return this.body;
    }

}
