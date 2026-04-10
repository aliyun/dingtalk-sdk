// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class FileDecryptCallbackResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static FileDecryptCallbackResponseBody build(java.util.Map<String, ?> map) throws Exception {
        FileDecryptCallbackResponseBody self = new FileDecryptCallbackResponseBody();
        return TeaModel.build(map, self);
    }

    public FileDecryptCallbackResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
