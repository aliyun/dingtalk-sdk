// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class QueryCrmPersonalCustomerResponseBody extends TeaModel {
    @NameInMap("hasMore")
    public Boolean hasMore;

    /**
     * <strong>example:</strong>
     * <p>10</p>
     */
    @NameInMap("maxResults")
    public Integer maxResults;

    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <strong>example:</strong>
     * <p>1000</p>
     */
    @NameInMap("totalCount")
    public Integer totalCount;

    @NameInMap("values")
    public java.util.List<QueryCrmPersonalCustomerResponseBodyValues> values;

    public static QueryCrmPersonalCustomerResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryCrmPersonalCustomerResponseBody self = new QueryCrmPersonalCustomerResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryCrmPersonalCustomerResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public QueryCrmPersonalCustomerResponseBody setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public QueryCrmPersonalCustomerResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public QueryCrmPersonalCustomerResponseBody setTotalCount(Integer totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Integer getTotalCount() {
        return this.totalCount;
    }

    public QueryCrmPersonalCustomerResponseBody setValues(java.util.List<QueryCrmPersonalCustomerResponseBodyValues> values) {
        this.values = values;
        return this;
    }
    public java.util.List<QueryCrmPersonalCustomerResponseBodyValues> getValues() {
        return this.values;
    }

    public static class QueryCrmPersonalCustomerResponseBodyValuesPermission extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("ownerStaffIds")
        public java.util.List<String> ownerStaffIds;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("participantStaffIds")
        public java.util.List<String> participantStaffIds;

        public static QueryCrmPersonalCustomerResponseBodyValuesPermission build(java.util.Map<String, ?> map) throws Exception {
            QueryCrmPersonalCustomerResponseBodyValuesPermission self = new QueryCrmPersonalCustomerResponseBodyValuesPermission();
            return TeaModel.build(map, self);
        }

        public QueryCrmPersonalCustomerResponseBodyValuesPermission setOwnerStaffIds(java.util.List<String> ownerStaffIds) {
            this.ownerStaffIds = ownerStaffIds;
            return this;
        }
        public java.util.List<String> getOwnerStaffIds() {
            return this.ownerStaffIds;
        }

        public QueryCrmPersonalCustomerResponseBodyValuesPermission setParticipantStaffIds(java.util.List<String> participantStaffIds) {
            this.participantStaffIds = participantStaffIds;
            return this;
        }
        public java.util.List<String> getParticipantStaffIds() {
            return this.participantStaffIds;
        }

    }

    public static class QueryCrmPersonalCustomerResponseBodyValues extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("creatorNick")
        public String creatorNick;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("creatorUserId")
        public String creatorUserId;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("data")
        public java.util.Map<String, ?> data;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("extendData")
        public java.util.Map<String, ?> extendData;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("gmtCreate")
        public String gmtCreate;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("gmtModified")
        public String gmtModified;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("instanceId")
        public String instanceId;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("objectType")
        public String objectType;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("permission")
        public QueryCrmPersonalCustomerResponseBodyValuesPermission permission;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("procInstStatus")
        public String procInstStatus;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("procOutResult")
        public String procOutResult;

        public static QueryCrmPersonalCustomerResponseBodyValues build(java.util.Map<String, ?> map) throws Exception {
            QueryCrmPersonalCustomerResponseBodyValues self = new QueryCrmPersonalCustomerResponseBodyValues();
            return TeaModel.build(map, self);
        }

        public QueryCrmPersonalCustomerResponseBodyValues setCreatorNick(String creatorNick) {
            this.creatorNick = creatorNick;
            return this;
        }
        public String getCreatorNick() {
            return this.creatorNick;
        }

        public QueryCrmPersonalCustomerResponseBodyValues setCreatorUserId(String creatorUserId) {
            this.creatorUserId = creatorUserId;
            return this;
        }
        public String getCreatorUserId() {
            return this.creatorUserId;
        }

        public QueryCrmPersonalCustomerResponseBodyValues setData(java.util.Map<String, ?> data) {
            this.data = data;
            return this;
        }
        public java.util.Map<String, ?> getData() {
            return this.data;
        }

        public QueryCrmPersonalCustomerResponseBodyValues setExtendData(java.util.Map<String, ?> extendData) {
            this.extendData = extendData;
            return this;
        }
        public java.util.Map<String, ?> getExtendData() {
            return this.extendData;
        }

        public QueryCrmPersonalCustomerResponseBodyValues setGmtCreate(String gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public String getGmtCreate() {
            return this.gmtCreate;
        }

        public QueryCrmPersonalCustomerResponseBodyValues setGmtModified(String gmtModified) {
            this.gmtModified = gmtModified;
            return this;
        }
        public String getGmtModified() {
            return this.gmtModified;
        }

        public QueryCrmPersonalCustomerResponseBodyValues setInstanceId(String instanceId) {
            this.instanceId = instanceId;
            return this;
        }
        public String getInstanceId() {
            return this.instanceId;
        }

        public QueryCrmPersonalCustomerResponseBodyValues setObjectType(String objectType) {
            this.objectType = objectType;
            return this;
        }
        public String getObjectType() {
            return this.objectType;
        }

        public QueryCrmPersonalCustomerResponseBodyValues setPermission(QueryCrmPersonalCustomerResponseBodyValuesPermission permission) {
            this.permission = permission;
            return this;
        }
        public QueryCrmPersonalCustomerResponseBodyValuesPermission getPermission() {
            return this.permission;
        }

        public QueryCrmPersonalCustomerResponseBodyValues setProcInstStatus(String procInstStatus) {
            this.procInstStatus = procInstStatus;
            return this;
        }
        public String getProcInstStatus() {
            return this.procInstStatus;
        }

        public QueryCrmPersonalCustomerResponseBodyValues setProcOutResult(String procOutResult) {
            this.procOutResult = procOutResult;
            return this;
        }
        public String getProcOutResult() {
            return this.procOutResult;
        }

    }

}
