// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class RecallPersonalMessageResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static RecallPersonalMessageResponseBody build(java.util.Map<String, ?> map) throws Exception {
        RecallPersonalMessageResponseBody self = new RecallPersonalMessageResponseBody();
        return TeaModel.build(map, self);
    }

    public RecallPersonalMessageResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
