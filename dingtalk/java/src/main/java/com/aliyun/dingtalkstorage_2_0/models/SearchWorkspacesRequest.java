// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_2_0.models;

import com.aliyun.tea.*;

public class SearchWorkspacesRequest extends TeaModel {
    @NameInMap("keyword")
    public String keyword;

    @NameInMap("option")
    public SearchWorkspacesRequestOption option;

    @NameInMap("operatorId")
    public String operatorId;

    public static SearchWorkspacesRequest build(java.util.Map<String, ?> map) throws Exception {
        SearchWorkspacesRequest self = new SearchWorkspacesRequest();
        return TeaModel.build(map, self);
    }

    public SearchWorkspacesRequest setKeyword(String keyword) {
        this.keyword = keyword;
        return this;
    }
    public String getKeyword() {
        return this.keyword;
    }

    public SearchWorkspacesRequest setOption(SearchWorkspacesRequestOption option) {
        this.option = option;
        return this;
    }
    public SearchWorkspacesRequestOption getOption() {
        return this.option;
    }

    public SearchWorkspacesRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public static class SearchWorkspacesRequestOption extends TeaModel {
        @NameInMap("maxResults")
        public Integer maxResults;

        @NameInMap("nextToken")
        public String nextToken;

        public static SearchWorkspacesRequestOption build(java.util.Map<String, ?> map) throws Exception {
            SearchWorkspacesRequestOption self = new SearchWorkspacesRequestOption();
            return TeaModel.build(map, self);
        }

        public SearchWorkspacesRequestOption setMaxResults(Integer maxResults) {
            this.maxResults = maxResults;
            return this;
        }
        public Integer getMaxResults() {
            return this.maxResults;
        }

        public SearchWorkspacesRequestOption setNextToken(String nextToken) {
            this.nextToken = nextToken;
            return this;
        }
        public String getNextToken() {
            return this.nextToken;
        }

    }

}
