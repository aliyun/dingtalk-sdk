// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class SearchGroupResponseBody extends TeaModel {
    @NameInMap("maxResults")
    public Integer maxResults;

    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("records")
    public java.util.List<SearchGroupResponseBodyRecords> records;

    @NameInMap("totalCount")
    public Integer totalCount;

    public static SearchGroupResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SearchGroupResponseBody self = new SearchGroupResponseBody();
        return TeaModel.build(map, self);
    }

    public SearchGroupResponseBody setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public SearchGroupResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public SearchGroupResponseBody setRecords(java.util.List<SearchGroupResponseBodyRecords> records) {
        this.records = records;
        return this;
    }
    public java.util.List<SearchGroupResponseBodyRecords> getRecords() {
        return this.records;
    }

    public SearchGroupResponseBody setTotalCount(Integer totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Integer getTotalCount() {
        return this.totalCount;
    }

    public static class SearchGroupResponseBodyRecords extends TeaModel {
        @NameInMap("groupName")
        public String groupName;

        @NameInMap("groupUrl")
        public String groupUrl;

        @NameInMap("openConversationId")
        public String openConversationId;

        @NameInMap("openGroupSetId")
        public String openGroupSetId;

        @NameInMap("openTeamId")
        public String openTeamId;

        public static SearchGroupResponseBodyRecords build(java.util.Map<String, ?> map) throws Exception {
            SearchGroupResponseBodyRecords self = new SearchGroupResponseBodyRecords();
            return TeaModel.build(map, self);
        }

        public SearchGroupResponseBodyRecords setGroupName(String groupName) {
            this.groupName = groupName;
            return this;
        }
        public String getGroupName() {
            return this.groupName;
        }

        public SearchGroupResponseBodyRecords setGroupUrl(String groupUrl) {
            this.groupUrl = groupUrl;
            return this;
        }
        public String getGroupUrl() {
            return this.groupUrl;
        }

        public SearchGroupResponseBodyRecords setOpenConversationId(String openConversationId) {
            this.openConversationId = openConversationId;
            return this;
        }
        public String getOpenConversationId() {
            return this.openConversationId;
        }

        public SearchGroupResponseBodyRecords setOpenGroupSetId(String openGroupSetId) {
            this.openGroupSetId = openGroupSetId;
            return this;
        }
        public String getOpenGroupSetId() {
            return this.openGroupSetId;
        }

        public SearchGroupResponseBodyRecords setOpenTeamId(String openTeamId) {
            this.openTeamId = openTeamId;
            return this;
        }
        public String getOpenTeamId() {
            return this.openTeamId;
        }

    }

}
