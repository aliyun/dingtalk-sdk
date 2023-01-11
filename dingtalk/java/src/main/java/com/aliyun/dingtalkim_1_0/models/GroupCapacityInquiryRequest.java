// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class GroupCapacityInquiryRequest extends TeaModel {
    /**
     * <p>有效生命周期</p>
     */
    @NameInMap("effectiveDuration")
    public String effectiveDuration;

    /**
     * <p>开放的群id</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    /**
     * <p>当前操作人工号</p>
     */
    @NameInMap("operator")
    public String operator;

    /**
     * <p>扩展参数</p>
     */
    @NameInMap("options")
    public java.util.Map<String, ?> options;

    /**
     * <p>目标容量</p>
     */
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
