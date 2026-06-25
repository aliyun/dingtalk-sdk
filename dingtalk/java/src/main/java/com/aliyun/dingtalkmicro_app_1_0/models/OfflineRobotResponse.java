// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class OfflineRobotResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public OfflineRobotResponseBody body;

    public static OfflineRobotResponse build(java.util.Map<String, ?> map) throws Exception {
        OfflineRobotResponse self = new OfflineRobotResponse();
        return TeaModel.build(map, self);
    }

    public OfflineRobotResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public OfflineRobotResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public OfflineRobotResponse setBody(OfflineRobotResponseBody body) {
        this.body = body;
        return this;
    }
    public OfflineRobotResponseBody getBody() {
        return this.body;
    }

}
