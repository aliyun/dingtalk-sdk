// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class GroupManageReduceRequest extends TeaModel {
    // 群容量限定值
    @NameInMap("capacityLimit")
    public Integer capacityLimit;

    // 开放群id
    @NameInMap("openConversationId")
    public String openConversationId;

    // 扩展参数
    @NameInMap("options")
    public java.util.Map<String, ?> options;

    public static GroupManageReduceRequest build(java.util.Map<String, ?> map) throws Exception {
        GroupManageReduceRequest self = new GroupManageReduceRequest();
        return TeaModel.build(map, self);
    }

    public GroupManageReduceRequest setCapacityLimit(Integer capacityLimit) {
        this.capacityLimit = capacityLimit;
        return this;
    }
    public Integer getCapacityLimit() {
        return this.capacityLimit;
    }

    public GroupManageReduceRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public GroupManageReduceRequest setOptions(java.util.Map<String, ?> options) {
        this.options = options;
        return this;
    }
    public java.util.Map<String, ?> getOptions() {
        return this.options;
    }

}
