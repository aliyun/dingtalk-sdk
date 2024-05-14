// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class GetManageProcessByStaffIdResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<GetManageProcessByStaffIdResponseBodyResult> result;

    @NameInMap("success")
    public Boolean success;

    public static GetManageProcessByStaffIdResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetManageProcessByStaffIdResponseBody self = new GetManageProcessByStaffIdResponseBody();
        return TeaModel.build(map, self);
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
        @NameInMap("attendanceType")
        public Integer attendanceType;

        @NameInMap("flowTitle")
        public String flowTitle;

        /**
         * <p>Use the UTC time format: yyyy-MM-ddTHH:mmZ</p>
         */
        @NameInMap("gmtModified")
        public String gmtModified;

        @NameInMap("iconName")
        public String iconName;

        @NameInMap("iconUrl")
        public String iconUrl;

        @NameInMap("newProcess")
        public Boolean newProcess;

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
