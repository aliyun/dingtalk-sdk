// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class CreateManagementGroupResponseBody extends TeaModel {
    /**
     * <p>返回管理组groupId</p>
     */
    @NameInMap("groupId")
    public String groupId;

    public static CreateManagementGroupResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateManagementGroupResponseBody self = new CreateManagementGroupResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateManagementGroupResponseBody setGroupId(String groupId) {
        this.groupId = groupId;
        return this;
    }
    public String getGroupId() {
        return this.groupId;
    }

}
