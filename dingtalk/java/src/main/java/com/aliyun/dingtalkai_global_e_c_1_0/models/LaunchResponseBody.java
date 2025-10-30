// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_global_e_c_1_0.models;

import com.aliyun.tea.*;

public class LaunchResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static LaunchResponseBody build(java.util.Map<String, ?> map) throws Exception {
        LaunchResponseBody self = new LaunchResponseBody();
        return TeaModel.build(map, self);
    }

    public LaunchResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
