// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class BatchQueryUserDeviceStatusResponseBody extends TeaModel {
    @NameInMap("result")
    public BatchQueryUserDeviceStatusResponseBodyResult result;

    public static BatchQueryUserDeviceStatusResponseBody build(java.util.Map<String, ?> map) throws Exception {
        BatchQueryUserDeviceStatusResponseBody self = new BatchQueryUserDeviceStatusResponseBody();
        return TeaModel.build(map, self);
    }

    public BatchQueryUserDeviceStatusResponseBody setResult(BatchQueryUserDeviceStatusResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public BatchQueryUserDeviceStatusResponseBodyResult getResult() {
        return this.result;
    }

    public static class BatchQueryUserDeviceStatusResponseBodyResult extends TeaModel {
        @NameInMap("userDeviceStatusMap")
        public java.util.Map<String, java.util.List<ResultUserDeviceStatusMapValue>> userDeviceStatusMap;

        public static BatchQueryUserDeviceStatusResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            BatchQueryUserDeviceStatusResponseBodyResult self = new BatchQueryUserDeviceStatusResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public BatchQueryUserDeviceStatusResponseBodyResult setUserDeviceStatusMap(java.util.Map<String, java.util.List<ResultUserDeviceStatusMapValue>> userDeviceStatusMap) {
            this.userDeviceStatusMap = userDeviceStatusMap;
            return this;
        }
        public java.util.Map<String, java.util.List<ResultUserDeviceStatusMapValue>> getUserDeviceStatusMap() {
            return this.userDeviceStatusMap;
        }

    }

}
