// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdingmi_1_0.models;

import com.aliyun.tea.*;

public class GetOfficialAccountRobotInfoResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public GetOfficialAccountRobotInfoResponse setBody(GetOfficialAccountRobotInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public GetOfficialAccountRobotInfoResponseBody getBody() {
        return this.body;
    }

}
