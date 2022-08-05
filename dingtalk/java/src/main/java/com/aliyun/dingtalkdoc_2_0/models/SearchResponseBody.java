// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class SearchResponseBody extends TeaModel {
    // 节点搜索结果。
    @NameInMap("dentryResult")
    public SearchResponseBodyDentryResult dentryResult;

    // 知识库搜索结果。
    @NameInMap("spaceResult")
    public SearchResponseBodySpaceResult spaceResult;

    public static SearchResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SearchResponseBody self = new SearchResponseBody();
        return TeaModel.build(map, self);
    }

    public SearchResponseBody setDentryResult(SearchResponseBodyDentryResult dentryResult) {
        this.dentryResult = dentryResult;
        return this;
    }
    public SearchResponseBodyDentryResult getDentryResult() {
        return this.dentryResult;
    }

    public SearchResponseBody setSpaceResult(SearchResponseBodySpaceResult spaceResult) {
        this.spaceResult = spaceResult;
        return this;
    }
    public SearchResponseBodySpaceResult getSpaceResult() {
        return this.spaceResult;
    }

    public static class SearchResponseBodyDentryResultItems extends TeaModel {
        // 如果内容命中了关键词，会返回该部分内容，带高亮。
        @NameInMap("content")
        public String content;

        // 创建信息。
        @NameInMap("creation")
        public OpenActionModel creation;

        // 节点id。
        @NameInMap("dentryId")
        public String dentryId;

        // 节点唯一标识。
        @NameInMap("dentryUuid")
        public String dentryUuid;

        // 文件名扩展。
        @NameInMap("extension")
        public String extension;

        // 节点图标url。
        @NameInMap("iconUrl")
        public String iconUrl;

        // 最后修改信息。
        @NameInMap("lastEdition")
        public OpenActionModel lastEdition;

        // 节点名称，如果命中了关键词，会带有高亮。
        @NameInMap("name")
        public String name;

        // 节点原始名称，不带高亮。
        @NameInMap("originName")
        public String originName;

        // 节点的路径。
        @NameInMap("path")
        public String path;

        // 文件类型。1-文档；2-表格；3-脑图；4-演示；5-白板；6-office文字；7-office表格；8-office ppt；10-多维表格；11-文本；12-图片；13-视频；14-音频；15-压缩文件；16-其他。
        @NameInMap("searchFileType")
        public Integer searchFileType;

        // 节点所属的知识库id。
        @NameInMap("spaceId")
        public String spaceId;

        // 文档缩略图url。
        @NameInMap("thumbnailUrl")
        public String thumbnailUrl;

        // 节点访问url。
        @NameInMap("url")
        public String url;

        public static SearchResponseBodyDentryResultItems build(java.util.Map<String, ?> map) throws Exception {
            SearchResponseBodyDentryResultItems self = new SearchResponseBodyDentryResultItems();
            return TeaModel.build(map, self);
        }

        public SearchResponseBodyDentryResultItems setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

        public SearchResponseBodyDentryResultItems setCreation(OpenActionModel creation) {
            this.creation = creation;
            return this;
        }
        public OpenActionModel getCreation() {
            return this.creation;
        }

        public SearchResponseBodyDentryResultItems setDentryId(String dentryId) {
            this.dentryId = dentryId;
            return this;
        }
        public String getDentryId() {
            return this.dentryId;
        }

        public SearchResponseBodyDentryResultItems setDentryUuid(String dentryUuid) {
            this.dentryUuid = dentryUuid;
            return this;
        }
        public String getDentryUuid() {
            return this.dentryUuid;
        }

        public SearchResponseBodyDentryResultItems setExtension(String extension) {
            this.extension = extension;
            return this;
        }
        public String getExtension() {
            return this.extension;
        }

        public SearchResponseBodyDentryResultItems setIconUrl(String iconUrl) {
            this.iconUrl = iconUrl;
            return this;
        }
        public String getIconUrl() {
            return this.iconUrl;
        }

        public SearchResponseBodyDentryResultItems setLastEdition(OpenActionModel lastEdition) {
            this.lastEdition = lastEdition;
            return this;
        }
        public OpenActionModel getLastEdition() {
            return this.lastEdition;
        }

        public SearchResponseBodyDentryResultItems setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public SearchResponseBodyDentryResultItems setOriginName(String originName) {
            this.originName = originName;
            return this;
        }
        public String getOriginName() {
            return this.originName;
        }

        public SearchResponseBodyDentryResultItems setPath(String path) {
            this.path = path;
            return this;
        }
        public String getPath() {
            return this.path;
        }

        public SearchResponseBodyDentryResultItems setSearchFileType(Integer searchFileType) {
            this.searchFileType = searchFileType;
            return this;
        }
        public Integer getSearchFileType() {
            return this.searchFileType;
        }

        public SearchResponseBodyDentryResultItems setSpaceId(String spaceId) {
            this.spaceId = spaceId;
            return this;
        }
        public String getSpaceId() {
            return this.spaceId;
        }

        public SearchResponseBodyDentryResultItems setThumbnailUrl(String thumbnailUrl) {
            this.thumbnailUrl = thumbnailUrl;
            return this;
        }
        public String getThumbnailUrl() {
            return this.thumbnailUrl;
        }

        public SearchResponseBodyDentryResultItems setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

    }

    public static class SearchResponseBodyDentryResult extends TeaModel {
        // 是否还有更多数据。
        @NameInMap("hasMore")
        public Boolean hasMore;

        // 搜索命中的节点列表。
        @NameInMap("items")
        public java.util.List<SearchResponseBodyDentryResultItems> items;

        // 分页游标。
        @NameInMap("nextToken")
        public String nextToken;

        public static SearchResponseBodyDentryResult build(java.util.Map<String, ?> map) throws Exception {
            SearchResponseBodyDentryResult self = new SearchResponseBodyDentryResult();
            return TeaModel.build(map, self);
        }

        public SearchResponseBodyDentryResult setHasMore(Boolean hasMore) {
            this.hasMore = hasMore;
            return this;
        }
        public Boolean getHasMore() {
            return this.hasMore;
        }

        public SearchResponseBodyDentryResult setItems(java.util.List<SearchResponseBodyDentryResultItems> items) {
            this.items = items;
            return this;
        }
        public java.util.List<SearchResponseBodyDentryResultItems> getItems() {
            return this.items;
        }

        public SearchResponseBodyDentryResult setNextToken(String nextToken) {
            this.nextToken = nextToken;
            return this;
        }
        public String getNextToken() {
            return this.nextToken;
        }

    }

    public static class SearchResponseBodySpaceResultItemsIconVO extends TeaModel {
        // 图标信息。
        @NameInMap("icon")
        public String icon;

        // 知识库图标的类型。
        @NameInMap("type")
        public String type;

        public static SearchResponseBodySpaceResultItemsIconVO build(java.util.Map<String, ?> map) throws Exception {
            SearchResponseBodySpaceResultItemsIconVO self = new SearchResponseBodySpaceResultItemsIconVO();
            return TeaModel.build(map, self);
        }

        public SearchResponseBodySpaceResultItemsIconVO setIcon(String icon) {
            this.icon = icon;
            return this;
        }
        public String getIcon() {
            return this.icon;
        }

        public SearchResponseBodySpaceResultItemsIconVO setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class SearchResponseBodySpaceResultItemsUserLastOperation extends TeaModel {
        // 操作人名称。
        @NameInMap("name")
        public String name;

        // 操作的时间戳（ms）。
        @NameInMap("time")
        public Long time;

        public static SearchResponseBodySpaceResultItemsUserLastOperation build(java.util.Map<String, ?> map) throws Exception {
            SearchResponseBodySpaceResultItemsUserLastOperation self = new SearchResponseBodySpaceResultItemsUserLastOperation();
            return TeaModel.build(map, self);
        }

        public SearchResponseBodySpaceResultItemsUserLastOperation setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public SearchResponseBodySpaceResultItemsUserLastOperation setTime(Long time) {
            this.time = time;
            return this;
        }
        public Long getTime() {
            return this.time;
        }

    }

    public static class SearchResponseBodySpaceResultItems extends TeaModel {
        // 知识库图标。
        @NameInMap("iconVO")
        public SearchResponseBodySpaceResultItemsIconVO iconVO;

        // 知识库名称，如果命中了关键词，会带有高亮。
        @NameInMap("name")
        public String name;

        // 知识库原始名称，不带高亮。
        @NameInMap("originName")
        public String originName;

        // 知识库id。
        @NameInMap("spaceId")
        public String spaceId;

        // 知识库访问url。
        @NameInMap("url")
        public String url;

        // 用户最后一次操作信息。
        @NameInMap("userLastOperation")
        public SearchResponseBodySpaceResultItemsUserLastOperation userLastOperation;

        public static SearchResponseBodySpaceResultItems build(java.util.Map<String, ?> map) throws Exception {
            SearchResponseBodySpaceResultItems self = new SearchResponseBodySpaceResultItems();
            return TeaModel.build(map, self);
        }

        public SearchResponseBodySpaceResultItems setIconVO(SearchResponseBodySpaceResultItemsIconVO iconVO) {
            this.iconVO = iconVO;
            return this;
        }
        public SearchResponseBodySpaceResultItemsIconVO getIconVO() {
            return this.iconVO;
        }

        public SearchResponseBodySpaceResultItems setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public SearchResponseBodySpaceResultItems setOriginName(String originName) {
            this.originName = originName;
            return this;
        }
        public String getOriginName() {
            return this.originName;
        }

        public SearchResponseBodySpaceResultItems setSpaceId(String spaceId) {
            this.spaceId = spaceId;
            return this;
        }
        public String getSpaceId() {
            return this.spaceId;
        }

        public SearchResponseBodySpaceResultItems setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

        public SearchResponseBodySpaceResultItems setUserLastOperation(SearchResponseBodySpaceResultItemsUserLastOperation userLastOperation) {
            this.userLastOperation = userLastOperation;
            return this;
        }
        public SearchResponseBodySpaceResultItemsUserLastOperation getUserLastOperation() {
            return this.userLastOperation;
        }

    }

    public static class SearchResponseBodySpaceResult extends TeaModel {
        // 是否还有更多数据。
        @NameInMap("hasMore")
        public Boolean hasMore;

        // 搜索命中的知识库列表。
        @NameInMap("items")
        public java.util.List<SearchResponseBodySpaceResultItems> items;

        // 分页游标。
        @NameInMap("nextToken")
        public String nextToken;

        public static SearchResponseBodySpaceResult build(java.util.Map<String, ?> map) throws Exception {
            SearchResponseBodySpaceResult self = new SearchResponseBodySpaceResult();
            return TeaModel.build(map, self);
        }

        public SearchResponseBodySpaceResult setHasMore(Boolean hasMore) {
            this.hasMore = hasMore;
            return this;
        }
        public Boolean getHasMore() {
            return this.hasMore;
        }

        public SearchResponseBodySpaceResult setItems(java.util.List<SearchResponseBodySpaceResultItems> items) {
            this.items = items;
            return this;
        }
        public java.util.List<SearchResponseBodySpaceResultItems> getItems() {
            return this.items;
        }

        public SearchResponseBodySpaceResult setNextToken(String nextToken) {
            this.nextToken = nextToken;
            return this;
        }
        public String getNextToken() {
            return this.nextToken;
        }

    }

}
