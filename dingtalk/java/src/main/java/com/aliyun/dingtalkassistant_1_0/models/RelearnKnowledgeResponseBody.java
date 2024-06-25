// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0.models;

import com.aliyun.tea.*;

public class RelearnKnowledgeResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static RelearnKnowledgeResponseBody build(java.util.Map<String, ?> map) throws Exception {
        RelearnKnowledgeResponseBody self = new RelearnKnowledgeResponseBody();
        return TeaModel.build(map, self);
    }

    public RelearnKnowledgeResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
