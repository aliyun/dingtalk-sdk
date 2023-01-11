// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryEduAssetSpacesResponseBody extends TeaModel {
    /**
     * <p>是否还有数据</p>
     */
    @NameInMap("hasMore")
    public Boolean hasMore;

    /**
     * <p>表示当前调用返回读取到的位置，空代表数据已经读取完毕</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <p>空间结果集</p>
     */
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
         * <p>创建时间的时间戳</p>
         */
        @NameInMap("createTimeMillis")
        public Long createTimeMillis;

        /**
         * <p>修改时间的时间戳</p>
         */
        @NameInMap("modifyTimeMillis")
        public Long modifyTimeMillis;

        /**
         * <p>权限类型acl：acl授权；custom：自定义授权</p>
         */
        @NameInMap("permissionMode")
        public String permissionMode;

        /**
         * <p>空间容量</p>
         */
        @NameInMap("quota")
        public Long quota;

        /**
         * <p>空间id</p>
         */
        @NameInMap("spaceId")
        public String spaceId;

        /**
         * <p>空间名称</p>
         */
        @NameInMap("spaceName")
        public String spaceName;

        /**
         * <p>空间类型</p>
         */
        @NameInMap("spaceType")
        public String spaceType;

        /**
         * <p>已使用容量</p>
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
