// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdevicemng_1_0.models;

import com.aliyun.tea.*;

public class ListInspectInfoResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<ListInspectInfoResponseBodyResult> result;

    @NameInMap("success")
    public Boolean success;

    @NameInMap("totalCount")
    public Long totalCount;

    public static ListInspectInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListInspectInfoResponseBody self = new ListInspectInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public ListInspectInfoResponseBody setResult(java.util.List<ListInspectInfoResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<ListInspectInfoResponseBodyResult> getResult() {
        return this.result;
    }

    public ListInspectInfoResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public ListInspectInfoResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public static class ListInspectInfoResponseBodyResult extends TeaModel {
        @NameInMap("deviceCode")
        public String deviceCode;

        @NameInMap("deviceName")
        public String deviceName;

        @NameInMap("gmtCreate")
        public String gmtCreate;

        @NameInMap("handleTime")
        public String handleTime;

        @NameInMap("maintenanceStaff")
        public java.util.List<String> maintenanceStaff;

        @NameInMap("name")
        public String name;

        @NameInMap("remark")
        public String remark;

        @NameInMap("repairStatus")
        public Integer repairStatus;

        @NameInMap("status")
        public Integer status;

        @NameInMap("type")
        public String type;

        public static ListInspectInfoResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            ListInspectInfoResponseBodyResult self = new ListInspectInfoResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public ListInspectInfoResponseBodyResult setDeviceCode(String deviceCode) {
            this.deviceCode = deviceCode;
            return this;
        }
        public String getDeviceCode() {
            return this.deviceCode;
        }

        public ListInspectInfoResponseBodyResult setDeviceName(String deviceName) {
            this.deviceName = deviceName;
            return this;
        }
        public String getDeviceName() {
            return this.deviceName;
        }

        public ListInspectInfoResponseBodyResult setGmtCreate(String gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public String getGmtCreate() {
            return this.gmtCreate;
        }

        public ListInspectInfoResponseBodyResult setHandleTime(String handleTime) {
            this.handleTime = handleTime;
            return this;
        }
        public String getHandleTime() {
            return this.handleTime;
        }

        public ListInspectInfoResponseBodyResult setMaintenanceStaff(java.util.List<String> maintenanceStaff) {
            this.maintenanceStaff = maintenanceStaff;
            return this;
        }
        public java.util.List<String> getMaintenanceStaff() {
            return this.maintenanceStaff;
        }

        public ListInspectInfoResponseBodyResult setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ListInspectInfoResponseBodyResult setRemark(String remark) {
            this.remark = remark;
            return this;
        }
        public String getRemark() {
            return this.remark;
        }

        public ListInspectInfoResponseBodyResult setRepairStatus(Integer repairStatus) {
            this.repairStatus = repairStatus;
            return this;
        }
        public Integer getRepairStatus() {
            return this.repairStatus;
        }

        public ListInspectInfoResponseBodyResult setStatus(Integer status) {
            this.status = status;
            return this;
        }
        public Integer getStatus() {
            return this.status;
        }

        public ListInspectInfoResponseBodyResult setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

}
