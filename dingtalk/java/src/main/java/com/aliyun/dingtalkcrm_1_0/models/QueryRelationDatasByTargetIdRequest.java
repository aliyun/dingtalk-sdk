// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class QueryRelationDatasByTargetIdRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("relationType")
    public String relationType;

    public static QueryRelationDatasByTargetIdRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryRelationDatasByTargetIdRequest self = new QueryRelationDatasByTargetIdRequest();
        return TeaModel.build(map, self);
    }

    public QueryRelationDatasByTargetIdRequest setRelationType(String relationType) {
        this.relationType = relationType;
        return this;
    }
    public String getRelationType() {
        return this.relationType;
    }

}
