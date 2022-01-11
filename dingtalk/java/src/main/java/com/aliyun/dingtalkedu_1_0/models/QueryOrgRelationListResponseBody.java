// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryOrgRelationListResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<QueryOrgRelationListResponseBodyResult> result;

    // Id of the request
    @NameInMap("success")
    public Boolean success;

    public static QueryOrgRelationListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryOrgRelationListResponseBody self = new QueryOrgRelationListResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryOrgRelationListResponseBody setResult(java.util.List<QueryOrgRelationListResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<QueryOrgRelationListResponseBodyResult> getResult() {
        return this.result;
    }

    public QueryOrgRelationListResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class QueryOrgRelationListResponseBodyResult extends TeaModel {
        @NameInMap("corpId")
        public String corpId;

        @NameInMap("deviceCount")
        public Integer deviceCount;

        @NameInMap("name")
        public String name;

        public static QueryOrgRelationListResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryOrgRelationListResponseBodyResult self = new QueryOrgRelationListResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryOrgRelationListResponseBodyResult setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public QueryOrgRelationListResponseBodyResult setDeviceCount(Integer deviceCount) {
            this.deviceCount = deviceCount;
            return this;
        }
        public Integer getDeviceCount() {
            return this.deviceCount;
        }

        public QueryOrgRelationListResponseBodyResult setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

}
