// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryUserExtInfoResponseBody extends TeaModel {
    // 扩展属性
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
        // 创建时间
        @NameInMap("gmtCreate")
        public String gmtCreate;

        // 修改时间
        @NameInMap("gmtModified")
        public String gmtModified;

        // 组织id
        @NameInMap("orgId")
        public String orgId;

        // 状态：0-有效，1-无效
        @NameInMap("status")
        public Integer status;

        // 用户标识
        @NameInMap("userCode")
        public String userCode;

        // 扩展属性描述
        @NameInMap("userExtendDisplayName")
        public String userExtendDisplayName;

        // 扩展属性Key
        @NameInMap("userExtendKey")
        public String userExtendKey;

        // 扩展属性值
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

        public QueryUserExtInfoResponseBodyContent setOrgId(String orgId) {
            this.orgId = orgId;
            return this;
        }
        public String getOrgId() {
            return this.orgId;
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
