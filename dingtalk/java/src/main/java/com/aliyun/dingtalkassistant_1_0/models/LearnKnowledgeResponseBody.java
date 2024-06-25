// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0.models;

import com.aliyun.tea.*;

public class LearnKnowledgeResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static LearnKnowledgeResponseBody build(java.util.Map<String, ?> map) throws Exception {
        LearnKnowledgeResponseBody self = new LearnKnowledgeResponseBody();
        return TeaModel.build(map, self);
    }

    public LearnKnowledgeResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
