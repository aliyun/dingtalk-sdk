// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class HandoverTeamWithoutAuthResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public HandoverTeamWithoutAuthResponseBody body;

    public static HandoverTeamWithoutAuthResponse build(java.util.Map<String, ?> map) throws Exception {
        HandoverTeamWithoutAuthResponse self = new HandoverTeamWithoutAuthResponse();
        return TeaModel.build(map, self);
    }

    public HandoverTeamWithoutAuthResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public HandoverTeamWithoutAuthResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public HandoverTeamWithoutAuthResponse setBody(HandoverTeamWithoutAuthResponseBody body) {
        this.body = body;
        return this;
    }
    public HandoverTeamWithoutAuthResponseBody getBody() {
        return this.body;
    }

}
