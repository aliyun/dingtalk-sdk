// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksmart_device_1_0.models;

import com.aliyun.tea.*;

public class UpdateExportDeviceStatisticResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static UpdateExportDeviceStatisticResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateExportDeviceStatisticResponseBody self = new UpdateExportDeviceStatisticResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateExportDeviceStatisticResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
