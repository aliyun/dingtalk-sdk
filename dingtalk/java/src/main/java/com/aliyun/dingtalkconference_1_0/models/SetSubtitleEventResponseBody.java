// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class SetSubtitleEventResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static SetSubtitleEventResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SetSubtitleEventResponseBody self = new SetSubtitleEventResponseBody();
        return TeaModel.build(map, self);
    }

    public SetSubtitleEventResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
