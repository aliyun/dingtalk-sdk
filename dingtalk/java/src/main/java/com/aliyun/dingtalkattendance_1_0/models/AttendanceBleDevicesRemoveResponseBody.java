// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class AttendanceBleDevicesRemoveResponseBody extends TeaModel {
    @NameInMap("errorList")
    public java.util.List<AttendanceBleDevicesRemoveResponseBodyErrorList> errorList;

    @NameInMap("successList")
    public java.util.List<Long> successList;

    public static AttendanceBleDevicesRemoveResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AttendanceBleDevicesRemoveResponseBody self = new AttendanceBleDevicesRemoveResponseBody();
        return TeaModel.build(map, self);
    }

    public AttendanceBleDevicesRemoveResponseBody setErrorList(java.util.List<AttendanceBleDevicesRemoveResponseBodyErrorList> errorList) {
        this.errorList = errorList;
        return this;
    }
    public java.util.List<AttendanceBleDevicesRemoveResponseBodyErrorList> getErrorList() {
        return this.errorList;
    }

    public AttendanceBleDevicesRemoveResponseBody setSuccessList(java.util.List<Long> successList) {
        this.successList = successList;
        return this;
    }
    public java.util.List<Long> getSuccessList() {
        return this.successList;
    }

    public static class AttendanceBleDevicesRemoveResponseBodyErrorList extends TeaModel {
        @NameInMap("code")
        public String code;

        @NameInMap("failureList")
        public java.util.List<Long> failureList;

        @NameInMap("msg")
        public String msg;

        public static AttendanceBleDevicesRemoveResponseBodyErrorList build(java.util.Map<String, ?> map) throws Exception {
            AttendanceBleDevicesRemoveResponseBodyErrorList self = new AttendanceBleDevicesRemoveResponseBodyErrorList();
            return TeaModel.build(map, self);
        }

        public AttendanceBleDevicesRemoveResponseBodyErrorList setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public AttendanceBleDevicesRemoveResponseBodyErrorList setFailureList(java.util.List<Long> failureList) {
            this.failureList = failureList;
            return this;
        }
        public java.util.List<Long> getFailureList() {
            return this.failureList;
        }

        public AttendanceBleDevicesRemoveResponseBodyErrorList setMsg(String msg) {
            this.msg = msg;
            return this;
        }
        public String getMsg() {
            return this.msg;
        }

    }

}
