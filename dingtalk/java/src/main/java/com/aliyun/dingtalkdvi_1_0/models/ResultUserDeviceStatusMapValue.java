// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class ResultUserDeviceStatusMapValue extends TeaModel {
    @NameInMap("sn")
    public String sn;

    @NameInMap("status")
    public ResultUserDeviceStatusMapValueStatus status;

    public static ResultUserDeviceStatusMapValue build(java.util.Map<String, ?> map) throws Exception {
        ResultUserDeviceStatusMapValue self = new ResultUserDeviceStatusMapValue();
        return TeaModel.build(map, self);
    }

    public ResultUserDeviceStatusMapValue setSn(String sn) {
        this.sn = sn;
        return this;
    }
    public String getSn() {
        return this.sn;
    }

    public ResultUserDeviceStatusMapValue setStatus(ResultUserDeviceStatusMapValueStatus status) {
        this.status = status;
        return this;
    }
    public ResultUserDeviceStatusMapValueStatus getStatus() {
        return this.status;
    }

    public static class ResultUserDeviceStatusMapValueStatus extends TeaModel {
        @NameInMap("value")
        public String value;

        public static ResultUserDeviceStatusMapValueStatus build(java.util.Map<String, ?> map) throws Exception {
            ResultUserDeviceStatusMapValueStatus self = new ResultUserDeviceStatusMapValueStatus();
            return TeaModel.build(map, self);
        }

        public ResultUserDeviceStatusMapValueStatus setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

}
