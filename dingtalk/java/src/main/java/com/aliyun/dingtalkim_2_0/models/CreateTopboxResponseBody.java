// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_2_0.models;

import com.aliyun.tea.*;

public class CreateTopboxResponseBody extends TeaModel {
    /**
     * <p>请求是否成功。</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static CreateTopboxResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateTopboxResponseBody self = new CreateTopboxResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateTopboxResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
