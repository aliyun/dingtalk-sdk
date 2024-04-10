// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_2_0.models;

import com.aliyun.tea.*;

public class SearchPublishDentriesResponseBody extends TeaModel {
    @NameInMap("items")
    public java.util.List<SearchPublishDentriesResponseBodyItems> items;

    @NameInMap("nextToken")
    public String nextToken;

    public static SearchPublishDentriesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SearchPublishDentriesResponseBody self = new SearchPublishDentriesResponseBody();
        return TeaModel.build(map, self);
    }

    public SearchPublishDentriesResponseBody setItems(java.util.List<SearchPublishDentriesResponseBodyItems> items) {
        this.items = items;
        return this;
    }
    public java.util.List<SearchPublishDentriesResponseBodyItems> getItems() {
        return this.items;
    }

    public SearchPublishDentriesResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public static class SearchPublishDentriesResponseBodyItems extends TeaModel {
        @NameInMap("name")
        public String name;

        @NameInMap("path")
        public String path;

        @NameInMap("summary")
        public String summary;

        @NameInMap("url")
        public String url;

        public static SearchPublishDentriesResponseBodyItems build(java.util.Map<String, ?> map) throws Exception {
            SearchPublishDentriesResponseBodyItems self = new SearchPublishDentriesResponseBodyItems();
            return TeaModel.build(map, self);
        }

        public SearchPublishDentriesResponseBodyItems setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public SearchPublishDentriesResponseBodyItems setPath(String path) {
            this.path = path;
            return this;
        }
        public String getPath() {
            return this.path;
        }

        public SearchPublishDentriesResponseBodyItems setSummary(String summary) {
            this.summary = summary;
            return this;
        }
        public String getSummary() {
            return this.summary;
        }

        public SearchPublishDentriesResponseBodyItems setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

    }

}
