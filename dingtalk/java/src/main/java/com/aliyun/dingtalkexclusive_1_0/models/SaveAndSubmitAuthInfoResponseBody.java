// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class SaveAndSubmitAuthInfoResponseBody extends TeaModel {
    // 是否成功。
    @NameInMap("success")
    public Boolean success;

    public static SaveAndSubmitAuthInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SaveAndSubmitAuthInfoResponseBody self = new SaveAndSubmitAuthInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public SaveAndSubmitAuthInfoResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
