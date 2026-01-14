// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class FileEncryptCallbackResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static FileEncryptCallbackResponseBody build(java.util.Map<String, ?> map) throws Exception {
        FileEncryptCallbackResponseBody self = new FileEncryptCallbackResponseBody();
        return TeaModel.build(map, self);
    }

    public FileEncryptCallbackResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
