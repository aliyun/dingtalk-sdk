// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class TalentQueryObjectiveTagResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public TalentQueryObjectiveTagResponseBody body;

    public static TalentQueryObjectiveTagResponse build(java.util.Map<String, ?> map) throws Exception {
        TalentQueryObjectiveTagResponse self = new TalentQueryObjectiveTagResponse();
        return TeaModel.build(map, self);
    }

    public TalentQueryObjectiveTagResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public TalentQueryObjectiveTagResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public TalentQueryObjectiveTagResponse setBody(TalentQueryObjectiveTagResponseBody body) {
        this.body = body;
        return this;
    }
    public TalentQueryObjectiveTagResponseBody getBody() {
        return this.body;
    }

}
