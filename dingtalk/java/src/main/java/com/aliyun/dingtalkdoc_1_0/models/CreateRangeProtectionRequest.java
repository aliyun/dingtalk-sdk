// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class CreateRangeProtectionRequest extends TeaModel {
    // 其它用户的权限
    @NameInMap("otherUserPermission")
    public String otherUserPermission;

    // 操作人unionId
    @NameInMap("operatorId")
    public String operatorId;

    public static CreateRangeProtectionRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateRangeProtectionRequest self = new CreateRangeProtectionRequest();
        return TeaModel.build(map, self);
    }

    public CreateRangeProtectionRequest setOtherUserPermission(String otherUserPermission) {
        this.otherUserPermission = otherUserPermission;
        return this;
    }
    public String getOtherUserPermission() {
        return this.otherUserPermission;
    }

    public CreateRangeProtectionRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
