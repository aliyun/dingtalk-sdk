// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktalent_tag_1_0.models;

import com.aliyun.tea.*;

public class TalentV2AddObjectiveTagResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public TalentV2AddObjectiveTagResponseBody body;

    public static TalentV2AddObjectiveTagResponse build(java.util.Map<String, ?> map) throws Exception {
        TalentV2AddObjectiveTagResponse self = new TalentV2AddObjectiveTagResponse();
        return TeaModel.build(map, self);
    }

    public TalentV2AddObjectiveTagResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public TalentV2AddObjectiveTagResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public TalentV2AddObjectiveTagResponse setBody(TalentV2AddObjectiveTagResponseBody body) {
        this.body = body;
        return this;
    }
    public TalentV2AddObjectiveTagResponseBody getBody() {
        return this.body;
    }

}
