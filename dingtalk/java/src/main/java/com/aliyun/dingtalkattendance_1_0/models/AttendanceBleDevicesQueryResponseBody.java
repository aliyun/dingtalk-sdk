// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class AttendanceBleDevicesQueryResponseBody extends TeaModel {
    /**
     * <p>蓝牙列表</p>
     */
    @NameInMap("result")
    public java.util.List<AttendanceBleDevicesQueryResponseBodyResult> result;

    public static AttendanceBleDevicesQueryResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AttendanceBleDevicesQueryResponseBody self = new AttendanceBleDevicesQueryResponseBody();
        return TeaModel.build(map, self);
    }

    public AttendanceBleDevicesQueryResponseBody setResult(java.util.List<AttendanceBleDevicesQueryResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<AttendanceBleDevicesQueryResponseBodyResult> getResult() {
        return this.result;
    }

    public static class AttendanceBleDevicesQueryResponseBodyResult extends TeaModel {
        /**
         * <p>蓝牙设备Id</p>
         */
        @NameInMap("deviceId")
        public Long deviceId;

        /**
         * <p>蓝牙设备名称</p>
         */
        @NameInMap("deviceName")
        public String deviceName;

        /**
         * <p>sn</p>
         */
        @NameInMap("sn")
        public String sn;

        public static AttendanceBleDevicesQueryResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            AttendanceBleDevicesQueryResponseBodyResult self = new AttendanceBleDevicesQueryResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public AttendanceBleDevicesQueryResponseBodyResult setDeviceId(Long deviceId) {
            this.deviceId = deviceId;
            return this;
        }
        public Long getDeviceId() {
            return this.deviceId;
        }

        public AttendanceBleDevicesQueryResponseBodyResult setDeviceName(String deviceName) {
            this.deviceName = deviceName;
            return this;
        }
        public String getDeviceName() {
            return this.deviceName;
        }

        public AttendanceBleDevicesQueryResponseBodyResult setSn(String sn) {
            this.sn = sn;
            return this;
        }
        public String getSn() {
            return this.sn;
        }

    }

}
