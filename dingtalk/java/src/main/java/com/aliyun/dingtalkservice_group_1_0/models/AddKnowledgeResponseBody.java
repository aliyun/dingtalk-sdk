// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class AddKnowledgeResponseBody extends TeaModel {
    @NameInMap("result")
    public AddKnowledgeResponseBodyResult result;

    public static AddKnowledgeResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AddKnowledgeResponseBody self = new AddKnowledgeResponseBody();
        return TeaModel.build(map, self);
    }

    public AddKnowledgeResponseBody setResult(AddKnowledgeResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public AddKnowledgeResponseBodyResult getResult() {
        return this.result;
    }

    public static class AddKnowledgeResponseBodyResult extends TeaModel {
        // 开放知识点ID
        @NameInMap("openKnowledgeId")
        public String openKnowledgeId;

        public static AddKnowledgeResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            AddKnowledgeResponseBodyResult self = new AddKnowledgeResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public AddKnowledgeResponseBodyResult setOpenKnowledgeId(String openKnowledgeId) {
            this.openKnowledgeId = openKnowledgeId;
            return this;
        }
        public String getOpenKnowledgeId() {
            return this.openKnowledgeId;
        }

    }

}
