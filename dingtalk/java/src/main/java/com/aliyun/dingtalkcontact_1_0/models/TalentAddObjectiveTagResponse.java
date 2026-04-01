// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class TalentAddObjectiveTagResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public TalentAddObjectiveTagResponseBody body;

    public static TalentAddObjectiveTagResponse build(java.util.Map<String, ?> map) throws Exception {
        TalentAddObjectiveTagResponse self = new TalentAddObjectiveTagResponse();
        return TeaModel.build(map, self);
    }

    public TalentAddObjectiveTagResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public TalentAddObjectiveTagResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public TalentAddObjectiveTagResponse setBody(TalentAddObjectiveTagResponseBody body) {
        this.body = body;
        return this;
    }
    public TalentAddObjectiveTagResponseBody getBody() {
        return this.body;
    }

}
