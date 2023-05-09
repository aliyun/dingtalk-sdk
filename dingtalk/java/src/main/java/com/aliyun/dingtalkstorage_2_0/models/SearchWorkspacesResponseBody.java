// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_2_0.models;

import com.aliyun.tea.*;

public class SearchWorkspacesResponseBody extends TeaModel {
    @NameInMap("items")
    public java.util.List<SearchWorkspacesResponseBodyItems> items;

    @NameInMap("nextToken")
    public String nextToken;

    public static SearchWorkspacesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SearchWorkspacesResponseBody self = new SearchWorkspacesResponseBody();
        return TeaModel.build(map, self);
    }

    public SearchWorkspacesResponseBody setItems(java.util.List<SearchWorkspacesResponseBodyItems> items) {
        this.items = items;
        return this;
    }
    public java.util.List<SearchWorkspacesResponseBodyItems> getItems() {
        return this.items;
    }

    public SearchWorkspacesResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public static class SearchWorkspacesResponseBodyItems extends TeaModel {
        @NameInMap("name")
        public String name;

        @NameInMap("url")
        public String url;

        @NameInMap("workspaceId")
        public String workspaceId;

        public static SearchWorkspacesResponseBodyItems build(java.util.Map<String, ?> map) throws Exception {
            SearchWorkspacesResponseBodyItems self = new SearchWorkspacesResponseBodyItems();
            return TeaModel.build(map, self);
        }

        public SearchWorkspacesResponseBodyItems setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public SearchWorkspacesResponseBodyItems setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

        public SearchWorkspacesResponseBodyItems setWorkspaceId(String workspaceId) {
            this.workspaceId = workspaceId;
            return this;
        }
        public String getWorkspaceId() {
            return this.workspaceId;
        }

    }

}
