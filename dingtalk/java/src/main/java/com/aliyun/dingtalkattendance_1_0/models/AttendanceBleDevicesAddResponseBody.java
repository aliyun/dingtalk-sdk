// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class AttendanceBleDevicesAddResponseBody extends TeaModel {
    // 添加错误列表
    @NameInMap("errorList")
    public java.util.List<AttendanceBleDevicesAddResponseBodyErrorList> errorList;

    // 添加成功蓝牙设备列表
    @NameInMap("successList")
    public java.util.List<AttendanceBleDevicesAddResponseBodySuccessList> successList;

    public static AttendanceBleDevicesAddResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AttendanceBleDevicesAddResponseBody self = new AttendanceBleDevicesAddResponseBody();
        return TeaModel.build(map, self);
    }

    public AttendanceBleDevicesAddResponseBody setErrorList(java.util.List<AttendanceBleDevicesAddResponseBodyErrorList> errorList) {
        this.errorList = errorList;
        return this;
    }
    public java.util.List<AttendanceBleDevicesAddResponseBodyErrorList> getErrorList() {
        return this.errorList;
    }

    public AttendanceBleDevicesAddResponseBody setSuccessList(java.util.List<AttendanceBleDevicesAddResponseBodySuccessList> successList) {
        this.successList = successList;
        return this;
    }
    public java.util.List<AttendanceBleDevicesAddResponseBodySuccessList> getSuccessList() {
        return this.successList;
    }

    public static class AttendanceBleDevicesAddResponseBodyErrorListFailureList extends TeaModel {
        // 蓝牙设备Id
        @NameInMap("deviceId")
        public Long deviceId;

        // 蓝牙设备名称
        @NameInMap("deviceName")
        public String deviceName;

        // sn
        @NameInMap("sn")
        public String sn;

        public static AttendanceBleDevicesAddResponseBodyErrorListFailureList build(java.util.Map<String, ?> map) throws Exception {
            AttendanceBleDevicesAddResponseBodyErrorListFailureList self = new AttendanceBleDevicesAddResponseBodyErrorListFailureList();
            return TeaModel.build(map, self);
        }

        public AttendanceBleDevicesAddResponseBodyErrorListFailureList setDeviceId(Long deviceId) {
            this.deviceId = deviceId;
            return this;
        }
        public Long getDeviceId() {
            return this.deviceId;
        }

        public AttendanceBleDevicesAddResponseBodyErrorListFailureList setDeviceName(String deviceName) {
            this.deviceName = deviceName;
            return this;
        }
        public String getDeviceName() {
            return this.deviceName;
        }

        public AttendanceBleDevicesAddResponseBodyErrorListFailureList setSn(String sn) {
            this.sn = sn;
            return this;
        }
        public String getSn() {
            return this.sn;
        }

    }

    public static class AttendanceBleDevicesAddResponseBodyErrorList extends TeaModel {
        // 错误code
        @NameInMap("code")
        public String code;

        // 失败蓝牙设备列表
        @NameInMap("failureList")
        public java.util.List<AttendanceBleDevicesAddResponseBodyErrorListFailureList> failureList;

        // errorMsg
        @NameInMap("msg")
        public String msg;

        public static AttendanceBleDevicesAddResponseBodyErrorList build(java.util.Map<String, ?> map) throws Exception {
            AttendanceBleDevicesAddResponseBodyErrorList self = new AttendanceBleDevicesAddResponseBodyErrorList();
            return TeaModel.build(map, self);
        }

        public AttendanceBleDevicesAddResponseBodyErrorList setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public AttendanceBleDevicesAddResponseBodyErrorList setFailureList(java.util.List<AttendanceBleDevicesAddResponseBodyErrorListFailureList> failureList) {
            this.failureList = failureList;
            return this;
        }
        public java.util.List<AttendanceBleDevicesAddResponseBodyErrorListFailureList> getFailureList() {
            return this.failureList;
        }

        public AttendanceBleDevicesAddResponseBodyErrorList setMsg(String msg) {
            this.msg = msg;
            return this;
        }
        public String getMsg() {
            return this.msg;
        }

    }

    public static class AttendanceBleDevicesAddResponseBodySuccessList extends TeaModel {
        // 蓝牙设备Id
        @NameInMap("deviceId")
        public Long deviceId;

        // 蓝牙设备名称
        @NameInMap("deviceName")
        public String deviceName;

        // sn
        @NameInMap("sn")
        public String sn;

        public static AttendanceBleDevicesAddResponseBodySuccessList build(java.util.Map<String, ?> map) throws Exception {
            AttendanceBleDevicesAddResponseBodySuccessList self = new AttendanceBleDevicesAddResponseBodySuccessList();
            return TeaModel.build(map, self);
        }

        public AttendanceBleDevicesAddResponseBodySuccessList setDeviceId(Long deviceId) {
            this.deviceId = deviceId;
            return this;
        }
        public Long getDeviceId() {
            return this.deviceId;
        }

        public AttendanceBleDevicesAddResponseBodySuccessList setDeviceName(String deviceName) {
            this.deviceName = deviceName;
            return this;
        }
        public String getDeviceName() {
            return this.deviceName;
        }

        public AttendanceBleDevicesAddResponseBodySuccessList setSn(String sn) {
            this.sn = sn;
            return this;
        }
        public String getSn() {
            return this.sn;
        }

    }

}
