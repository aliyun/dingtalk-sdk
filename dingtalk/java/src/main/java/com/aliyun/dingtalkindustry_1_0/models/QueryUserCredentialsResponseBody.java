// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryUserCredentialsResponseBody extends TeaModel {
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
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>医生资格证书</p>
         */
        @NameInMap("credentialName")
        public String credentialName;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("credentialType")
        public Integer credentialType;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>2022-08-01</p>
         */
        @NameInMap("termOfValidity")
        public String termOfValidity;

        public static QueryUserCredentialsResponseBodyContentCredentialList build(java.util.Map<String, ?> map) throws Exception {
            QueryUserCredentialsResponseBodyContentCredentialList self = new QueryUserCredentialsResponseBodyContentCredentialList();
            return TeaModel.build(map, self);
        }

        public QueryUserCredentialsResponseBodyContentCredentialList setCredentialName(String credentialName) {
            this.credentialName = credentialName;
            return this;
        }
        public String getCredentialName() {
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
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("credentialList")
        public java.util.List<QueryUserCredentialsResponseBodyContentCredentialList> credentialList;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>1234</p>
         */
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
