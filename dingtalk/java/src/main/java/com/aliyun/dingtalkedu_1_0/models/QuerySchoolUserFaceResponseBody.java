// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QuerySchoolUserFaceResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>dingding123</p>
     */
    @NameInMap("corpId")
    public String corpId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>true/false</p>
     */
    @NameInMap("hasMore")
    public Boolean hasMore;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userFaceList")
    public java.util.List<QuerySchoolUserFaceResponseBodyUserFaceList> userFaceList;

    public static QuerySchoolUserFaceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QuerySchoolUserFaceResponseBody self = new QuerySchoolUserFaceResponseBody();
        return TeaModel.build(map, self);
    }

    public QuerySchoolUserFaceResponseBody setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public QuerySchoolUserFaceResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public QuerySchoolUserFaceResponseBody setUserFaceList(java.util.List<QuerySchoolUserFaceResponseBodyUserFaceList> userFaceList) {
        this.userFaceList = userFaceList;
        return this;
    }
    public java.util.List<QuerySchoolUserFaceResponseBodyUserFaceList> getUserFaceList() {
        return this.userFaceList;
    }

    public static class QuerySchoolUserFaceResponseBodyUserFaceList extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>200001</p>
         */
        @NameInMap("faceId")
        public String faceId;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>小明</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>1有效；0无效</p>
         */
        @NameInMap("status")
        public Integer status;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>30001</p>
         */
        @NameInMap("userId")
        public String userId;

        public static QuerySchoolUserFaceResponseBodyUserFaceList build(java.util.Map<String, ?> map) throws Exception {
            QuerySchoolUserFaceResponseBodyUserFaceList self = new QuerySchoolUserFaceResponseBodyUserFaceList();
            return TeaModel.build(map, self);
        }

        public QuerySchoolUserFaceResponseBodyUserFaceList setFaceId(String faceId) {
            this.faceId = faceId;
            return this;
        }
        public String getFaceId() {
            return this.faceId;
        }

        public QuerySchoolUserFaceResponseBodyUserFaceList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public QuerySchoolUserFaceResponseBodyUserFaceList setStatus(Integer status) {
            this.status = status;
            return this;
        }
        public Integer getStatus() {
            return this.status;
        }

        public QuerySchoolUserFaceResponseBodyUserFaceList setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
