// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class TalentLikeTagResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public TalentLikeTagResponseBody body;

    public static TalentLikeTagResponse build(java.util.Map<String, ?> map) throws Exception {
        TalentLikeTagResponse self = new TalentLikeTagResponse();
        return TeaModel.build(map, self);
    }

    public TalentLikeTagResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public TalentLikeTagResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public TalentLikeTagResponse setBody(TalentLikeTagResponseBody body) {
        this.body = body;
        return this;
    }
    public TalentLikeTagResponseBody getBody() {
        return this.body;
    }

}
