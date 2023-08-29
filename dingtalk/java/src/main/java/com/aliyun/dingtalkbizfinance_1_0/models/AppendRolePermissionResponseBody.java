// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class AppendRolePermissionResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static AppendRolePermissionResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AppendRolePermissionResponseBody self = new AppendRolePermissionResponseBody();
        return TeaModel.build(map, self);
    }

    public AppendRolePermissionResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
