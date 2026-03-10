// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class SubmitHandoverResourceResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static SubmitHandoverResourceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SubmitHandoverResourceResponseBody self = new SubmitHandoverResourceResponseBody();
        return TeaModel.build(map, self);
    }

    public SubmitHandoverResourceResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
