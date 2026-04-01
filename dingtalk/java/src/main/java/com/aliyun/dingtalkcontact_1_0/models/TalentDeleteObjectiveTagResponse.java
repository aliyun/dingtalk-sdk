// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class TalentDeleteObjectiveTagResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public TalentDeleteObjectiveTagResponseBody body;

    public static TalentDeleteObjectiveTagResponse build(java.util.Map<String, ?> map) throws Exception {
        TalentDeleteObjectiveTagResponse self = new TalentDeleteObjectiveTagResponse();
        return TeaModel.build(map, self);
    }

    public TalentDeleteObjectiveTagResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public TalentDeleteObjectiveTagResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public TalentDeleteObjectiveTagResponse setBody(TalentDeleteObjectiveTagResponseBody body) {
        this.body = body;
        return this;
    }
    public TalentDeleteObjectiveTagResponseBody getBody() {
        return this.body;
    }

}
