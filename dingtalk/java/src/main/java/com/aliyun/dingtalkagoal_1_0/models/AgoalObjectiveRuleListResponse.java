// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class AgoalObjectiveRuleListResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AgoalObjectiveRuleListResponseBody body;

    public static AgoalObjectiveRuleListResponse build(java.util.Map<String, ?> map) throws Exception {
        AgoalObjectiveRuleListResponse self = new AgoalObjectiveRuleListResponse();
        return TeaModel.build(map, self);
    }

    public AgoalObjectiveRuleListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AgoalObjectiveRuleListResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AgoalObjectiveRuleListResponse setBody(AgoalObjectiveRuleListResponseBody body) {
        this.body = body;
        return this;
    }
    public AgoalObjectiveRuleListResponseBody getBody() {
        return this.body;
    }

}
