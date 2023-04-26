// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class QueryInstancesByMultiConditionsResponseBody extends TeaModel {
    @NameInMap("maxResults")
    public Long maxResults;

    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("records")
    public java.util.List<QueryInstancesByMultiConditionsResponseBodyRecords> records;

    @NameInMap("totalCount")
    public Long totalCount;

    public static QueryInstancesByMultiConditionsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryInstancesByMultiConditionsResponseBody self = new QueryInstancesByMultiConditionsResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryInstancesByMultiConditionsResponseBody setMaxResults(Long maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Long getMaxResults() {
        return this.maxResults;
    }

    public QueryInstancesByMultiConditionsResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public QueryInstancesByMultiConditionsResponseBody setRecords(java.util.List<QueryInstancesByMultiConditionsResponseBodyRecords> records) {
        this.records = records;
        return this;
    }
    public java.util.List<QueryInstancesByMultiConditionsResponseBodyRecords> getRecords() {
        return this.records;
    }

    public QueryInstancesByMultiConditionsResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public static class QueryInstancesByMultiConditionsResponseBodyRecords extends TeaModel {
        @NameInMap("creatorUnionId")
        public String creatorUnionId;

        @NameInMap("fields")
        public String fields;

        @NameInMap("formCode")
        public String formCode;

        @NameInMap("gmtCreate")
        public String gmtCreate;

        @NameInMap("gmtModified")
        public String gmtModified;

        @NameInMap("modifiedUnionId")
        public String modifiedUnionId;

        @NameInMap("openDataInstanceId")
        public String openDataInstanceId;

        @NameInMap("openTeamId")
        public String openTeamId;

        @NameInMap("ownerUnionId")
        public String ownerUnionId;

        public static QueryInstancesByMultiConditionsResponseBodyRecords build(java.util.Map<String, ?> map) throws Exception {
            QueryInstancesByMultiConditionsResponseBodyRecords self = new QueryInstancesByMultiConditionsResponseBodyRecords();
            return TeaModel.build(map, self);
        }

        public QueryInstancesByMultiConditionsResponseBodyRecords setCreatorUnionId(String creatorUnionId) {
            this.creatorUnionId = creatorUnionId;
            return this;
        }
        public String getCreatorUnionId() {
            return this.creatorUnionId;
        }

        public QueryInstancesByMultiConditionsResponseBodyRecords setFields(String fields) {
            this.fields = fields;
            return this;
        }
        public String getFields() {
            return this.fields;
        }

        public QueryInstancesByMultiConditionsResponseBodyRecords setFormCode(String formCode) {
            this.formCode = formCode;
            return this;
        }
        public String getFormCode() {
            return this.formCode;
        }

        public QueryInstancesByMultiConditionsResponseBodyRecords setGmtCreate(String gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public String getGmtCreate() {
            return this.gmtCreate;
        }

        public QueryInstancesByMultiConditionsResponseBodyRecords setGmtModified(String gmtModified) {
            this.gmtModified = gmtModified;
            return this;
        }
        public String getGmtModified() {
            return this.gmtModified;
        }

        public QueryInstancesByMultiConditionsResponseBodyRecords setModifiedUnionId(String modifiedUnionId) {
            this.modifiedUnionId = modifiedUnionId;
            return this;
        }
        public String getModifiedUnionId() {
            return this.modifiedUnionId;
        }

        public QueryInstancesByMultiConditionsResponseBodyRecords setOpenDataInstanceId(String openDataInstanceId) {
            this.openDataInstanceId = openDataInstanceId;
            return this;
        }
        public String getOpenDataInstanceId() {
            return this.openDataInstanceId;
        }

        public QueryInstancesByMultiConditionsResponseBodyRecords setOpenTeamId(String openTeamId) {
            this.openTeamId = openTeamId;
            return this;
        }
        public String getOpenTeamId() {
            return this.openTeamId;
        }

        public QueryInstancesByMultiConditionsResponseBodyRecords setOwnerUnionId(String ownerUnionId) {
            this.ownerUnionId = ownerUnionId;
            return this;
        }
        public String getOwnerUnionId() {
            return this.ownerUnionId;
        }

    }

}
