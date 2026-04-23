// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktalent_tag_1_0.models;

import com.aliyun.tea.*;

public class TalentV2QueryObjectiveTagResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public TalentV2QueryObjectiveTagResponseBody body;

    public static TalentV2QueryObjectiveTagResponse build(java.util.Map<String, ?> map) throws Exception {
        TalentV2QueryObjectiveTagResponse self = new TalentV2QueryObjectiveTagResponse();
        return TeaModel.build(map, self);
    }

    public TalentV2QueryObjectiveTagResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public TalentV2QueryObjectiveTagResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public TalentV2QueryObjectiveTagResponse setBody(TalentV2QueryObjectiveTagResponseBody body) {
        this.body = body;
        return this;
    }
    public TalentV2QueryObjectiveTagResponseBody getBody() {
        return this.body;
    }

}
