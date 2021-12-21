// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class CreateRelationMetaResponseBody extends TeaModel {
    @NameInMap("relationType")
    public String relationType;

    public static CreateRelationMetaResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateRelationMetaResponseBody self = new CreateRelationMetaResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateRelationMetaResponseBody setRelationType(String relationType) {
        this.relationType = relationType;
        return this;
    }
    public String getRelationType() {
        return this.relationType;
    }

}
