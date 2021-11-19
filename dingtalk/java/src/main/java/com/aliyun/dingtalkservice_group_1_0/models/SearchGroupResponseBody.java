// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class SearchGroupResponseBody extends TeaModel {
    // 本次请求条件下的数据总量，此参数为可选参数，默认可不返回。本次请求条件下的数据总量，此参数为可选参数，默认可不返回
    @NameInMap("totalCount")
    public Integer totalCount;

    // 表示当前调用返回读取到的位置，空代表数据已经读取完毕
    @NameInMap("nextToken")
    public String nextToken;

    // 本次请求所返回的最大记录条数。
    @NameInMap("maxResults")
    public Integer maxResults;

    // 已读未读信息列表
    @NameInMap("records")
    public java.util.List<SearchGroupResponseBodyRecords> records;

    public static SearchGroupResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SearchGroupResponseBody self = new SearchGroupResponseBody();
        return TeaModel.build(map, self);
    }

    public SearchGroupResponseBody setTotalCount(Integer totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Integer getTotalCount() {
        return this.totalCount;
    }

    public SearchGroupResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public SearchGroupResponseBody setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public SearchGroupResponseBody setRecords(java.util.List<SearchGroupResponseBodyRecords> records) {
        this.records = records;
        return this;
    }
    public java.util.List<SearchGroupResponseBodyRecords> getRecords() {
        return this.records;
    }

    public static class SearchGroupResponseBodyRecords extends TeaModel {
        // 开放群ID
        @NameInMap("openConversationId")
        public String openConversationId;

        // 群名称
        @NameInMap("groupName")
        public String groupName;

        // 开放团队ID
        @NameInMap("openTeamId")
        public String openTeamId;

        // 开放群组ID
        @NameInMap("openGroupSetId")
        public String openGroupSetId;

        // 入群链接
        @NameInMap("groupUrl")
        public String groupUrl;

        public static SearchGroupResponseBodyRecords build(java.util.Map<String, ?> map) throws Exception {
            SearchGroupResponseBodyRecords self = new SearchGroupResponseBodyRecords();
            return TeaModel.build(map, self);
        }

        public SearchGroupResponseBodyRecords setOpenConversationId(String openConversationId) {
            this.openConversationId = openConversationId;
            return this;
        }
        public String getOpenConversationId() {
            return this.openConversationId;
        }

        public SearchGroupResponseBodyRecords setGroupName(String groupName) {
            this.groupName = groupName;
            return this;
        }
        public String getGroupName() {
            return this.groupName;
        }

        public SearchGroupResponseBodyRecords setOpenTeamId(String openTeamId) {
            this.openTeamId = openTeamId;
            return this;
        }
        public String getOpenTeamId() {
            return this.openTeamId;
        }

        public SearchGroupResponseBodyRecords setOpenGroupSetId(String openGroupSetId) {
            this.openGroupSetId = openGroupSetId;
            return this;
        }
        public String getOpenGroupSetId() {
            return this.openGroupSetId;
        }

        public SearchGroupResponseBodyRecords setGroupUrl(String groupUrl) {
            this.groupUrl = groupUrl;
            return this;
        }
        public String getGroupUrl() {
            return this.groupUrl;
        }

    }

}
