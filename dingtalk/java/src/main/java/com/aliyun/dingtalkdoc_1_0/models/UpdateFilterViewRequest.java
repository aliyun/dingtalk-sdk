// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class UpdateFilterViewRequest extends TeaModel {
    @NameInMap("criteria")
    public java.util.Map<String, CriteriaValue> criteria;

    @NameInMap("name")
    public String name;

    @NameInMap("range")
    public String range;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    public static UpdateFilterViewRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateFilterViewRequest self = new UpdateFilterViewRequest();
        return TeaModel.build(map, self);
    }

    public UpdateFilterViewRequest setCriteria(java.util.Map<String, CriteriaValue> criteria) {
        this.criteria = criteria;
        return this;
    }
    public java.util.Map<String, CriteriaValue> getCriteria() {
        return this.criteria;
    }

    public UpdateFilterViewRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public UpdateFilterViewRequest setRange(String range) {
        this.range = range;
        return this;
    }
    public String getRange() {
        return this.range;
    }

    public UpdateFilterViewRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
