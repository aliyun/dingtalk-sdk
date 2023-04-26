// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class PinSpaceResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static PinSpaceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        PinSpaceResponseBody self = new PinSpaceResponseBody();
        return TeaModel.build(map, self);
    }

    public PinSpaceResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
