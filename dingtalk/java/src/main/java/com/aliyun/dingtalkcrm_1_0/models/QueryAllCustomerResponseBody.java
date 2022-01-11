// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class QueryAllCustomerResponseBody extends TeaModel {
    // 分页结果
    @NameInMap("result")
    public QueryAllCustomerResponseBodyResult result;

    public static QueryAllCustomerResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryAllCustomerResponseBody self = new QueryAllCustomerResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryAllCustomerResponseBody setResult(QueryAllCustomerResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public QueryAllCustomerResponseBodyResult getResult() {
        return this.result;
    }

    public static class QueryAllCustomerResponseBodyResultValuesPermission extends TeaModel {
        // 负责人用户ID列表
        @NameInMap("ownerStaffIds")
        public java.util.List<String> ownerStaffIds;

        // 协同人用户ID列表
        @NameInMap("participantStaffIds")
        public java.util.List<String> participantStaffIds;

        public static QueryAllCustomerResponseBodyResultValuesPermission build(java.util.Map<String, ?> map) throws Exception {
            QueryAllCustomerResponseBodyResultValuesPermission self = new QueryAllCustomerResponseBodyResultValuesPermission();
            return TeaModel.build(map, self);
        }

        public QueryAllCustomerResponseBodyResultValuesPermission setOwnerStaffIds(java.util.List<String> ownerStaffIds) {
            this.ownerStaffIds = ownerStaffIds;
            return this;
        }
        public java.util.List<String> getOwnerStaffIds() {
            return this.ownerStaffIds;
        }

        public QueryAllCustomerResponseBodyResultValuesPermission setParticipantStaffIds(java.util.List<String> participantStaffIds) {
            this.participantStaffIds = participantStaffIds;
            return this;
        }
        public java.util.List<String> getParticipantStaffIds() {
            return this.participantStaffIds;
        }

    }

    public static class QueryAllCustomerResponseBodyResultValues extends TeaModel {
        // 记录创建时间
        @NameInMap("createTime")
        public String createTime;

        // 创建记录的用户昵称
        @NameInMap("creatorNick")
        public String creatorNick;

        // 创建记录的用户ID
        @NameInMap("creatorUserId")
        public String creatorUserId;

        // 数据内容
        @NameInMap("data")
        public java.util.Map<String, ?> data;

        // 扩展数据内容
        @NameInMap("extendData")
        public java.util.Map<String, ?> extendData;

        // 数据ID
        @NameInMap("instanceId")
        public String instanceId;

        // 记录修改时间
        @NameInMap("modifyTime")
        public String modifyTime;

        // 数据类型
        @NameInMap("objectType")
        public String objectType;

        // 系统自动生成
        @NameInMap("orgId")
        public Long orgId;

        // 数据权限信息
        @NameInMap("permission")
        public QueryAllCustomerResponseBodyResultValuesPermission permission;

        // 审批状态
        @NameInMap("processInstanceStatus")
        public String processInstanceStatus;

        // 审批结果
        @NameInMap("processOutResult")
        public String processOutResult;

        public static QueryAllCustomerResponseBodyResultValues build(java.util.Map<String, ?> map) throws Exception {
            QueryAllCustomerResponseBodyResultValues self = new QueryAllCustomerResponseBodyResultValues();
            return TeaModel.build(map, self);
        }

        public QueryAllCustomerResponseBodyResultValues setCreateTime(String createTime) {
            this.createTime = createTime;
            return this;
        }
        public String getCreateTime() {
            return this.createTime;
        }

        public QueryAllCustomerResponseBodyResultValues setCreatorNick(String creatorNick) {
            this.creatorNick = creatorNick;
            return this;
        }
        public String getCreatorNick() {
            return this.creatorNick;
        }

        public QueryAllCustomerResponseBodyResultValues setCreatorUserId(String creatorUserId) {
            this.creatorUserId = creatorUserId;
            return this;
        }
        public String getCreatorUserId() {
            return this.creatorUserId;
        }

        public QueryAllCustomerResponseBodyResultValues setData(java.util.Map<String, ?> data) {
            this.data = data;
            return this;
        }
        public java.util.Map<String, ?> getData() {
            return this.data;
        }

        public QueryAllCustomerResponseBodyResultValues setExtendData(java.util.Map<String, ?> extendData) {
            this.extendData = extendData;
            return this;
        }
        public java.util.Map<String, ?> getExtendData() {
            return this.extendData;
        }

        public QueryAllCustomerResponseBodyResultValues setInstanceId(String instanceId) {
            this.instanceId = instanceId;
            return this;
        }
        public String getInstanceId() {
            return this.instanceId;
        }

        public QueryAllCustomerResponseBodyResultValues setModifyTime(String modifyTime) {
            this.modifyTime = modifyTime;
            return this;
        }
        public String getModifyTime() {
            return this.modifyTime;
        }

        public QueryAllCustomerResponseBodyResultValues setObjectType(String objectType) {
            this.objectType = objectType;
            return this;
        }
        public String getObjectType() {
            return this.objectType;
        }

        public QueryAllCustomerResponseBodyResultValues setOrgId(Long orgId) {
            this.orgId = orgId;
            return this;
        }
        public Long getOrgId() {
            return this.orgId;
        }

        public QueryAllCustomerResponseBodyResultValues setPermission(QueryAllCustomerResponseBodyResultValuesPermission permission) {
            this.permission = permission;
            return this;
        }
        public QueryAllCustomerResponseBodyResultValuesPermission getPermission() {
            return this.permission;
        }

        public QueryAllCustomerResponseBodyResultValues setProcessInstanceStatus(String processInstanceStatus) {
            this.processInstanceStatus = processInstanceStatus;
            return this;
        }
        public String getProcessInstanceStatus() {
            return this.processInstanceStatus;
        }

        public QueryAllCustomerResponseBodyResultValues setProcessOutResult(String processOutResult) {
            this.processOutResult = processOutResult;
            return this;
        }
        public String getProcessOutResult() {
            return this.processOutResult;
        }

    }

    public static class QueryAllCustomerResponseBodyResult extends TeaModel {
        // 分页大小
        @NameInMap("maxResults")
        public Long maxResults;

        // 下一页的游标，为null则表示无数据
        @NameInMap("nextToken")
        public String nextToken;

        // 客户数据节点
        @NameInMap("values")
        public java.util.List<QueryAllCustomerResponseBodyResultValues> values;

        public static QueryAllCustomerResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryAllCustomerResponseBodyResult self = new QueryAllCustomerResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryAllCustomerResponseBodyResult setMaxResults(Long maxResults) {
            this.maxResults = maxResults;
            return this;
        }
        public Long getMaxResults() {
            return this.maxResults;
        }

        public QueryAllCustomerResponseBodyResult setNextToken(String nextToken) {
            this.nextToken = nextToken;
            return this;
        }
        public String getNextToken() {
            return this.nextToken;
        }

        public QueryAllCustomerResponseBodyResult setValues(java.util.List<QueryAllCustomerResponseBodyResultValues> values) {
            this.values = values;
            return this;
        }
        public java.util.List<QueryAllCustomerResponseBodyResultValues> getValues() {
            return this.values;
        }

    }

}
