// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class ListDeviceRecordingDurationResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ListDeviceRecordingDurationResponseBody body;

    public static ListDeviceRecordingDurationResponse build(java.util.Map<String, ?> map) throws Exception {
        ListDeviceRecordingDurationResponse self = new ListDeviceRecordingDurationResponse();
        return TeaModel.build(map, self);
    }

    public ListDeviceRecordingDurationResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListDeviceRecordingDurationResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListDeviceRecordingDurationResponse setBody(ListDeviceRecordingDurationResponseBody body) {
        this.body = body;
        return this;
    }
    public ListDeviceRecordingDurationResponseBody getBody() {
        return this.body;
    }

}
