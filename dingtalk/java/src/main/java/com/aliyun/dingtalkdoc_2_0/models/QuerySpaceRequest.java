// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class QuerySpaceRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    public static QuerySpaceRequest build(java.util.Map<String, ?> map) throws Exception {
        QuerySpaceRequest self = new QuerySpaceRequest();
        return TeaModel.build(map, self);
    }

    public QuerySpaceRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
