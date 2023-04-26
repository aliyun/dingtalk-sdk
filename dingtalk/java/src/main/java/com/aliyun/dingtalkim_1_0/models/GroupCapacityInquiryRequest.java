// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class GroupCapacityInquiryRequest extends TeaModel {
    @NameInMap("effectiveDuration")
    public String effectiveDuration;

    @NameInMap("openConversationId")
    public String openConversationId;

    @NameInMap("operator")
    public String operator;

    @NameInMap("options")
    public java.util.Map<String, ?> options;

    @NameInMap("targetCapacity")
    public Integer targetCapacity;

    public static GroupCapacityInquiryRequest build(java.util.Map<String, ?> map) throws Exception {
        GroupCapacityInquiryRequest self = new GroupCapacityInquiryRequest();
        return TeaModel.build(map, self);
    }

    public GroupCapacityInquiryRequest setEffectiveDuration(String effectiveDuration) {
        this.effectiveDuration = effectiveDuration;
        return this;
    }
    public String getEffectiveDuration() {
        return this.effectiveDuration;
    }

    public GroupCapacityInquiryRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public GroupCapacityInquiryRequest setOperator(String operator) {
        this.operator = operator;
        return this;
    }
    public String getOperator() {
        return this.operator;
    }

    public GroupCapacityInquiryRequest setOptions(java.util.Map<String, ?> options) {
        this.options = options;
        return this;
    }
    public java.util.Map<String, ?> getOptions() {
        return this.options;
    }

    public GroupCapacityInquiryRequest setTargetCapacity(Integer targetCapacity) {
        this.targetCapacity = targetCapacity;
        return this;
    }
    public Integer getTargetCapacity() {
        return this.targetCapacity;
    }

}
