// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class ListRecentsResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("hasMore")
    public Boolean hasMore;

    /**
     * <strong>example:</strong>
     * <p>nextToken</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <strong>example:</strong>
     * <p>recentDentryList</p>
     */
    @NameInMap("recentDentryList")
    public java.util.List<ListRecentsResponseBodyRecentDentryList> recentDentryList;

    public static ListRecentsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListRecentsResponseBody self = new ListRecentsResponseBody();
        return TeaModel.build(map, self);
    }

    public ListRecentsResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public ListRecentsResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public ListRecentsResponseBody setRecentDentryList(java.util.List<ListRecentsResponseBodyRecentDentryList> recentDentryList) {
        this.recentDentryList = recentDentryList;
        return this;
    }
    public java.util.List<ListRecentsResponseBodyRecentDentryList> getRecentDentryList() {
        return this.recentDentryList;
    }

    public static class ListRecentsResponseBodyRecentDentryListResourceSpaceInfo extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>im</p>
         */
        @NameInMap("sceneType")
        public String sceneType;

        public static ListRecentsResponseBodyRecentDentryListResourceSpaceInfo build(java.util.Map<String, ?> map) throws Exception {
            ListRecentsResponseBodyRecentDentryListResourceSpaceInfo self = new ListRecentsResponseBodyRecentDentryListResourceSpaceInfo();
            return TeaModel.build(map, self);
        }

        public ListRecentsResponseBodyRecentDentryListResourceSpaceInfo setSceneType(String sceneType) {
            this.sceneType = sceneType;
            return this;
        }
        public String getSceneType() {
            return this.sceneType;
        }

    }

    public static class ListRecentsResponseBodyRecentDentryListResource extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>dentryUuid</p>
         */
        @NameInMap("dentryUuid")
        public String dentryUuid;

        /**
         * <strong>example:</strong>
         * <p>driveDentryId</p>
         */
        @NameInMap("driveDentryId")
        public String driveDentryId;

        /**
         * <strong>example:</strong>
         * <p>driveSpaceId</p>
         */
        @NameInMap("driveSpaceId")
        public String driveSpaceId;

        /**
         * <strong>example:</strong>
         * <p>docx</p>
         */
        @NameInMap("extension")
        public String extension;

        /**
         * <strong>example:</strong>
         * <p>name</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <strong>example:</strong>
         * <p>spaceInfo</p>
         */
        @NameInMap("spaceInfo")
        public ListRecentsResponseBodyRecentDentryListResourceSpaceInfo spaceInfo;

        /**
         * <strong>example:</strong>
         * <p><a href="https://example.com">https://example.com</a></p>
         */
        @NameInMap("url")
        public String url;

        public static ListRecentsResponseBodyRecentDentryListResource build(java.util.Map<String, ?> map) throws Exception {
            ListRecentsResponseBodyRecentDentryListResource self = new ListRecentsResponseBodyRecentDentryListResource();
            return TeaModel.build(map, self);
        }

        public ListRecentsResponseBodyRecentDentryListResource setDentryUuid(String dentryUuid) {
            this.dentryUuid = dentryUuid;
            return this;
        }
        public String getDentryUuid() {
            return this.dentryUuid;
        }

        public ListRecentsResponseBodyRecentDentryListResource setDriveDentryId(String driveDentryId) {
            this.driveDentryId = driveDentryId;
            return this;
        }
        public String getDriveDentryId() {
            return this.driveDentryId;
        }

        public ListRecentsResponseBodyRecentDentryListResource setDriveSpaceId(String driveSpaceId) {
            this.driveSpaceId = driveSpaceId;
            return this;
        }
        public String getDriveSpaceId() {
            return this.driveSpaceId;
        }

        public ListRecentsResponseBodyRecentDentryListResource setExtension(String extension) {
            this.extension = extension;
            return this;
        }
        public String getExtension() {
            return this.extension;
        }

        public ListRecentsResponseBodyRecentDentryListResource setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ListRecentsResponseBodyRecentDentryListResource setSpaceInfo(ListRecentsResponseBodyRecentDentryListResourceSpaceInfo spaceInfo) {
            this.spaceInfo = spaceInfo;
            return this;
        }
        public ListRecentsResponseBodyRecentDentryListResourceSpaceInfo getSpaceInfo() {
            return this.spaceInfo;
        }

        public ListRecentsResponseBodyRecentDentryListResource setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

    }

    public static class ListRecentsResponseBodyRecentDentryList extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>123</p>
         */
        @NameInMap("accessTime")
        public Long accessTime;

        /**
         * <strong>example:</strong>
         * <p>true</p>
         */
        @NameInMap("deleted")
        public Boolean deleted;

        /**
         * <strong>example:</strong>
         * <p><a href="https://example.com">https://example.com</a></p>
         */
        @NameInMap("icon")
        public String icon;

        /**
         * <strong>example:</strong>
         * <p>0</p>
         */
        @NameInMap("operateType")
        public Integer operateType;

        /**
         * <strong>example:</strong>
         * <p>resource</p>
         */
        @NameInMap("resource")
        public ListRecentsResponseBodyRecentDentryListResource resource;

        public static ListRecentsResponseBodyRecentDentryList build(java.util.Map<String, ?> map) throws Exception {
            ListRecentsResponseBodyRecentDentryList self = new ListRecentsResponseBodyRecentDentryList();
            return TeaModel.build(map, self);
        }

        public ListRecentsResponseBodyRecentDentryList setAccessTime(Long accessTime) {
            this.accessTime = accessTime;
            return this;
        }
        public Long getAccessTime() {
            return this.accessTime;
        }

        public ListRecentsResponseBodyRecentDentryList setDeleted(Boolean deleted) {
            this.deleted = deleted;
            return this;
        }
        public Boolean getDeleted() {
            return this.deleted;
        }

        public ListRecentsResponseBodyRecentDentryList setIcon(String icon) {
            this.icon = icon;
            return this;
        }
        public String getIcon() {
            return this.icon;
        }

        public ListRecentsResponseBodyRecentDentryList setOperateType(Integer operateType) {
            this.operateType = operateType;
            return this;
        }
        public Integer getOperateType() {
            return this.operateType;
        }

        public ListRecentsResponseBodyRecentDentryList setResource(ListRecentsResponseBodyRecentDentryListResource resource) {
            this.resource = resource;
            return this;
        }
        public ListRecentsResponseBodyRecentDentryListResource getResource() {
            return this.resource;
        }

    }

}
