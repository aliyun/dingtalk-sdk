// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class MuteAllResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static MuteAllResponseBody build(java.util.Map<String, ?> map) throws Exception {
        MuteAllResponseBody self = new MuteAllResponseBody();
        return TeaModel.build(map, self);
    }

    public MuteAllResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
