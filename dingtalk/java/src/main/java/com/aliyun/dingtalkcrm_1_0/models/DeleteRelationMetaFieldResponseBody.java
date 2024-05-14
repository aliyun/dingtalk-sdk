// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class DeleteRelationMetaFieldResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("relationType")
    public String relationType;

    public static DeleteRelationMetaFieldResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeleteRelationMetaFieldResponseBody self = new DeleteRelationMetaFieldResponseBody();
        return TeaModel.build(map, self);
    }

    public DeleteRelationMetaFieldResponseBody setRelationType(String relationType) {
        this.relationType = relationType;
        return this;
    }
    public String getRelationType() {
        return this.relationType;
    }

}
