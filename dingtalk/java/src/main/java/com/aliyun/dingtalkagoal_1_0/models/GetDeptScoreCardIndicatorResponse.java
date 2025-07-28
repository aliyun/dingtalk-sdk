// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class GetDeptScoreCardIndicatorResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetDeptScoreCardIndicatorResponseBody body;

    public static GetDeptScoreCardIndicatorResponse build(java.util.Map<String, ?> map) throws Exception {
        GetDeptScoreCardIndicatorResponse self = new GetDeptScoreCardIndicatorResponse();
        return TeaModel.build(map, self);
    }

    public GetDeptScoreCardIndicatorResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetDeptScoreCardIndicatorResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetDeptScoreCardIndicatorResponse setBody(GetDeptScoreCardIndicatorResponseBody body) {
        this.body = body;
        return this;
    }
    public GetDeptScoreCardIndicatorResponseBody getBody() {
        return this.body;
    }

}
