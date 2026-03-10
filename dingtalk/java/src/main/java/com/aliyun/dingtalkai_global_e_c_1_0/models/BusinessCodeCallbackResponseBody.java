// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_global_e_c_1_0.models;

import com.aliyun.tea.*;

public class BusinessCodeCallbackResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static BusinessCodeCallbackResponseBody build(java.util.Map<String, ?> map) throws Exception {
        BusinessCodeCallbackResponseBody self = new BusinessCodeCallbackResponseBody();
        return TeaModel.build(map, self);
    }

    public BusinessCodeCallbackResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
