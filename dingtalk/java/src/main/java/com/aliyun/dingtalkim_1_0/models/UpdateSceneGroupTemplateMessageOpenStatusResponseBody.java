// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class UpdateSceneGroupTemplateMessageOpenStatusResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static UpdateSceneGroupTemplateMessageOpenStatusResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateSceneGroupTemplateMessageOpenStatusResponseBody self = new UpdateSceneGroupTemplateMessageOpenStatusResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateSceneGroupTemplateMessageOpenStatusResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
