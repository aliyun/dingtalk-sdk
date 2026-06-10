// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_2_0.models;

import com.aliyun.tea.*;

public class ListStarsResponseBody extends TeaModel {
    @NameInMap("hasMore")
    public Boolean hasMore;

    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("starList")
    public java.util.List<ListStarsResponseBodyStarList> starList;

    public static ListStarsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListStarsResponseBody self = new ListStarsResponseBody();
        return TeaModel.build(map, self);
    }

    public ListStarsResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public ListStarsResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public ListStarsResponseBody setStarList(java.util.List<ListStarsResponseBodyStarList> starList) {
        this.starList = starList;
        return this;
    }
    public java.util.List<ListStarsResponseBodyStarList> getStarList() {
        return this.starList;
    }

    public static class ListStarsResponseBodyStarListResource extends TeaModel {
        @NameInMap("contentType")
        public String contentType;

        @NameInMap("dentryType")
        public String dentryType;

        @NameInMap("dentryUuid")
        public String dentryUuid;

        @NameInMap("name")
        public String name;

        @NameInMap("url")
        public String url;

        public static ListStarsResponseBodyStarListResource build(java.util.Map<String, ?> map) throws Exception {
            ListStarsResponseBodyStarListResource self = new ListStarsResponseBodyStarListResource();
            return TeaModel.build(map, self);
        }

        public ListStarsResponseBodyStarListResource setContentType(String contentType) {
            this.contentType = contentType;
            return this;
        }
        public String getContentType() {
            return this.contentType;
        }

        public ListStarsResponseBodyStarListResource setDentryType(String dentryType) {
            this.dentryType = dentryType;
            return this;
        }
        public String getDentryType() {
            return this.dentryType;
        }

        public ListStarsResponseBodyStarListResource setDentryUuid(String dentryUuid) {
            this.dentryUuid = dentryUuid;
            return this;
        }
        public String getDentryUuid() {
            return this.dentryUuid;
        }

        public ListStarsResponseBodyStarListResource setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ListStarsResponseBodyStarListResource setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

    }

    public static class ListStarsResponseBodyStarList extends TeaModel {
        @NameInMap("createTime")
        public String createTime;

        @NameInMap("id")
        public String id;

        @NameInMap("location")
        public String location;

        @NameInMap("resource")
        public ListStarsResponseBodyStarListResource resource;

        @NameInMap("resourceType")
        public String resourceType;

        @NameInMap("starType")
        public Long starType;

        public static ListStarsResponseBodyStarList build(java.util.Map<String, ?> map) throws Exception {
            ListStarsResponseBodyStarList self = new ListStarsResponseBodyStarList();
            return TeaModel.build(map, self);
        }

        public ListStarsResponseBodyStarList setCreateTime(String createTime) {
            this.createTime = createTime;
            return this;
        }
        public String getCreateTime() {
            return this.createTime;
        }

        public ListStarsResponseBodyStarList setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public ListStarsResponseBodyStarList setLocation(String location) {
            this.location = location;
            return this;
        }
        public String getLocation() {
            return this.location;
        }

        public ListStarsResponseBodyStarList setResource(ListStarsResponseBodyStarListResource resource) {
            this.resource = resource;
            return this;
        }
        public ListStarsResponseBodyStarListResource getResource() {
            return this.resource;
        }

        public ListStarsResponseBodyStarList setResourceType(String resourceType) {
            this.resourceType = resourceType;
            return this;
        }
        public String getResourceType() {
            return this.resourceType;
        }

        public ListStarsResponseBodyStarList setStarType(Long starType) {
            this.starType = starType;
            return this;
        }
        public Long getStarType() {
            return this.starType;
        }

    }

}
