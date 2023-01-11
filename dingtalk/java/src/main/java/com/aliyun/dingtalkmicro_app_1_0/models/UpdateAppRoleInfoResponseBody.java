// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class UpdateAppRoleInfoResponseBody extends TeaModel {
    /**
     * <p>更新结果</p>
     */
    @NameInMap("result")
    public Boolean result;

    public static UpdateAppRoleInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateAppRoleInfoResponseBody self = new UpdateAppRoleInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateAppRoleInfoResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
