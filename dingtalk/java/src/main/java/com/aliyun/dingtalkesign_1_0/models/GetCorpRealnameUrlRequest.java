// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_1_0.models;

import com.aliyun.tea.*;

public class GetCorpRealnameUrlRequest extends TeaModel {
    @NameInMap("userId")
    public String userId;

    public static GetCorpRealnameUrlRequest build(java.util.Map<String, ?> map) throws Exception {
        GetCorpRealnameUrlRequest self = new GetCorpRealnameUrlRequest();
        return TeaModel.build(map, self);
    }

    public GetCorpRealnameUrlRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
