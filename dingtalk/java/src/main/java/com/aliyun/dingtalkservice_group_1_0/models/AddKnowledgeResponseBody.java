// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class AddKnowledgeResponseBody extends TeaModel {
    @NameInMap("openKnowledgeId")
    public String openKnowledgeId;

    public static AddKnowledgeResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AddKnowledgeResponseBody self = new AddKnowledgeResponseBody();
        return TeaModel.build(map, self);
    }

    public AddKnowledgeResponseBody setOpenKnowledgeId(String openKnowledgeId) {
        this.openKnowledgeId = openKnowledgeId;
        return this;
    }
    public String getOpenKnowledgeId() {
        return this.openKnowledgeId;
    }

}
