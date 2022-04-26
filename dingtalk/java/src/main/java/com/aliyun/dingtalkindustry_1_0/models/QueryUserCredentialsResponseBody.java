// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryUserCredentialsResponseBody extends TeaModel {
    // 人员证书
    @NameInMap("content")
    public java.util.List<QueryUserCredentialsResponseBodyContent> content;

    public static QueryUserCredentialsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryUserCredentialsResponseBody self = new QueryUserCredentialsResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryUserCredentialsResponseBody setContent(java.util.List<QueryUserCredentialsResponseBodyContent> content) {
        this.content = content;
        return this;
    }
    public java.util.List<QueryUserCredentialsResponseBodyContent> getContent() {
        return this.content;
    }

    public static class QueryUserCredentialsResponseBodyContentCredentialList extends TeaModel {
        // 证书名称
        @NameInMap("credentialName")
        public Integer credentialName;

        // 证书类型
        @NameInMap("credentialType")
        public Integer credentialType;

        // 有效日期
        @NameInMap("termOfValidity")
        public String termOfValidity;

        public static QueryUserCredentialsResponseBodyContentCredentialList build(java.util.Map<String, ?> map) throws Exception {
            QueryUserCredentialsResponseBodyContentCredentialList self = new QueryUserCredentialsResponseBodyContentCredentialList();
            return TeaModel.build(map, self);
        }

        public QueryUserCredentialsResponseBodyContentCredentialList setCredentialName(Integer credentialName) {
            this.credentialName = credentialName;
            return this;
        }
        public Integer getCredentialName() {
            return this.credentialName;
        }

        public QueryUserCredentialsResponseBodyContentCredentialList setCredentialType(Integer credentialType) {
            this.credentialType = credentialType;
            return this;
        }
        public Integer getCredentialType() {
            return this.credentialType;
        }

        public QueryUserCredentialsResponseBodyContentCredentialList setTermOfValidity(String termOfValidity) {
            this.termOfValidity = termOfValidity;
            return this;
        }
        public String getTermOfValidity() {
            return this.termOfValidity;
        }

    }

    public static class QueryUserCredentialsResponseBodyContent extends TeaModel {
        // 证书
        @NameInMap("credentialList")
        public java.util.List<QueryUserCredentialsResponseBodyContentCredentialList> credentialList;

        // 用户id
        @NameInMap("userId")
        public String userId;

        public static QueryUserCredentialsResponseBodyContent build(java.util.Map<String, ?> map) throws Exception {
            QueryUserCredentialsResponseBodyContent self = new QueryUserCredentialsResponseBodyContent();
            return TeaModel.build(map, self);
        }

        public QueryUserCredentialsResponseBodyContent setCredentialList(java.util.List<QueryUserCredentialsResponseBodyContentCredentialList> credentialList) {
            this.credentialList = credentialList;
            return this;
        }
        public java.util.List<QueryUserCredentialsResponseBodyContentCredentialList> getCredentialList() {
            return this.credentialList;
        }

        public QueryUserCredentialsResponseBodyContent setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
