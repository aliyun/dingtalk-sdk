// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktalent_tag_1_0.models;

import com.aliyun.tea.*;

public class TalentV2LikeTagResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public TalentV2LikeTagResponseBody body;

    public static TalentV2LikeTagResponse build(java.util.Map<String, ?> map) throws Exception {
        TalentV2LikeTagResponse self = new TalentV2LikeTagResponse();
        return TeaModel.build(map, self);
    }

    public TalentV2LikeTagResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public TalentV2LikeTagResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public TalentV2LikeTagResponse setBody(TalentV2LikeTagResponseBody body) {
        this.body = body;
        return this;
    }
    public TalentV2LikeTagResponseBody getBody() {
        return this.body;
    }

}
