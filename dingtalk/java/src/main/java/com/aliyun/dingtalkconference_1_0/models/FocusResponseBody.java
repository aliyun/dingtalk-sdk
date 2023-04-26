// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class FocusResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static FocusResponseBody build(java.util.Map<String, ?> map) throws Exception {
        FocusResponseBody self = new FocusResponseBody();
        return TeaModel.build(map, self);
    }

    public FocusResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
