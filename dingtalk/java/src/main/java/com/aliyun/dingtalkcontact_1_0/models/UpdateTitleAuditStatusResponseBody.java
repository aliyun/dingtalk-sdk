// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class UpdateTitleAuditStatusResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static UpdateTitleAuditStatusResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateTitleAuditStatusResponseBody self = new UpdateTitleAuditStatusResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateTitleAuditStatusResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
