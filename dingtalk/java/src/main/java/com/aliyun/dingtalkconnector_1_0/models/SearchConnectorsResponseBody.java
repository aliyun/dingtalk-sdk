// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconnector_1_0.models;

import com.aliyun.tea.*;

public class SearchConnectorsResponseBody extends TeaModel {
    /**
     * <p>是否有更多记录</p>
     */
    @NameInMap("hasMore")
    public Boolean hasMore;

    /**
     * <p>连接器信息列表</p>
     */
    @NameInMap("list")
    public java.util.List<SearchConnectorsResponseBodyList> list;

    /**
     * <p>下一页记录的查询位置</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <p>总记录数</p>
     */
    @NameInMap("totalCount")
    public String totalCount;

    public static SearchConnectorsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SearchConnectorsResponseBody self = new SearchConnectorsResponseBody();
        return TeaModel.build(map, self);
    }

    public SearchConnectorsResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public SearchConnectorsResponseBody setList(java.util.List<SearchConnectorsResponseBodyList> list) {
        this.list = list;
        return this;
    }
    public java.util.List<SearchConnectorsResponseBodyList> getList() {
        return this.list;
    }

    public SearchConnectorsResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public SearchConnectorsResponseBody setTotalCount(String totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public String getTotalCount() {
        return this.totalCount;
    }

    public static class SearchConnectorsResponseBodyList extends TeaModel {
        /**
         * <p>连接器的描述信息</p>
         */
        @NameInMap("description")
        public String description;

        /**
         * <p>连接器的图标</p>
         */
        @NameInMap("icon")
        public String icon;

        /**
         * <p>连接器的ID</p>
         */
        @NameInMap("id")
        public String id;

        /**
         * <p>连接器的名称</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>连接器的提供组织</p>
         */
        @NameInMap("providerCorpId")
        public String providerCorpId;

        public static SearchConnectorsResponseBodyList build(java.util.Map<String, ?> map) throws Exception {
            SearchConnectorsResponseBodyList self = new SearchConnectorsResponseBodyList();
            return TeaModel.build(map, self);
        }

        public SearchConnectorsResponseBodyList setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public SearchConnectorsResponseBodyList setIcon(String icon) {
            this.icon = icon;
            return this;
        }
        public String getIcon() {
            return this.icon;
        }

        public SearchConnectorsResponseBodyList setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public SearchConnectorsResponseBodyList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public SearchConnectorsResponseBodyList setProviderCorpId(String providerCorpId) {
            this.providerCorpId = providerCorpId;
            return this;
        }
        public String getProviderCorpId() {
            return this.providerCorpId;
        }

    }

}
