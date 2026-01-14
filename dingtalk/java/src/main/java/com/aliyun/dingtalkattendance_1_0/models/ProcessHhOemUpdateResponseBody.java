// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class ProcessHhOemUpdateResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static ProcessHhOemUpdateResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ProcessHhOemUpdateResponseBody self = new ProcessHhOemUpdateResponseBody();
        return TeaModel.build(map, self);
    }

    public ProcessHhOemUpdateResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
