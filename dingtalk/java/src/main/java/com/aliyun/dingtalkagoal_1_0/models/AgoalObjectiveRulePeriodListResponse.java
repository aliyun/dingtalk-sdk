// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class AgoalObjectiveRulePeriodListResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AgoalObjectiveRulePeriodListResponseBody body;

    public static AgoalObjectiveRulePeriodListResponse build(java.util.Map<String, ?> map) throws Exception {
        AgoalObjectiveRulePeriodListResponse self = new AgoalObjectiveRulePeriodListResponse();
        return TeaModel.build(map, self);
    }

    public AgoalObjectiveRulePeriodListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AgoalObjectiveRulePeriodListResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AgoalObjectiveRulePeriodListResponse setBody(AgoalObjectiveRulePeriodListResponseBody body) {
        this.body = body;
        return this;
    }
    public AgoalObjectiveRulePeriodListResponseBody getBody() {
        return this.body;
    }

}
