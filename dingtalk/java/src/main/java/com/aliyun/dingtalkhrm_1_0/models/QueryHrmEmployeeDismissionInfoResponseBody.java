// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class QueryHrmEmployeeDismissionInfoResponseBody extends TeaModel {
    /**
     * <p>名称列表</p>
     */
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
        /**
         * <p>部门id</p>
         */
        @NameInMap("dept_id")
        public Long deptId;

        /**
         * <p>部门路径</p>
         */
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
        /**
         * <p>离职部门列表</p>
         */
        @NameInMap("deptList")
        public java.util.List<QueryHrmEmployeeDismissionInfoResponseBodyResultDeptList> deptList;

        /**
         * <p>离职交接人</p>
         */
        @NameInMap("handoverUserId")
        public String handoverUserId;

        /**
         * <p>最后工作日</p>
         */
        @NameInMap("lastWorkDay")
        public Long lastWorkDay;

        /**
         * <p>离职前主部门id</p>
         */
        @NameInMap("mainDeptId")
        public Long mainDeptId;

        /**
         * <p>离职前主部门名称</p>
         */
        @NameInMap("mainDeptName")
        public String mainDeptName;

        /**
         * <p>离职原因-被动</p>
         */
        @NameInMap("passiveReason")
        public java.util.List<String> passiveReason;

        /**
         * <p>离职前工作状态：1，待入职；2，试用期；3，正式</p>
         */
        @NameInMap("preStatus")
        public Integer preStatus;

        /**
         * <p>离职原因备注</p>
         */
        @NameInMap("reasonMemo")
        public String reasonMemo;

        /**
         * <p>离职状态：1，待离职；2，已离职</p>
         */
        @NameInMap("status")
        public Integer status;

        /**
         * <p>员工id</p>
         */
        @NameInMap("userId")
        public String userId;

        /**
         * <p>离职原因-主动</p>
         */
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
