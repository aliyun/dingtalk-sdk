// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class PostCorpAuthInfoResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static PostCorpAuthInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        PostCorpAuthInfoResponseBody self = new PostCorpAuthInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public PostCorpAuthInfoResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
