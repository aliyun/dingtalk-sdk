// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkokr_1_0.models;

import com.aliyun.tea.*;

public class DeleteKeyResultResponseBody extends TeaModel {
    // 返回的信息
    @NameInMap("data")
    public Boolean data;

    // 请求成功的标识。
    @NameInMap("success")
    public Boolean success;

    public static DeleteKeyResultResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeleteKeyResultResponseBody self = new DeleteKeyResultResponseBody();
        return TeaModel.build(map, self);
    }

    public DeleteKeyResultResponseBody setData(Boolean data) {
        this.data = data;
        return this;
    }
    public Boolean getData() {
        return this.data;
    }

    public DeleteKeyResultResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
