// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdingmi_1_0.models;

import com.aliyun.tea.*;

public class GetIntelligentRobotInfoResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetIntelligentRobotInfoResponseBody body;

    public static GetIntelligentRobotInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        GetIntelligentRobotInfoResponse self = new GetIntelligentRobotInfoResponse();
        return TeaModel.build(map, self);
    }

    public GetIntelligentRobotInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetIntelligentRobotInfoResponse setBody(GetIntelligentRobotInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public GetIntelligentRobotInfoResponseBody getBody() {
        return this.body;
    }

}
