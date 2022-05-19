// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class UpdateResidentInfoResponseBody extends TeaModel {
    // 是否成功
    @NameInMap("success")
    public Boolean success;

    public static UpdateResidentInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateResidentInfoResponseBody self = new UpdateResidentInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateResidentInfoResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
