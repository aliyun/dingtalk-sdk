// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class ReportDeviceLogResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public Boolean body;

    public static ReportDeviceLogResponse build(java.util.Map<String, ?> map) throws Exception {
        ReportDeviceLogResponse self = new ReportDeviceLogResponse();
        return TeaModel.build(map, self);
    }

    public ReportDeviceLogResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ReportDeviceLogResponse setBody(Boolean body) {
        this.body = body;
        return this;
    }
    public Boolean getBody() {
        return this.body;
    }

}
