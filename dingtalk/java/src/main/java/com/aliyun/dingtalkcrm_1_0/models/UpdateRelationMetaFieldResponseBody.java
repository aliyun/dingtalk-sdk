// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class UpdateRelationMetaFieldResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("relationType")
    public String relationType;

    public static UpdateRelationMetaFieldResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateRelationMetaFieldResponseBody self = new UpdateRelationMetaFieldResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateRelationMetaFieldResponseBody setRelationType(String relationType) {
        this.relationType = relationType;
        return this;
    }
    public String getRelationType() {
        return this.relationType;
    }

}
