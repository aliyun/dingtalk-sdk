// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdevicemng_1_0.models;

import com.aliyun.tea.*;

public class UpdateCardResponseBody extends TeaModel {
    // 响应数据
    @NameInMap("result")
    public String result;

    // 是否成功
    @NameInMap("success")
    public Boolean success;

    public static UpdateCardResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateCardResponseBody self = new UpdateCardResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateCardResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

    public UpdateCardResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
