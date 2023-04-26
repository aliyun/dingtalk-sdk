// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryUserExtInfoResponseBody extends TeaModel {
    @NameInMap("content")
    public java.util.List<QueryUserExtInfoResponseBodyContent> content;

    public static QueryUserExtInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryUserExtInfoResponseBody self = new QueryUserExtInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryUserExtInfoResponseBody setContent(java.util.List<QueryUserExtInfoResponseBodyContent> content) {
        this.content = content;
        return this;
    }
    public java.util.List<QueryUserExtInfoResponseBodyContent> getContent() {
        return this.content;
    }

    public static class QueryUserExtInfoResponseBodyContent extends TeaModel {
        @NameInMap("gmtCreate")
        public String gmtCreate;

        @NameInMap("gmtModified")
        public String gmtModified;

        @NameInMap("status")
        public Integer status;

        @NameInMap("userCode")
        public String userCode;

        @NameInMap("userExtendDisplayName")
        public String userExtendDisplayName;

        @NameInMap("userExtendKey")
        public String userExtendKey;

        @NameInMap("userExtendValue")
        public String userExtendValue;

        public static QueryUserExtInfoResponseBodyContent build(java.util.Map<String, ?> map) throws Exception {
            QueryUserExtInfoResponseBodyContent self = new QueryUserExtInfoResponseBodyContent();
            return TeaModel.build(map, self);
        }

        public QueryUserExtInfoResponseBodyContent setGmtCreate(String gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public String getGmtCreate() {
            return this.gmtCreate;
        }

        public QueryUserExtInfoResponseBodyContent setGmtModified(String gmtModified) {
            this.gmtModified = gmtModified;
            return this;
        }
        public String getGmtModified() {
            return this.gmtModified;
        }

        public QueryUserExtInfoResponseBodyContent setStatus(Integer status) {
            this.status = status;
            return this;
        }
        public Integer getStatus() {
            return this.status;
        }

        public QueryUserExtInfoResponseBodyContent setUserCode(String userCode) {
            this.userCode = userCode;
            return this;
        }
        public String getUserCode() {
            return this.userCode;
        }

        public QueryUserExtInfoResponseBodyContent setUserExtendDisplayName(String userExtendDisplayName) {
            this.userExtendDisplayName = userExtendDisplayName;
            return this;
        }
        public String getUserExtendDisplayName() {
            return this.userExtendDisplayName;
        }

        public QueryUserExtInfoResponseBodyContent setUserExtendKey(String userExtendKey) {
            this.userExtendKey = userExtendKey;
            return this;
        }
        public String getUserExtendKey() {
            return this.userExtendKey;
        }

        public QueryUserExtInfoResponseBodyContent setUserExtendValue(String userExtendValue) {
            this.userExtendValue = userExtendValue;
            return this;
        }
        public String getUserExtendValue() {
            return this.userExtendValue;
        }

    }

}
