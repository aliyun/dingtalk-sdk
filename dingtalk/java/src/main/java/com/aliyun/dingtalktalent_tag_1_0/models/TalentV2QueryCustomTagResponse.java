// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktalent_tag_1_0.models;

import com.aliyun.tea.*;

public class TalentV2QueryCustomTagResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public TalentV2QueryCustomTagResponseBody body;

    public static TalentV2QueryCustomTagResponse build(java.util.Map<String, ?> map) throws Exception {
        TalentV2QueryCustomTagResponse self = new TalentV2QueryCustomTagResponse();
        return TeaModel.build(map, self);
    }

    public TalentV2QueryCustomTagResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public TalentV2QueryCustomTagResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public TalentV2QueryCustomTagResponse setBody(TalentV2QueryCustomTagResponseBody body) {
        this.body = body;
        return this;
    }
    public TalentV2QueryCustomTagResponseBody getBody() {
        return this.body;
    }

}
