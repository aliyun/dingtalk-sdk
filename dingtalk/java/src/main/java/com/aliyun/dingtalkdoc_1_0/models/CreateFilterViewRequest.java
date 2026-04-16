// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class CreateFilterViewRequest extends TeaModel {
    @NameInMap("criteria")
    public java.util.Map<String, CriteriaValue> criteria;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("name")
    public String name;

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

    public static CreateFilterViewRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateFilterViewRequest self = new CreateFilterViewRequest();
        return TeaModel.build(map, self);
    }

    public CreateFilterViewRequest setCriteria(java.util.Map<String, CriteriaValue> criteria) {
        this.criteria = criteria;
        return this;
    }
    public java.util.Map<String, CriteriaValue> getCriteria() {
        return this.criteria;
    }

    public CreateFilterViewRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public CreateFilterViewRequest setRange(String range) {
        this.range = range;
        return this;
    }
    public String getRange() {
        return this.range;
    }

    public CreateFilterViewRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
