// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_2_0.models;

import com.aliyun.tea.*;

public class SearchPublishDentriesRequest extends TeaModel {
    @NameInMap("keyword")
    public String keyword;

    @NameInMap("option")
    public SearchPublishDentriesRequestOption option;

    @NameInMap("workspaceId")
    public String workspaceId;

    @NameInMap("operatorId")
    public String operatorId;

    public static SearchPublishDentriesRequest build(java.util.Map<String, ?> map) throws Exception {
        SearchPublishDentriesRequest self = new SearchPublishDentriesRequest();
        return TeaModel.build(map, self);
    }

    public SearchPublishDentriesRequest setKeyword(String keyword) {
        this.keyword = keyword;
        return this;
    }
    public String getKeyword() {
        return this.keyword;
    }

    public SearchPublishDentriesRequest setOption(SearchPublishDentriesRequestOption option) {
        this.option = option;
        return this;
    }
    public SearchPublishDentriesRequestOption getOption() {
        return this.option;
    }

    public SearchPublishDentriesRequest setWorkspaceId(String workspaceId) {
        this.workspaceId = workspaceId;
        return this;
    }
    public String getWorkspaceId() {
        return this.workspaceId;
    }

    public SearchPublishDentriesRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public static class SearchPublishDentriesRequestOption extends TeaModel {
        @NameInMap("maxResults")
        public Integer maxResults;

        @NameInMap("nextToken")
        public String nextToken;

        public static SearchPublishDentriesRequestOption build(java.util.Map<String, ?> map) throws Exception {
            SearchPublishDentriesRequestOption self = new SearchPublishDentriesRequestOption();
            return TeaModel.build(map, self);
        }

        public SearchPublishDentriesRequestOption setMaxResults(Integer maxResults) {
            this.maxResults = maxResults;
            return this;
        }
        public Integer getMaxResults() {
            return this.maxResults;
        }

        public SearchPublishDentriesRequestOption setNextToken(String nextToken) {
            this.nextToken = nextToken;
            return this;
        }
        public String getNextToken() {
            return this.nextToken;
        }

    }

}
