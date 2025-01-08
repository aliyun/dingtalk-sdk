// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class AddCustomSignConfigResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static AddCustomSignConfigResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AddCustomSignConfigResponseBody self = new AddCustomSignConfigResponseBody();
        return TeaModel.build(map, self);
    }

    public AddCustomSignConfigResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
