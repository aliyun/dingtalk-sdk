// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class AgoalOrgObjectiveRuleListResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AgoalOrgObjectiveRuleListResponseBody body;

    public static AgoalOrgObjectiveRuleListResponse build(java.util.Map<String, ?> map) throws Exception {
        AgoalOrgObjectiveRuleListResponse self = new AgoalOrgObjectiveRuleListResponse();
        return TeaModel.build(map, self);
    }

    public AgoalOrgObjectiveRuleListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AgoalOrgObjectiveRuleListResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AgoalOrgObjectiveRuleListResponse setBody(AgoalOrgObjectiveRuleListResponseBody body) {
        this.body = body;
        return this;
    }
    public AgoalOrgObjectiveRuleListResponseBody getBody() {
        return this.body;
    }

}
