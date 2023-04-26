// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class RobotMessageFileDownloadResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public RobotMessageFileDownloadResponseBody body;

    public static RobotMessageFileDownloadResponse build(java.util.Map<String, ?> map) throws Exception {
        RobotMessageFileDownloadResponse self = new RobotMessageFileDownloadResponse();
        return TeaModel.build(map, self);
    }

    public RobotMessageFileDownloadResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public RobotMessageFileDownloadResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public RobotMessageFileDownloadResponse setBody(RobotMessageFileDownloadResponseBody body) {
        this.body = body;
        return this;
    }
    public RobotMessageFileDownloadResponseBody getBody() {
        return this.body;
    }

}
