// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class QuerySendMsgTaskStatisticsResponseBody extends TeaModel {
    @NameInMap("maxResults")
    public Long maxResults;

    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("records")
    public java.util.List<QuerySendMsgTaskStatisticsResponseBodyRecords> records;

    // Id of the request
    @NameInMap("totalCount")
    public Long totalCount;

    public static QuerySendMsgTaskStatisticsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QuerySendMsgTaskStatisticsResponseBody self = new QuerySendMsgTaskStatisticsResponseBody();
        return TeaModel.build(map, self);
    }

    public QuerySendMsgTaskStatisticsResponseBody setMaxResults(Long maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Long getMaxResults() {
        return this.maxResults;
    }

    public QuerySendMsgTaskStatisticsResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public QuerySendMsgTaskStatisticsResponseBody setRecords(java.util.List<QuerySendMsgTaskStatisticsResponseBodyRecords> records) {
        this.records = records;
        return this;
    }
    public java.util.List<QuerySendMsgTaskStatisticsResponseBodyRecords> getRecords() {
        return this.records;
    }

    public QuerySendMsgTaskStatisticsResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public static class QuerySendMsgTaskStatisticsResponseBodyRecordsGroup extends TeaModel {
        @NameInMap("bizId")
        public String bizId;

        @NameInMap("groupName")
        public String groupName;

        @NameInMap("groupSetName")
        public String groupSetName;

        @NameInMap("openConversationId")
        public String openConversationId;

        @NameInMap("openGroupSetId")
        public String openGroupSetId;

        @NameInMap("openTeamId")
        public String openTeamId;

        public static QuerySendMsgTaskStatisticsResponseBodyRecordsGroup build(java.util.Map<String, ?> map) throws Exception {
            QuerySendMsgTaskStatisticsResponseBodyRecordsGroup self = new QuerySendMsgTaskStatisticsResponseBodyRecordsGroup();
            return TeaModel.build(map, self);
        }

        public QuerySendMsgTaskStatisticsResponseBodyRecordsGroup setBizId(String bizId) {
            this.bizId = bizId;
            return this;
        }
        public String getBizId() {
            return this.bizId;
        }

        public QuerySendMsgTaskStatisticsResponseBodyRecordsGroup setGroupName(String groupName) {
            this.groupName = groupName;
            return this;
        }
        public String getGroupName() {
            return this.groupName;
        }

        public QuerySendMsgTaskStatisticsResponseBodyRecordsGroup setGroupSetName(String groupSetName) {
            this.groupSetName = groupSetName;
            return this;
        }
        public String getGroupSetName() {
            return this.groupSetName;
        }

        public QuerySendMsgTaskStatisticsResponseBodyRecordsGroup setOpenConversationId(String openConversationId) {
            this.openConversationId = openConversationId;
            return this;
        }
        public String getOpenConversationId() {
            return this.openConversationId;
        }

        public QuerySendMsgTaskStatisticsResponseBodyRecordsGroup setOpenGroupSetId(String openGroupSetId) {
            this.openGroupSetId = openGroupSetId;
            return this;
        }
        public String getOpenGroupSetId() {
            return this.openGroupSetId;
        }

        public QuerySendMsgTaskStatisticsResponseBodyRecordsGroup setOpenTeamId(String openTeamId) {
            this.openTeamId = openTeamId;
            return this;
        }
        public String getOpenTeamId() {
            return this.openTeamId;
        }

    }

    public static class QuerySendMsgTaskStatisticsResponseBodyRecordsGroupUserReadStatistics extends TeaModel {
        @NameInMap("openBatchTaskId")
        public String openBatchTaskId;

        @NameInMap("openConversationId")
        public String openConversationId;

        @NameInMap("readUserInc")
        public Long readUserInc;

        @NameInMap("sendUserInc")
        public Long sendUserInc;

        @NameInMap("unReadUserInc")
        public Long unReadUserInc;

        public static QuerySendMsgTaskStatisticsResponseBodyRecordsGroupUserReadStatistics build(java.util.Map<String, ?> map) throws Exception {
            QuerySendMsgTaskStatisticsResponseBodyRecordsGroupUserReadStatistics self = new QuerySendMsgTaskStatisticsResponseBodyRecordsGroupUserReadStatistics();
            return TeaModel.build(map, self);
        }

        public QuerySendMsgTaskStatisticsResponseBodyRecordsGroupUserReadStatistics setOpenBatchTaskId(String openBatchTaskId) {
            this.openBatchTaskId = openBatchTaskId;
            return this;
        }
        public String getOpenBatchTaskId() {
            return this.openBatchTaskId;
        }

        public QuerySendMsgTaskStatisticsResponseBodyRecordsGroupUserReadStatistics setOpenConversationId(String openConversationId) {
            this.openConversationId = openConversationId;
            return this;
        }
        public String getOpenConversationId() {
            return this.openConversationId;
        }

        public QuerySendMsgTaskStatisticsResponseBodyRecordsGroupUserReadStatistics setReadUserInc(Long readUserInc) {
            this.readUserInc = readUserInc;
            return this;
        }
        public Long getReadUserInc() {
            return this.readUserInc;
        }

        public QuerySendMsgTaskStatisticsResponseBodyRecordsGroupUserReadStatistics setSendUserInc(Long sendUserInc) {
            this.sendUserInc = sendUserInc;
            return this;
        }
        public Long getSendUserInc() {
            return this.sendUserInc;
        }

        public QuerySendMsgTaskStatisticsResponseBodyRecordsGroupUserReadStatistics setUnReadUserInc(Long unReadUserInc) {
            this.unReadUserInc = unReadUserInc;
            return this;
        }
        public Long getUnReadUserInc() {
            return this.unReadUserInc;
        }

    }

    public static class QuerySendMsgTaskStatisticsResponseBodyRecords extends TeaModel {
        @NameInMap("errorDetail")
        public String errorDetail;

        @NameInMap("group")
        public QuerySendMsgTaskStatisticsResponseBodyRecordsGroup group;

        @NameInMap("groupUserReadStatistics")
        public QuerySendMsgTaskStatisticsResponseBodyRecordsGroupUserReadStatistics groupUserReadStatistics;

        @NameInMap("openMsgId")
        public String openMsgId;

        @NameInMap("status")
        public String status;

        public static QuerySendMsgTaskStatisticsResponseBodyRecords build(java.util.Map<String, ?> map) throws Exception {
            QuerySendMsgTaskStatisticsResponseBodyRecords self = new QuerySendMsgTaskStatisticsResponseBodyRecords();
            return TeaModel.build(map, self);
        }

        public QuerySendMsgTaskStatisticsResponseBodyRecords setErrorDetail(String errorDetail) {
            this.errorDetail = errorDetail;
            return this;
        }
        public String getErrorDetail() {
            return this.errorDetail;
        }

        public QuerySendMsgTaskStatisticsResponseBodyRecords setGroup(QuerySendMsgTaskStatisticsResponseBodyRecordsGroup group) {
            this.group = group;
            return this;
        }
        public QuerySendMsgTaskStatisticsResponseBodyRecordsGroup getGroup() {
            return this.group;
        }

        public QuerySendMsgTaskStatisticsResponseBodyRecords setGroupUserReadStatistics(QuerySendMsgTaskStatisticsResponseBodyRecordsGroupUserReadStatistics groupUserReadStatistics) {
            this.groupUserReadStatistics = groupUserReadStatistics;
            return this;
        }
        public QuerySendMsgTaskStatisticsResponseBodyRecordsGroupUserReadStatistics getGroupUserReadStatistics() {
            return this.groupUserReadStatistics;
        }

        public QuerySendMsgTaskStatisticsResponseBodyRecords setOpenMsgId(String openMsgId) {
            this.openMsgId = openMsgId;
            return this;
        }
        public String getOpenMsgId() {
            return this.openMsgId;
        }

        public QuerySendMsgTaskStatisticsResponseBodyRecords setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

    }

}
