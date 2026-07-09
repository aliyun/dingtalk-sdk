// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class QuerySignTaskResponseBody extends TeaModel {
    @NameInMap("result")
    public QuerySignTaskResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static QuerySignTaskResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QuerySignTaskResponseBody self = new QuerySignTaskResponseBody();
        return TeaModel.build(map, self);
    }

    public QuerySignTaskResponseBody setResult(QuerySignTaskResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public QuerySignTaskResponseBodyResult getResult() {
        return this.result;
    }

    public QuerySignTaskResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class QuerySignTaskResponseBodyResultDataSignTasksOrgInfo extends TeaModel {
        @NameInMap("companyId")
        public String companyId;

        @NameInMap("orgName")
        public String orgName;

        public static QuerySignTaskResponseBodyResultDataSignTasksOrgInfo build(java.util.Map<String, ?> map) throws Exception {
            QuerySignTaskResponseBodyResultDataSignTasksOrgInfo self = new QuerySignTaskResponseBodyResultDataSignTasksOrgInfo();
            return TeaModel.build(map, self);
        }

        public QuerySignTaskResponseBodyResultDataSignTasksOrgInfo setCompanyId(String companyId) {
            this.companyId = companyId;
            return this;
        }
        public String getCompanyId() {
            return this.companyId;
        }

        public QuerySignTaskResponseBodyResultDataSignTasksOrgInfo setOrgName(String orgName) {
            this.orgName = orgName;
            return this;
        }
        public String getOrgName() {
            return this.orgName;
        }

    }

    public static class QuerySignTaskResponseBodyResultDataSignTasksSignerInfo extends TeaModel {
        @NameInMap("psnMobile")
        public String psnMobile;

        @NameInMap("psnName")
        public String psnName;

        @NameInMap("userId")
        public String userId;

        public static QuerySignTaskResponseBodyResultDataSignTasksSignerInfo build(java.util.Map<String, ?> map) throws Exception {
            QuerySignTaskResponseBodyResultDataSignTasksSignerInfo self = new QuerySignTaskResponseBodyResultDataSignTasksSignerInfo();
            return TeaModel.build(map, self);
        }

        public QuerySignTaskResponseBodyResultDataSignTasksSignerInfo setPsnMobile(String psnMobile) {
            this.psnMobile = psnMobile;
            return this;
        }
        public String getPsnMobile() {
            return this.psnMobile;
        }

        public QuerySignTaskResponseBodyResultDataSignTasksSignerInfo setPsnName(String psnName) {
            this.psnName = psnName;
            return this;
        }
        public String getPsnName() {
            return this.psnName;
        }

        public QuerySignTaskResponseBodyResultDataSignTasksSignerInfo setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class QuerySignTaskResponseBodyResultDataSignTasks extends TeaModel {
        @NameInMap("activateTime")
        public Long activateTime;

        @NameInMap("actualOrgSealType")
        public String actualOrgSealType;

        @NameInMap("actualPsnSealType")
        public String actualPsnSealType;

        @NameInMap("bizTaskId")
        public String bizTaskId;

        @NameInMap("createTime")
        public Long createTime;

        @NameInMap("finishTime")
        public Long finishTime;

        @NameInMap("orgInfo")
        public QuerySignTaskResponseBodyResultDataSignTasksOrgInfo orgInfo;

        @NameInMap("signOrder")
        public Integer signOrder;

        @NameInMap("signTaskId")
        public String signTaskId;

        @NameInMap("signUrl")
        public String signUrl;

        @NameInMap("signerInfo")
        public QuerySignTaskResponseBodyResultDataSignTasksSignerInfo signerInfo;

        @NameInMap("signerType")
        public String signerType;

        @NameInMap("taskStatus")
        public String taskStatus;

        public static QuerySignTaskResponseBodyResultDataSignTasks build(java.util.Map<String, ?> map) throws Exception {
            QuerySignTaskResponseBodyResultDataSignTasks self = new QuerySignTaskResponseBodyResultDataSignTasks();
            return TeaModel.build(map, self);
        }

        public QuerySignTaskResponseBodyResultDataSignTasks setActivateTime(Long activateTime) {
            this.activateTime = activateTime;
            return this;
        }
        public Long getActivateTime() {
            return this.activateTime;
        }

        public QuerySignTaskResponseBodyResultDataSignTasks setActualOrgSealType(String actualOrgSealType) {
            this.actualOrgSealType = actualOrgSealType;
            return this;
        }
        public String getActualOrgSealType() {
            return this.actualOrgSealType;
        }

        public QuerySignTaskResponseBodyResultDataSignTasks setActualPsnSealType(String actualPsnSealType) {
            this.actualPsnSealType = actualPsnSealType;
            return this;
        }
        public String getActualPsnSealType() {
            return this.actualPsnSealType;
        }

        public QuerySignTaskResponseBodyResultDataSignTasks setBizTaskId(String bizTaskId) {
            this.bizTaskId = bizTaskId;
            return this;
        }
        public String getBizTaskId() {
            return this.bizTaskId;
        }

        public QuerySignTaskResponseBodyResultDataSignTasks setCreateTime(Long createTime) {
            this.createTime = createTime;
            return this;
        }
        public Long getCreateTime() {
            return this.createTime;
        }

        public QuerySignTaskResponseBodyResultDataSignTasks setFinishTime(Long finishTime) {
            this.finishTime = finishTime;
            return this;
        }
        public Long getFinishTime() {
            return this.finishTime;
        }

        public QuerySignTaskResponseBodyResultDataSignTasks setOrgInfo(QuerySignTaskResponseBodyResultDataSignTasksOrgInfo orgInfo) {
            this.orgInfo = orgInfo;
            return this;
        }
        public QuerySignTaskResponseBodyResultDataSignTasksOrgInfo getOrgInfo() {
            return this.orgInfo;
        }

        public QuerySignTaskResponseBodyResultDataSignTasks setSignOrder(Integer signOrder) {
            this.signOrder = signOrder;
            return this;
        }
        public Integer getSignOrder() {
            return this.signOrder;
        }

        public QuerySignTaskResponseBodyResultDataSignTasks setSignTaskId(String signTaskId) {
            this.signTaskId = signTaskId;
            return this;
        }
        public String getSignTaskId() {
            return this.signTaskId;
        }

        public QuerySignTaskResponseBodyResultDataSignTasks setSignUrl(String signUrl) {
            this.signUrl = signUrl;
            return this;
        }
        public String getSignUrl() {
            return this.signUrl;
        }

        public QuerySignTaskResponseBodyResultDataSignTasks setSignerInfo(QuerySignTaskResponseBodyResultDataSignTasksSignerInfo signerInfo) {
            this.signerInfo = signerInfo;
            return this;
        }
        public QuerySignTaskResponseBodyResultDataSignTasksSignerInfo getSignerInfo() {
            return this.signerInfo;
        }

        public QuerySignTaskResponseBodyResultDataSignTasks setSignerType(String signerType) {
            this.signerType = signerType;
            return this;
        }
        public String getSignerType() {
            return this.signerType;
        }

        public QuerySignTaskResponseBodyResultDataSignTasks setTaskStatus(String taskStatus) {
            this.taskStatus = taskStatus;
            return this;
        }
        public String getTaskStatus() {
            return this.taskStatus;
        }

    }

    public static class QuerySignTaskResponseBodyResultData extends TeaModel {
        @NameInMap("bizFlowId")
        public String bizFlowId;

        @NameInMap("signFlowId")
        public String signFlowId;

        @NameInMap("signFlowStatus")
        public String signFlowStatus;

        @NameInMap("signTasks")
        public java.util.List<QuerySignTaskResponseBodyResultDataSignTasks> signTasks;

        public static QuerySignTaskResponseBodyResultData build(java.util.Map<String, ?> map) throws Exception {
            QuerySignTaskResponseBodyResultData self = new QuerySignTaskResponseBodyResultData();
            return TeaModel.build(map, self);
        }

        public QuerySignTaskResponseBodyResultData setBizFlowId(String bizFlowId) {
            this.bizFlowId = bizFlowId;
            return this;
        }
        public String getBizFlowId() {
            return this.bizFlowId;
        }

        public QuerySignTaskResponseBodyResultData setSignFlowId(String signFlowId) {
            this.signFlowId = signFlowId;
            return this;
        }
        public String getSignFlowId() {
            return this.signFlowId;
        }

        public QuerySignTaskResponseBodyResultData setSignFlowStatus(String signFlowStatus) {
            this.signFlowStatus = signFlowStatus;
            return this;
        }
        public String getSignFlowStatus() {
            return this.signFlowStatus;
        }

        public QuerySignTaskResponseBodyResultData setSignTasks(java.util.List<QuerySignTaskResponseBodyResultDataSignTasks> signTasks) {
            this.signTasks = signTasks;
            return this;
        }
        public java.util.List<QuerySignTaskResponseBodyResultDataSignTasks> getSignTasks() {
            return this.signTasks;
        }

    }

    public static class QuerySignTaskResponseBodyResult extends TeaModel {
        @NameInMap("data")
        public QuerySignTaskResponseBodyResultData data;

        @NameInMap("requestId")
        public String requestId;

        public static QuerySignTaskResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QuerySignTaskResponseBodyResult self = new QuerySignTaskResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QuerySignTaskResponseBodyResult setData(QuerySignTaskResponseBodyResultData data) {
            this.data = data;
            return this;
        }
        public QuerySignTaskResponseBodyResultData getData() {
            return this.data;
        }

        public QuerySignTaskResponseBodyResult setRequestId(String requestId) {
            this.requestId = requestId;
            return this;
        }
        public String getRequestId() {
            return this.requestId;
        }

    }

}
