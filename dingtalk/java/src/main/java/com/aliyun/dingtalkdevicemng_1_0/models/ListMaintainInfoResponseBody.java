// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdevicemng_1_0.models;

import com.aliyun.tea.*;

public class ListMaintainInfoResponseBody extends TeaModel {
    // 结果集
    @NameInMap("result")
    public java.util.List<ListMaintainInfoResponseBodyResult> result;

    // 是否成功
    @NameInMap("success")
    public Boolean success;

    // 总共的数量
    @NameInMap("totalCount")
    public Long totalCount;

    public static ListMaintainInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListMaintainInfoResponseBody self = new ListMaintainInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public ListMaintainInfoResponseBody setResult(java.util.List<ListMaintainInfoResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<ListMaintainInfoResponseBodyResult> getResult() {
        return this.result;
    }

    public ListMaintainInfoResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public ListMaintainInfoResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public static class ListMaintainInfoResponseBodyResult extends TeaModel {
        // 报修设备码
        @NameInMap("deviceCode")
        public String deviceCode;

        // 设备名称
        @NameInMap("deviceName")
        public String deviceName;

        // 报修时间
        @NameInMap("gmtCreate")
        public String gmtCreate;

        // 处理时间
        @NameInMap("handleTime")
        public String handleTime;

        // 报修人
        @NameInMap("maintenanceStaff")
        public java.util.List<String> maintenanceStaff;

        // 处理结果，0:同意，1:拒绝，2:终止，3:删除，4:进行中
        @NameInMap("processState")
        public Integer processState;

        // 异常描述
        @NameInMap("remark")
        public String remark;

        public static ListMaintainInfoResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            ListMaintainInfoResponseBodyResult self = new ListMaintainInfoResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public ListMaintainInfoResponseBodyResult setDeviceCode(String deviceCode) {
            this.deviceCode = deviceCode;
            return this;
        }
        public String getDeviceCode() {
            return this.deviceCode;
        }

        public ListMaintainInfoResponseBodyResult setDeviceName(String deviceName) {
            this.deviceName = deviceName;
            return this;
        }
        public String getDeviceName() {
            return this.deviceName;
        }

        public ListMaintainInfoResponseBodyResult setGmtCreate(String gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public String getGmtCreate() {
            return this.gmtCreate;
        }

        public ListMaintainInfoResponseBodyResult setHandleTime(String handleTime) {
            this.handleTime = handleTime;
            return this;
        }
        public String getHandleTime() {
            return this.handleTime;
        }

        public ListMaintainInfoResponseBodyResult setMaintenanceStaff(java.util.List<String> maintenanceStaff) {
            this.maintenanceStaff = maintenanceStaff;
            return this;
        }
        public java.util.List<String> getMaintenanceStaff() {
            return this.maintenanceStaff;
        }

        public ListMaintainInfoResponseBodyResult setProcessState(Integer processState) {
            this.processState = processState;
            return this;
        }
        public Integer getProcessState() {
            return this.processState;
        }

        public ListMaintainInfoResponseBodyResult setRemark(String remark) {
            this.remark = remark;
            return this;
        }
        public String getRemark() {
            return this.remark;
        }

    }

}
