// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class GetRecordingScheduleResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetRecordingScheduleResponseBody body;

    public static GetRecordingScheduleResponse build(java.util.Map<String, ?> map) throws Exception {
        GetRecordingScheduleResponse self = new GetRecordingScheduleResponse();
        return TeaModel.build(map, self);
    }

    public GetRecordingScheduleResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetRecordingScheduleResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetRecordingScheduleResponse setBody(GetRecordingScheduleResponseBody body) {
        this.body = body;
        return this;
    }
    public GetRecordingScheduleResponseBody getBody() {
        return this.body;
    }

}
