// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class QueryCrmPersonalCustomerResponseBody extends TeaModel {
    @NameInMap("hasMore")
    public Boolean hasMore;

    /**
     * <p>当前分页条数</p>
     */
    @NameInMap("maxResults")
    public Integer maxResults;

    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <p>总条数</p>
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
         * <p>负责人用户ID列表</p>
         */
        @NameInMap("ownerStaffIds")
        public java.util.List<String> ownerStaffIds;

        /**
         * <p>协同人用户ID列表</p>
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
         * <p>创建记录的用户昵称</p>
         */
        @NameInMap("creatorNick")
        public String creatorNick;

        /**
         * <p>创建记录的用户ID</p>
         */
        @NameInMap("creatorUserId")
        public String creatorUserId;

        /**
         * <p>数据内容</p>
         */
        @NameInMap("data")
        public java.util.Map<String, ?> data;

        /**
         * <p>扩展数据内容</p>
         */
        @NameInMap("extendData")
        public java.util.Map<String, ?> extendData;

        /**
         * <p>记录创建时间</p>
         */
        @NameInMap("gmtCreate")
        public String gmtCreate;

        /**
         * <p>记录修改时间</p>
         */
        @NameInMap("gmtModified")
        public String gmtModified;

        /**
         * <p>数据ID</p>
         */
        @NameInMap("instanceId")
        public String instanceId;

        /**
         * <p>数据类型</p>
         */
        @NameInMap("objectType")
        public String objectType;

        /**
         * <p>数据权限信息</p>
         */
        @NameInMap("permission")
        public QueryCrmPersonalCustomerResponseBodyValuesPermission permission;

        /**
         * <p>审批状态</p>
         */
        @NameInMap("procInstStatus")
        public String procInstStatus;

        /**
         * <p>审批结果</p>
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
