// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class UpdateFilterRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("criteria")
    public java.util.Map<String, CriteriaValue> criteria;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    public static UpdateFilterRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateFilterRequest self = new UpdateFilterRequest();
        return TeaModel.build(map, self);
    }

    public UpdateFilterRequest setCriteria(java.util.Map<String, CriteriaValue> criteria) {
        this.criteria = criteria;
        return this;
    }
    public java.util.Map<String, CriteriaValue> getCriteria() {
        return this.criteria;
    }

    public UpdateFilterRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
