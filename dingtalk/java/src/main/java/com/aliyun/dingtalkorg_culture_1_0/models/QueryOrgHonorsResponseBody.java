// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkorg_culture_1_0.models;

import com.aliyun.tea.*;

public class QueryOrgHonorsResponseBody extends TeaModel {
    @NameInMap("result")
    public QueryOrgHonorsResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static QueryOrgHonorsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryOrgHonorsResponseBody self = new QueryOrgHonorsResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryOrgHonorsResponseBody setResult(QueryOrgHonorsResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public QueryOrgHonorsResponseBodyResult getResult() {
        return this.result;
    }

    public QueryOrgHonorsResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class QueryOrgHonorsResponseBodyResultOpenHonors extends TeaModel {
        /**
         * <p>荣誉含义</p>
         */
        @NameInMap("honorDesc")
        public String honorDesc;

        /**
         * <p>荣誉id</p>
         */
        @NameInMap("honorId")
        public Long honorId;

        /**
         * <p>荣誉图片url</p>
         */
        @NameInMap("honorImgUrl")
        public String honorImgUrl;

        /**
         * <p>荣誉名字</p>
         */
        @NameInMap("honorName")
        public String honorName;

        /**
         * <p>荣誉附赠的挂件图url</p>
         */
        @NameInMap("honorPendantImgUrl")
        public String honorPendantImgUrl;

        public static QueryOrgHonorsResponseBodyResultOpenHonors build(java.util.Map<String, ?> map) throws Exception {
            QueryOrgHonorsResponseBodyResultOpenHonors self = new QueryOrgHonorsResponseBodyResultOpenHonors();
            return TeaModel.build(map, self);
        }

        public QueryOrgHonorsResponseBodyResultOpenHonors setHonorDesc(String honorDesc) {
            this.honorDesc = honorDesc;
            return this;
        }
        public String getHonorDesc() {
            return this.honorDesc;
        }

        public QueryOrgHonorsResponseBodyResultOpenHonors setHonorId(Long honorId) {
            this.honorId = honorId;
            return this;
        }
        public Long getHonorId() {
            return this.honorId;
        }

        public QueryOrgHonorsResponseBodyResultOpenHonors setHonorImgUrl(String honorImgUrl) {
            this.honorImgUrl = honorImgUrl;
            return this;
        }
        public String getHonorImgUrl() {
            return this.honorImgUrl;
        }

        public QueryOrgHonorsResponseBodyResultOpenHonors setHonorName(String honorName) {
            this.honorName = honorName;
            return this;
        }
        public String getHonorName() {
            return this.honorName;
        }

        public QueryOrgHonorsResponseBodyResultOpenHonors setHonorPendantImgUrl(String honorPendantImgUrl) {
            this.honorPendantImgUrl = honorPendantImgUrl;
            return this;
        }
        public String getHonorPendantImgUrl() {
            return this.honorPendantImgUrl;
        }

    }

    public static class QueryOrgHonorsResponseBodyResult extends TeaModel {
        /**
         * <p>下次获取数据的游标</p>
         */
        @NameInMap("nextToken")
        public String nextToken;

        @NameInMap("openHonors")
        public java.util.List<QueryOrgHonorsResponseBodyResultOpenHonors> openHonors;

        public static QueryOrgHonorsResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryOrgHonorsResponseBodyResult self = new QueryOrgHonorsResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryOrgHonorsResponseBodyResult setNextToken(String nextToken) {
            this.nextToken = nextToken;
            return this;
        }
        public String getNextToken() {
            return this.nextToken;
        }

        public QueryOrgHonorsResponseBodyResult setOpenHonors(java.util.List<QueryOrgHonorsResponseBodyResultOpenHonors> openHonors) {
            this.openHonors = openHonors;
            return this;
        }
        public java.util.List<QueryOrgHonorsResponseBodyResultOpenHonors> getOpenHonors() {
            return this.openHonors;
        }

    }

}
