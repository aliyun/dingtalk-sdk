// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdingmi_1_0.models;

import com.aliyun.tea.*;

public class UpdateOfficialAccountRobotInfoResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public UpdateOfficialAccountRobotInfoResponseBody body;

    public static UpdateOfficialAccountRobotInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateOfficialAccountRobotInfoResponse self = new UpdateOfficialAccountRobotInfoResponse();
        return TeaModel.build(map, self);
    }

    public UpdateOfficialAccountRobotInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateOfficialAccountRobotInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateOfficialAccountRobotInfoResponse setBody(UpdateOfficialAccountRobotInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateOfficialAccountRobotInfoResponseBody getBody() {
        return this.body;
    }

}
