// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdevicemng_1_0.models;

import com.aliyun.tea.*;

public class ListInspectInfoResponseBody extends TeaModel {
    /**
     * <p>结果集</p>
     */
    @NameInMap("result")
    public java.util.List<ListInspectInfoResponseBodyResult> result;

    /**
     * <p>是否成功</p>
     */
    @NameInMap("success")
    public Boolean success;

    /**
     * <p>总共数量</p>
     */
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
        /**
         * <p>设备码</p>
         */
        @NameInMap("deviceCode")
        public String deviceCode;

        /**
         * <p>设备名称</p>
         */
        @NameInMap("deviceName")
        public String deviceName;

        /**
         * <p>创建时间</p>
         */
        @NameInMap("gmtCreate")
        public String gmtCreate;

        /**
         * <p>处理时间</p>
         */
        @NameInMap("handleTime")
        public String handleTime;

        /**
         * <p>维修人员</p>
         */
        @NameInMap("maintenanceStaff")
        public java.util.List<String> maintenanceStaff;

        /**
         * <p>巡检表名称</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>巡检/保养内容</p>
         */
        @NameInMap("remark")
        public String remark;

        /**
         * <p>处理结果（1:未修复，2:已修复）</p>
         */
        @NameInMap("repairStatus")
        public Integer repairStatus;

        /**
         * <p>巡检/保养结果：0:正常，1:异常</p>
         */
        @NameInMap("status")
        public Integer status;

        /**
         * <p>类型（inspect：巡检，protect：保养）</p>
         */
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
