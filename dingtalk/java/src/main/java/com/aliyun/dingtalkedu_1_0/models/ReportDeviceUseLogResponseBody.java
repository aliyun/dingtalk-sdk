// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class ReportDeviceUseLogResponseBody extends TeaModel {
    // 返回结果
    @NameInMap("success")
    public Boolean success;

    public static ReportDeviceUseLogResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ReportDeviceUseLogResponseBody self = new ReportDeviceUseLogResponseBody();
        return TeaModel.build(map, self);
    }

    public ReportDeviceUseLogResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
