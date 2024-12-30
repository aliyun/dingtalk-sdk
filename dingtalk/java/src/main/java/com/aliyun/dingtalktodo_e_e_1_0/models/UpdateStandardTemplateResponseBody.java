// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_e_e_1_0.models;

import com.aliyun.tea.*;

public class UpdateStandardTemplateResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static UpdateStandardTemplateResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateStandardTemplateResponseBody self = new UpdateStandardTemplateResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateStandardTemplateResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
