// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class UpdateConvNavTabResponseBody extends TeaModel {
    @NameInMap("success")
    public String success;

    public static UpdateConvNavTabResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateConvNavTabResponseBody self = new UpdateConvNavTabResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateConvNavTabResponseBody setSuccess(String success) {
        this.success = success;
        return this;
    }
    public String getSuccess() {
        return this.success;
    }

}
