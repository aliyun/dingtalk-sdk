// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class ReportDeviceUseLogResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ReportDeviceUseLogResponseBody body;

    public static ReportDeviceUseLogResponse build(java.util.Map<String, ?> map) throws Exception {
        ReportDeviceUseLogResponse self = new ReportDeviceUseLogResponse();
        return TeaModel.build(map, self);
    }

    public ReportDeviceUseLogResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ReportDeviceUseLogResponse setBody(ReportDeviceUseLogResponseBody body) {
        this.body = body;
        return this;
    }
    public ReportDeviceUseLogResponseBody getBody() {
        return this.body;
    }

}
