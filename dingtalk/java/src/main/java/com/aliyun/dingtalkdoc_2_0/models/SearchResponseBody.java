// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class SearchResponseBody extends TeaModel {
    @NameInMap("dentryResult")
    public SearchResponseBodyDentryResult dentryResult;

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
        @NameInMap("content")
        public String content;

        @NameInMap("creation")
        public OpenActionModel creation;

        @NameInMap("dentryId")
        public String dentryId;

        @NameInMap("dentryUuid")
        public String dentryUuid;

        @NameInMap("extension")
        public String extension;

        @NameInMap("iconUrl")
        public String iconUrl;

        @NameInMap("lastEdition")
        public OpenActionModel lastEdition;

        @NameInMap("name")
        public String name;

        @NameInMap("originName")
        public String originName;

        @NameInMap("path")
        public String path;

        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("sceneType")
        public Integer sceneType;

        @NameInMap("searchFileType")
        public Integer searchFileType;

        @NameInMap("spaceId")
        public String spaceId;

        @NameInMap("thumbnailUrl")
        public String thumbnailUrl;

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

        public SearchResponseBodyDentryResultItems setSceneType(Integer sceneType) {
            this.sceneType = sceneType;
            return this;
        }
        public Integer getSceneType() {
            return this.sceneType;
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
        @NameInMap("hasMore")
        public Boolean hasMore;

        @NameInMap("items")
        public java.util.List<SearchResponseBodyDentryResultItems> items;

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
        @NameInMap("icon")
        public String icon;

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

    public static class SearchResponseBodySpaceResultItemsTeamVO extends TeaModel {
        @NameInMap("id")
        public String id;

        @NameInMap("name")
        public String name;

        public static SearchResponseBodySpaceResultItemsTeamVO build(java.util.Map<String, ?> map) throws Exception {
            SearchResponseBodySpaceResultItemsTeamVO self = new SearchResponseBodySpaceResultItemsTeamVO();
            return TeaModel.build(map, self);
        }

        public SearchResponseBodySpaceResultItemsTeamVO setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public SearchResponseBodySpaceResultItemsTeamVO setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

    public static class SearchResponseBodySpaceResultItemsUserLastOperation extends TeaModel {
        @NameInMap("name")
        public String name;

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
        @NameInMap("iconVO")
        public SearchResponseBodySpaceResultItemsIconVO iconVO;

        @NameInMap("name")
        public String name;

        @NameInMap("originName")
        public String originName;

        @NameInMap("spaceId")
        public String spaceId;

        @NameInMap("teamVO")
        public SearchResponseBodySpaceResultItemsTeamVO teamVO;

        @NameInMap("url")
        public String url;

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

        public SearchResponseBodySpaceResultItems setTeamVO(SearchResponseBodySpaceResultItemsTeamVO teamVO) {
            this.teamVO = teamVO;
            return this;
        }
        public SearchResponseBodySpaceResultItemsTeamVO getTeamVO() {
            return this.teamVO;
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
        @NameInMap("hasMore")
        public Boolean hasMore;

        @NameInMap("items")
        public java.util.List<SearchResponseBodySpaceResultItems> items;

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
