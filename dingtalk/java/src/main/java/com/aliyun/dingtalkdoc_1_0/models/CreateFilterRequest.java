// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class CreateFilterRequest extends TeaModel {
    @NameInMap("criteria")
    public java.util.Map<String, CriteriaValue> criteria;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("range")
    public String range;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    public static CreateFilterRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateFilterRequest self = new CreateFilterRequest();
        return TeaModel.build(map, self);
    }

    public CreateFilterRequest setCriteria(java.util.Map<String, CriteriaValue> criteria) {
        this.criteria = criteria;
        return this;
    }
    public java.util.Map<String, CriteriaValue> getCriteria() {
        return this.criteria;
    }

    public CreateFilterRequest setRange(String range) {
        this.range = range;
        return this;
    }
    public String getRange() {
        return this.range;
    }

    public CreateFilterRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
