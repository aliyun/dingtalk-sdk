// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class DeleteAppRoleResponseBody extends TeaModel {
    /**
     * <p>删除结果</p>
     */
    @NameInMap("result")
    public Boolean result;

    public static DeleteAppRoleResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeleteAppRoleResponseBody self = new DeleteAppRoleResponseBody();
        return TeaModel.build(map, self);
    }

    public DeleteAppRoleResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
