// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class GroupManageReduceRequest extends TeaModel {
    /**
     * <p>群容量限定值</p>
     */
    @NameInMap("capacityLimit")
    public Integer capacityLimit;

    /**
     * <p>开放群id</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    /**
     * <p>扩展参数</p>
     */
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
