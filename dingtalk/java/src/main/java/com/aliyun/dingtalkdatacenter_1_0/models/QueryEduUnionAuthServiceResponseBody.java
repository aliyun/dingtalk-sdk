// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryEduUnionAuthServiceResponseBody extends TeaModel {
    @NameInMap("authInfoModels")
    public java.util.List<QueryEduUnionAuthServiceResponseBodyAuthInfoModels> authInfoModels;

    public static QueryEduUnionAuthServiceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryEduUnionAuthServiceResponseBody self = new QueryEduUnionAuthServiceResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryEduUnionAuthServiceResponseBody setAuthInfoModels(java.util.List<QueryEduUnionAuthServiceResponseBodyAuthInfoModels> authInfoModels) {
        this.authInfoModels = authInfoModels;
        return this;
    }
    public java.util.List<QueryEduUnionAuthServiceResponseBodyAuthInfoModels> getAuthInfoModels() {
        return this.authInfoModels;
    }

    public static class QueryEduUnionAuthServiceResponseBodyAuthInfoModels extends TeaModel {
        @NameInMap("authCorpId")
        public String authCorpId;

        @NameInMap("authCorpName")
        public String authCorpName;

        @NameInMap("authTime")
        public String authTime;

        @NameInMap("resourceNames")
        public java.util.List<String> resourceNames;

        public static QueryEduUnionAuthServiceResponseBodyAuthInfoModels build(java.util.Map<String, ?> map) throws Exception {
            QueryEduUnionAuthServiceResponseBodyAuthInfoModels self = new QueryEduUnionAuthServiceResponseBodyAuthInfoModels();
            return TeaModel.build(map, self);
        }

        public QueryEduUnionAuthServiceResponseBodyAuthInfoModels setAuthCorpId(String authCorpId) {
            this.authCorpId = authCorpId;
            return this;
        }
        public String getAuthCorpId() {
            return this.authCorpId;
        }

        public QueryEduUnionAuthServiceResponseBodyAuthInfoModels setAuthCorpName(String authCorpName) {
            this.authCorpName = authCorpName;
            return this;
        }
        public String getAuthCorpName() {
            return this.authCorpName;
        }

        public QueryEduUnionAuthServiceResponseBodyAuthInfoModels setAuthTime(String authTime) {
            this.authTime = authTime;
            return this;
        }
        public String getAuthTime() {
            return this.authTime;
        }

        public QueryEduUnionAuthServiceResponseBodyAuthInfoModels setResourceNames(java.util.List<String> resourceNames) {
            this.resourceNames = resourceNames;
            return this;
        }
        public java.util.List<String> getResourceNames() {
            return this.resourceNames;
        }

    }

}
