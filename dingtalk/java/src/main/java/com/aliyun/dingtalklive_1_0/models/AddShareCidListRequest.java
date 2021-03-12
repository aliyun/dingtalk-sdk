// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class AddShareCidListRequest extends TeaModel {
    // 操作的的组织内id(staffId)
    @NameInMap("userId")
    public String userId;

    // 添加的联播群列表
    @NameInMap("groupIds")
    public java.util.List<String> groupIds;

    // 传入的群id类型（1 chatId / 2 openConversationId ）
    @NameInMap("groupIdType")
    public Long groupIdType;

    public static AddShareCidListRequest build(java.util.Map<String, ?> map) throws Exception {
        AddShareCidListRequest self = new AddShareCidListRequest();
        return TeaModel.build(map, self);
    }

    public AddShareCidListRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public AddShareCidListRequest setGroupIds(java.util.List<String> groupIds) {
        this.groupIds = groupIds;
        return this;
    }
    public java.util.List<String> getGroupIds() {
        return this.groupIds;
    }

    public AddShareCidListRequest setGroupIdType(Long groupIdType) {
        this.groupIdType = groupIdType;
        return this;
    }
    public Long getGroupIdType() {
        return this.groupIdType;
    }

}
