// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class GetSceneGroupTemplateMessageOpenStatusResponseBody extends TeaModel {
    @NameInMap("status")
    public Integer status;

    @NameInMap("success")
    public Boolean success;

    public static GetSceneGroupTemplateMessageOpenStatusResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetSceneGroupTemplateMessageOpenStatusResponseBody self = new GetSceneGroupTemplateMessageOpenStatusResponseBody();
        return TeaModel.build(map, self);
    }

    public GetSceneGroupTemplateMessageOpenStatusResponseBody setStatus(Integer status) {
        this.status = status;
        return this;
    }
    public Integer getStatus() {
        return this.status;
    }

    public GetSceneGroupTemplateMessageOpenStatusResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
