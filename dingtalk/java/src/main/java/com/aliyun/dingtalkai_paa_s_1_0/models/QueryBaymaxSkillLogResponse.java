// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_paa_s_1_0.models;

import com.aliyun.tea.*;

public class QueryBaymaxSkillLogResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public QueryBaymaxSkillLogResponseBody body;

    public static QueryBaymaxSkillLogResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryBaymaxSkillLogResponse self = new QueryBaymaxSkillLogResponse();
        return TeaModel.build(map, self);
    }

    public QueryBaymaxSkillLogResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryBaymaxSkillLogResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryBaymaxSkillLogResponse setBody(QueryBaymaxSkillLogResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryBaymaxSkillLogResponseBody getBody() {
        return this.body;
    }

}
