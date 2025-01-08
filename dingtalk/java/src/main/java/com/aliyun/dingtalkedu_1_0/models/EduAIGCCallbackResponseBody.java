// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class EduAIGCCallbackResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static EduAIGCCallbackResponseBody build(java.util.Map<String, ?> map) throws Exception {
        EduAIGCCallbackResponseBody self = new EduAIGCCallbackResponseBody();
        return TeaModel.build(map, self);
    }

    public EduAIGCCallbackResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
