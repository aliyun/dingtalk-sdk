// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdingmi_1_0.models;

import com.aliyun.tea.*;

public class GetOfficialAccountRobotInfoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetOfficialAccountRobotInfoResponseBody body;

    public static GetOfficialAccountRobotInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        GetOfficialAccountRobotInfoResponse self = new GetOfficialAccountRobotInfoResponse();
        return TeaModel.build(map, self);
    }

    public GetOfficialAccountRobotInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetOfficialAccountRobotInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetOfficialAccountRobotInfoResponse setBody(GetOfficialAccountRobotInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public GetOfficialAccountRobotInfoResponseBody getBody() {
        return this.body;
    }

}
