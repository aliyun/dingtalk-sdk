// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class GetManageProcessByStaffIdResponseBody extends TeaModel {
    // 请求ID。
    @NameInMap("requestId")
    public String requestId;

    // 返回结果列表。
    @NameInMap("result")
    public java.util.List<GetManageProcessByStaffIdResponseBodyResult> result;

    // 接口调用是否成功。
    @NameInMap("success")
    public Boolean success;

    public static GetManageProcessByStaffIdResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetManageProcessByStaffIdResponseBody self = new GetManageProcessByStaffIdResponseBody();
        return TeaModel.build(map, self);
    }

    public GetManageProcessByStaffIdResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public GetManageProcessByStaffIdResponseBody setResult(java.util.List<GetManageProcessByStaffIdResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<GetManageProcessByStaffIdResponseBodyResult> getResult() {
        return this.result;
    }

    public GetManageProcessByStaffIdResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class GetManageProcessByStaffIdResponseBodyResult extends TeaModel {
        // 关联考勤类型，取值。
        // 
        // 0：无
        // 1：补卡申请
        // 2：请假
        @NameInMap("attendanceType")
        public Integer attendanceType;

        // 模版名称。
        @NameInMap("flowTitle")
        public String flowTitle;

        // 修改时间。
        @NameInMap("gmtModified")
        public String gmtModified;

        // 模板图标名。
        @NameInMap("iconName")
        public String iconName;

        // 图标URL地址。
        @NameInMap("iconUrl")
        public String iconUrl;

        // 是否新模版。
        @NameInMap("newProcess")
        public Boolean newProcess;

        // 模版code。
        @NameInMap("processCode")
        public String processCode;

        public static GetManageProcessByStaffIdResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetManageProcessByStaffIdResponseBodyResult self = new GetManageProcessByStaffIdResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetManageProcessByStaffIdResponseBodyResult setAttendanceType(Integer attendanceType) {
            this.attendanceType = attendanceType;
            return this;
        }
        public Integer getAttendanceType() {
            return this.attendanceType;
        }

        public GetManageProcessByStaffIdResponseBodyResult setFlowTitle(String flowTitle) {
            this.flowTitle = flowTitle;
            return this;
        }
        public String getFlowTitle() {
            return this.flowTitle;
        }

        public GetManageProcessByStaffIdResponseBodyResult setGmtModified(String gmtModified) {
            this.gmtModified = gmtModified;
            return this;
        }
        public String getGmtModified() {
            return this.gmtModified;
        }

        public GetManageProcessByStaffIdResponseBodyResult setIconName(String iconName) {
            this.iconName = iconName;
            return this;
        }
        public String getIconName() {
            return this.iconName;
        }

        public GetManageProcessByStaffIdResponseBodyResult setIconUrl(String iconUrl) {
            this.iconUrl = iconUrl;
            return this;
        }
        public String getIconUrl() {
            return this.iconUrl;
        }

        public GetManageProcessByStaffIdResponseBodyResult setNewProcess(Boolean newProcess) {
            this.newProcess = newProcess;
            return this;
        }
        public Boolean getNewProcess() {
            return this.newProcess;
        }

        public GetManageProcessByStaffIdResponseBodyResult setProcessCode(String processCode) {
            this.processCode = processCode;
            return this;
        }
        public String getProcessCode() {
            return this.processCode;
        }

    }

}
