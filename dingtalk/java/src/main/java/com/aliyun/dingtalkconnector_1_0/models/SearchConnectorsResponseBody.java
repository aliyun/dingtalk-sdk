// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconnector_1_0.models;

import com.aliyun.tea.*;

public class SearchConnectorsResponseBody extends TeaModel {
    @NameInMap("hasMore")
    public Boolean hasMore;

    @NameInMap("list")
    public java.util.List<SearchConnectorsResponseBodyList> list;

    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <strong>example:</strong>
     * <p>1</p>
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
         * <strong>example:</strong>
         * <p>【钉钉官方】通讯录</p>
         */
        @NameInMap("description")
        public String description;

        /**
         * <strong>example:</strong>
         * <p><a href="https://static.dingtalk.com/media/lALPDfJ6WadAG1dgYA_96_96.png">https://static.dingtalk.com/media/lALPDfJ6WadAG1dgYA_96_96.png</a></p>
         */
        @NameInMap("icon")
        public String icon;

        /**
         * <strong>example:</strong>
         * <p>G-CONN-1015BC8093540B01B8D0000Q</p>
         */
        @NameInMap("id")
        public String id;

        /**
         * <strong>example:</strong>
         * <p>通讯录</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <strong>example:</strong>
         * <p>ding32fff839a3e0105d</p>
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
