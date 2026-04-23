// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktalent_tag_1_0.models;

import com.aliyun.tea.*;

public class TalentV2DeleteObjectiveTagResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public TalentV2DeleteObjectiveTagResponseBody body;

    public static TalentV2DeleteObjectiveTagResponse build(java.util.Map<String, ?> map) throws Exception {
        TalentV2DeleteObjectiveTagResponse self = new TalentV2DeleteObjectiveTagResponse();
        return TeaModel.build(map, self);
    }

    public TalentV2DeleteObjectiveTagResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public TalentV2DeleteObjectiveTagResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public TalentV2DeleteObjectiveTagResponse setBody(TalentV2DeleteObjectiveTagResponseBody body) {
        this.body = body;
        return this;
    }
    public TalentV2DeleteObjectiveTagResponseBody getBody() {
        return this.body;
    }

}
