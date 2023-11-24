// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class EmployeeAttachmentUpdateResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    @NameInMap("success")
    public Boolean success;

    public static EmployeeAttachmentUpdateResponseBody build(java.util.Map<String, ?> map) throws Exception {
        EmployeeAttachmentUpdateResponseBody self = new EmployeeAttachmentUpdateResponseBody();
        return TeaModel.build(map, self);
    }

    public EmployeeAttachmentUpdateResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

    public EmployeeAttachmentUpdateResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
