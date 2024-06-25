// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class QueryAllCustomerResponseBody extends TeaModel {
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
        @NameInMap("ownerStaffIds")
        public java.util.List<String> ownerStaffIds;

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
        /**
         * <strong>example:</strong>
         * <p>2019-12-25 15:33:12</p>
         */
        @NameInMap("createTime")
        public String createTime;

        /**
         * <strong>example:</strong>
         * <p>张三</p>
         */
        @NameInMap("creatorNick")
        public String creatorNick;

        /**
         * <strong>example:</strong>
         * <p>ding_userid</p>
         */
        @NameInMap("creatorUserId")
        public String creatorUserId;

        @NameInMap("data")
        public java.util.Map<String, ?> data;

        @NameInMap("extendData")
        public java.util.Map<String, ?> extendData;

        /**
         * <strong>example:</strong>
         * <p>instance_id</p>
         */
        @NameInMap("instanceId")
        public String instanceId;

        /**
         * <strong>example:</strong>
         * <p>2019-12-25 15:33:12</p>
         */
        @NameInMap("modifyTime")
        public String modifyTime;

        /**
         * <strong>example:</strong>
         * <p>crm_customer</p>
         */
        @NameInMap("objectType")
        public String objectType;

        @NameInMap("permission")
        public QueryAllCustomerResponseBodyResultValuesPermission permission;

        /**
         * <strong>example:</strong>
         * <p>COMPLATE</p>
         */
        @NameInMap("processInstanceStatus")
        public String processInstanceStatus;

        /**
         * <strong>example:</strong>
         * <p>agree</p>
         */
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
        /**
         * <strong>example:</strong>
         * <p>100</p>
         */
        @NameInMap("maxResults")
        public Long maxResults;

        /**
         * <strong>example:</strong>
         * <p>100</p>
         */
        @NameInMap("nextToken")
        public String nextToken;

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
