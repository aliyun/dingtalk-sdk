// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class SyncScheduleInfoResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    public static SyncScheduleInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        SyncScheduleInfoResponse self = new SyncScheduleInfoResponse();
        return TeaModel.build(map, self);
    }

    public SyncScheduleInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

}
