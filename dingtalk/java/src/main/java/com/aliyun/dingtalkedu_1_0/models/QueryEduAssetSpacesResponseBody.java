// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryEduAssetSpacesResponseBody extends TeaModel {
    @NameInMap("hasMore")
    public Boolean hasMore;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("spaces")
    public java.util.List<QueryEduAssetSpacesResponseBodySpaces> spaces;

    public static QueryEduAssetSpacesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryEduAssetSpacesResponseBody self = new QueryEduAssetSpacesResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryEduAssetSpacesResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public QueryEduAssetSpacesResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public QueryEduAssetSpacesResponseBody setSpaces(java.util.List<QueryEduAssetSpacesResponseBodySpaces> spaces) {
        this.spaces = spaces;
        return this;
    }
    public java.util.List<QueryEduAssetSpacesResponseBodySpaces> getSpaces() {
        return this.spaces;
    }

    public static class QueryEduAssetSpacesResponseBodySpaces extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("createTimeMillis")
        public Long createTimeMillis;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("modifyTimeMillis")
        public Long modifyTimeMillis;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("permissionMode")
        public String permissionMode;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("quota")
        public Long quota;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("spaceId")
        public String spaceId;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("spaceName")
        public String spaceName;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("spaceType")
        public String spaceType;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("usedQuota")
        public Long usedQuota;

        public static QueryEduAssetSpacesResponseBodySpaces build(java.util.Map<String, ?> map) throws Exception {
            QueryEduAssetSpacesResponseBodySpaces self = new QueryEduAssetSpacesResponseBodySpaces();
            return TeaModel.build(map, self);
        }

        public QueryEduAssetSpacesResponseBodySpaces setCreateTimeMillis(Long createTimeMillis) {
            this.createTimeMillis = createTimeMillis;
            return this;
        }
        public Long getCreateTimeMillis() {
            return this.createTimeMillis;
        }

        public QueryEduAssetSpacesResponseBodySpaces setModifyTimeMillis(Long modifyTimeMillis) {
            this.modifyTimeMillis = modifyTimeMillis;
            return this;
        }
        public Long getModifyTimeMillis() {
            return this.modifyTimeMillis;
        }

        public QueryEduAssetSpacesResponseBodySpaces setPermissionMode(String permissionMode) {
            this.permissionMode = permissionMode;
            return this;
        }
        public String getPermissionMode() {
            return this.permissionMode;
        }

        public QueryEduAssetSpacesResponseBodySpaces setQuota(Long quota) {
            this.quota = quota;
            return this;
        }
        public Long getQuota() {
            return this.quota;
        }

        public QueryEduAssetSpacesResponseBodySpaces setSpaceId(String spaceId) {
            this.spaceId = spaceId;
            return this;
        }
        public String getSpaceId() {
            return this.spaceId;
        }

        public QueryEduAssetSpacesResponseBodySpaces setSpaceName(String spaceName) {
            this.spaceName = spaceName;
            return this;
        }
        public String getSpaceName() {
            return this.spaceName;
        }

        public QueryEduAssetSpacesResponseBodySpaces setSpaceType(String spaceType) {
            this.spaceType = spaceType;
            return this;
        }
        public String getSpaceType() {
            return this.spaceType;
        }

        public QueryEduAssetSpacesResponseBodySpaces setUsedQuota(Long usedQuota) {
            this.usedQuota = usedQuota;
            return this;
        }
        public Long getUsedQuota() {
            return this.usedQuota;
        }

    }

}
