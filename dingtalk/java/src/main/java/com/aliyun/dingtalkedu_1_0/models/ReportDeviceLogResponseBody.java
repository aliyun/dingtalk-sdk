// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class ReportDeviceLogResponseBody extends TeaModel {
    // 上传成功
    @NameInMap("success")
    public Boolean success;

    public static ReportDeviceLogResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ReportDeviceLogResponseBody self = new ReportDeviceLogResponseBody();
        return TeaModel.build(map, self);
    }

    public ReportDeviceLogResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
