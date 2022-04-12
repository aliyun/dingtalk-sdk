// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class GetCrmRolePermissionRequest extends TeaModel {
    // 表单bizType
    @NameInMap("bizType")
    public String bizType;

    public static GetCrmRolePermissionRequest build(java.util.Map<String, ?> map) throws Exception {
        GetCrmRolePermissionRequest self = new GetCrmRolePermissionRequest();
        return TeaModel.build(map, self);
    }

    public GetCrmRolePermissionRequest setBizType(String bizType) {
        this.bizType = bizType;
        return this;
    }
    public String getBizType() {
        return this.bizType;
    }

}
