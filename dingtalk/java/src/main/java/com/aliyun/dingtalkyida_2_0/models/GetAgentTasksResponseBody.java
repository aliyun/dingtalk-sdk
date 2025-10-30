// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_2_0.models;

import com.aliyun.tea.*;

public class GetAgentTasksResponseBody extends TeaModel {
    @NameInMap("currentPage")
    public Integer currentPage;

    @NameInMap("limit")
    public Integer limit;

    @NameInMap("start")
    public Integer start;

    @NameInMap("totalCount")
    public Integer totalCount;

    @NameInMap("values")
    public java.util.List<GetAgentTasksResponseBodyValues> values;

    public static GetAgentTasksResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetAgentTasksResponseBody self = new GetAgentTasksResponseBody();
        return TeaModel.build(map, self);
    }

    public GetAgentTasksResponseBody setCurrentPage(Integer currentPage) {
        this.currentPage = currentPage;
        return this;
    }
    public Integer getCurrentPage() {
        return this.currentPage;
    }

    public GetAgentTasksResponseBody setLimit(Integer limit) {
        this.limit = limit;
        return this;
    }
    public Integer getLimit() {
        return this.limit;
    }

    public GetAgentTasksResponseBody setStart(Integer start) {
        this.start = start;
        return this;
    }
    public Integer getStart() {
        return this.start;
    }

    public GetAgentTasksResponseBody setTotalCount(Integer totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Integer getTotalCount() {
        return this.totalCount;
    }

    public GetAgentTasksResponseBody setValues(java.util.List<GetAgentTasksResponseBodyValues> values) {
        this.values = values;
        return this;
    }
    public java.util.List<GetAgentTasksResponseBodyValues> getValues() {
        return this.values;
    }

    public static class GetAgentTasksResponseBodyValues extends TeaModel {
        @NameInMap("agentCategory")
        public String agentCategory;

        @NameInMap("agentCreateGMT")
        public String agentCreateGMT;

        @NameInMap("agentEndGMT")
        public String agentEndGMT;

        @NameInMap("agentName")
        public String agentName;

        @NameInMap("agentRangeType")
        public String agentRangeType;

        @NameInMap("agentRangeValue")
        public String agentRangeValue;

        @NameInMap("agentStartGMT")
        public String agentStartGMT;

        @NameInMap("agentType")
        public String agentType;

        @NameInMap("agentUserId")
        public String agentUserId;

        @NameInMap("agentUuid")
        public String agentUuid;

        @NameInMap("creator")
        public String creator;

        @NameInMap("creatorName")
        public String creatorName;

        @NameInMap("modifier")
        public String modifier;

        @NameInMap("needNoticePrincipal")
        public String needNoticePrincipal;

        @NameInMap("principalName")
        public String principalName;

        @NameInMap("principalUserId")
        public String principalUserId;

        @NameInMap("status")
        public String status;

        public static GetAgentTasksResponseBodyValues build(java.util.Map<String, ?> map) throws Exception {
            GetAgentTasksResponseBodyValues self = new GetAgentTasksResponseBodyValues();
            return TeaModel.build(map, self);
        }

        public GetAgentTasksResponseBodyValues setAgentCategory(String agentCategory) {
            this.agentCategory = agentCategory;
            return this;
        }
        public String getAgentCategory() {
            return this.agentCategory;
        }

        public GetAgentTasksResponseBodyValues setAgentCreateGMT(String agentCreateGMT) {
            this.agentCreateGMT = agentCreateGMT;
            return this;
        }
        public String getAgentCreateGMT() {
            return this.agentCreateGMT;
        }

        public GetAgentTasksResponseBodyValues setAgentEndGMT(String agentEndGMT) {
            this.agentEndGMT = agentEndGMT;
            return this;
        }
        public String getAgentEndGMT() {
            return this.agentEndGMT;
        }

        public GetAgentTasksResponseBodyValues setAgentName(String agentName) {
            this.agentName = agentName;
            return this;
        }
        public String getAgentName() {
            return this.agentName;
        }

        public GetAgentTasksResponseBodyValues setAgentRangeType(String agentRangeType) {
            this.agentRangeType = agentRangeType;
            return this;
        }
        public String getAgentRangeType() {
            return this.agentRangeType;
        }

        public GetAgentTasksResponseBodyValues setAgentRangeValue(String agentRangeValue) {
            this.agentRangeValue = agentRangeValue;
            return this;
        }
        public String getAgentRangeValue() {
            return this.agentRangeValue;
        }

        public GetAgentTasksResponseBodyValues setAgentStartGMT(String agentStartGMT) {
            this.agentStartGMT = agentStartGMT;
            return this;
        }
        public String getAgentStartGMT() {
            return this.agentStartGMT;
        }

        public GetAgentTasksResponseBodyValues setAgentType(String agentType) {
            this.agentType = agentType;
            return this;
        }
        public String getAgentType() {
            return this.agentType;
        }

        public GetAgentTasksResponseBodyValues setAgentUserId(String agentUserId) {
            this.agentUserId = agentUserId;
            return this;
        }
        public String getAgentUserId() {
            return this.agentUserId;
        }

        public GetAgentTasksResponseBodyValues setAgentUuid(String agentUuid) {
            this.agentUuid = agentUuid;
            return this;
        }
        public String getAgentUuid() {
            return this.agentUuid;
        }

        public GetAgentTasksResponseBodyValues setCreator(String creator) {
            this.creator = creator;
            return this;
        }
        public String getCreator() {
            return this.creator;
        }

        public GetAgentTasksResponseBodyValues setCreatorName(String creatorName) {
            this.creatorName = creatorName;
            return this;
        }
        public String getCreatorName() {
            return this.creatorName;
        }

        public GetAgentTasksResponseBodyValues setModifier(String modifier) {
            this.modifier = modifier;
            return this;
        }
        public String getModifier() {
            return this.modifier;
        }

        public GetAgentTasksResponseBodyValues setNeedNoticePrincipal(String needNoticePrincipal) {
            this.needNoticePrincipal = needNoticePrincipal;
            return this;
        }
        public String getNeedNoticePrincipal() {
            return this.needNoticePrincipal;
        }

        public GetAgentTasksResponseBodyValues setPrincipalName(String principalName) {
            this.principalName = principalName;
            return this;
        }
        public String getPrincipalName() {
            return this.principalName;
        }

        public GetAgentTasksResponseBodyValues setPrincipalUserId(String principalUserId) {
            this.principalUserId = principalUserId;
            return this;
        }
        public String getPrincipalUserId() {
            return this.principalUserId;
        }

        public GetAgentTasksResponseBodyValues setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

    }

}
