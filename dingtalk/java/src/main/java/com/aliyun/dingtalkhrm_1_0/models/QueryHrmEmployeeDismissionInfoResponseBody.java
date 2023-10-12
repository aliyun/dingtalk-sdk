// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class QueryHrmEmployeeDismissionInfoResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<QueryHrmEmployeeDismissionInfoResponseBodyResult> result;

    public static QueryHrmEmployeeDismissionInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryHrmEmployeeDismissionInfoResponseBody self = new QueryHrmEmployeeDismissionInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryHrmEmployeeDismissionInfoResponseBody setResult(java.util.List<QueryHrmEmployeeDismissionInfoResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<QueryHrmEmployeeDismissionInfoResponseBodyResult> getResult() {
        return this.result;
    }

    public static class QueryHrmEmployeeDismissionInfoResponseBodyResultDeptList extends TeaModel {
        @NameInMap("dept_id")
        public Long deptId;

        @NameInMap("dept_path")
        public String deptPath;

        public static QueryHrmEmployeeDismissionInfoResponseBodyResultDeptList build(java.util.Map<String, ?> map) throws Exception {
            QueryHrmEmployeeDismissionInfoResponseBodyResultDeptList self = new QueryHrmEmployeeDismissionInfoResponseBodyResultDeptList();
            return TeaModel.build(map, self);
        }

        public QueryHrmEmployeeDismissionInfoResponseBodyResultDeptList setDeptId(Long deptId) {
            this.deptId = deptId;
            return this;
        }
        public Long getDeptId() {
            return this.deptId;
        }

        public QueryHrmEmployeeDismissionInfoResponseBodyResultDeptList setDeptPath(String deptPath) {
            this.deptPath = deptPath;
            return this;
        }
        public String getDeptPath() {
            return this.deptPath;
        }

    }

    public static class QueryHrmEmployeeDismissionInfoResponseBodyResult extends TeaModel {
        @NameInMap("deptList")
        public java.util.List<QueryHrmEmployeeDismissionInfoResponseBodyResultDeptList> deptList;

        @NameInMap("handoverUserId")
        public String handoverUserId;

        @NameInMap("lastWorkDay")
        public Long lastWorkDay;

        @NameInMap("mainDeptId")
        public Long mainDeptId;

        @NameInMap("mainDeptName")
        public String mainDeptName;

        @NameInMap("name")
        public String name;

        @NameInMap("passiveReason")
        public java.util.List<String> passiveReason;

        @NameInMap("preStatus")
        public Integer preStatus;

        @NameInMap("reasonMemo")
        public String reasonMemo;

        @NameInMap("status")
        public Integer status;

        @NameInMap("userId")
        public String userId;

        @NameInMap("voluntaryReason")
        public java.util.List<String> voluntaryReason;

        public static QueryHrmEmployeeDismissionInfoResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryHrmEmployeeDismissionInfoResponseBodyResult self = new QueryHrmEmployeeDismissionInfoResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryHrmEmployeeDismissionInfoResponseBodyResult setDeptList(java.util.List<QueryHrmEmployeeDismissionInfoResponseBodyResultDeptList> deptList) {
            this.deptList = deptList;
            return this;
        }
        public java.util.List<QueryHrmEmployeeDismissionInfoResponseBodyResultDeptList> getDeptList() {
            return this.deptList;
        }

        public QueryHrmEmployeeDismissionInfoResponseBodyResult setHandoverUserId(String handoverUserId) {
            this.handoverUserId = handoverUserId;
            return this;
        }
        public String getHandoverUserId() {
            return this.handoverUserId;
        }

        public QueryHrmEmployeeDismissionInfoResponseBodyResult setLastWorkDay(Long lastWorkDay) {
            this.lastWorkDay = lastWorkDay;
            return this;
        }
        public Long getLastWorkDay() {
            return this.lastWorkDay;
        }

        public QueryHrmEmployeeDismissionInfoResponseBodyResult setMainDeptId(Long mainDeptId) {
            this.mainDeptId = mainDeptId;
            return this;
        }
        public Long getMainDeptId() {
            return this.mainDeptId;
        }

        public QueryHrmEmployeeDismissionInfoResponseBodyResult setMainDeptName(String mainDeptName) {
            this.mainDeptName = mainDeptName;
            return this;
        }
        public String getMainDeptName() {
            return this.mainDeptName;
        }

        public QueryHrmEmployeeDismissionInfoResponseBodyResult setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public QueryHrmEmployeeDismissionInfoResponseBodyResult setPassiveReason(java.util.List<String> passiveReason) {
            this.passiveReason = passiveReason;
            return this;
        }
        public java.util.List<String> getPassiveReason() {
            return this.passiveReason;
        }

        public QueryHrmEmployeeDismissionInfoResponseBodyResult setPreStatus(Integer preStatus) {
            this.preStatus = preStatus;
            return this;
        }
        public Integer getPreStatus() {
            return this.preStatus;
        }

        public QueryHrmEmployeeDismissionInfoResponseBodyResult setReasonMemo(String reasonMemo) {
            this.reasonMemo = reasonMemo;
            return this;
        }
        public String getReasonMemo() {
            return this.reasonMemo;
        }

        public QueryHrmEmployeeDismissionInfoResponseBodyResult setStatus(Integer status) {
            this.status = status;
            return this;
        }
        public Integer getStatus() {
            return this.status;
        }

        public QueryHrmEmployeeDismissionInfoResponseBodyResult setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

        public QueryHrmEmployeeDismissionInfoResponseBodyResult setVoluntaryReason(java.util.List<String> voluntaryReason) {
            this.voluntaryReason = voluntaryReason;
            return this;
        }
        public java.util.List<String> getVoluntaryReason() {
            return this.voluntaryReason;
        }

    }

}
