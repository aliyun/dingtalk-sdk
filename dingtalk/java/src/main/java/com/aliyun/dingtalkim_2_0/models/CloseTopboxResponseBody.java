// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_2_0.models;

import com.aliyun.tea.*;

public class CloseTopboxResponseBody extends TeaModel {
    // 请求是否成功。
    @NameInMap("success")
    public Boolean success;

    public static CloseTopboxResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CloseTopboxResponseBody self = new CloseTopboxResponseBody();
        return TeaModel.build(map, self);
    }

    public CloseTopboxResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
