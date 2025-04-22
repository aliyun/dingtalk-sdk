// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class ReadPersonalMessageResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static ReadPersonalMessageResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ReadPersonalMessageResponseBody self = new ReadPersonalMessageResponseBody();
        return TeaModel.build(map, self);
    }

    public ReadPersonalMessageResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
