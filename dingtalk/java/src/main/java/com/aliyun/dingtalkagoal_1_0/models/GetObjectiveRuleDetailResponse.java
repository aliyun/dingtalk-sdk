// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class GetObjectiveRuleDetailResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetObjectiveRuleDetailResponseBody body;

    public static GetObjectiveRuleDetailResponse build(java.util.Map<String, ?> map) throws Exception {
        GetObjectiveRuleDetailResponse self = new GetObjectiveRuleDetailResponse();
        return TeaModel.build(map, self);
    }

    public GetObjectiveRuleDetailResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetObjectiveRuleDetailResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetObjectiveRuleDetailResponse setBody(GetObjectiveRuleDetailResponseBody body) {
        this.body = body;
        return this;
    }
    public GetObjectiveRuleDetailResponseBody getBody() {
        return this.body;
    }

}
