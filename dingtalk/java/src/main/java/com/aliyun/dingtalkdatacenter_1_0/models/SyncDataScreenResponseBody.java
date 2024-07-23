// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class SyncDataScreenResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    @NameInMap("success")
    public Boolean success;

    public static SyncDataScreenResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SyncDataScreenResponseBody self = new SyncDataScreenResponseBody();
        return TeaModel.build(map, self);
    }

    public SyncDataScreenResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

    public SyncDataScreenResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
