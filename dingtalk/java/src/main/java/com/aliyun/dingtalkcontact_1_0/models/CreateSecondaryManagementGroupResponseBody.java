// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class CreateSecondaryManagementGroupResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("groupId")
    public String groupId;

    public static CreateSecondaryManagementGroupResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateSecondaryManagementGroupResponseBody self = new CreateSecondaryManagementGroupResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateSecondaryManagementGroupResponseBody setGroupId(String groupId) {
        this.groupId = groupId;
        return this;
    }
    public String getGroupId() {
        return this.groupId;
    }

}
