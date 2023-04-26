// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryDepartmentExtendInfoResponseBody extends TeaModel {
    @NameInMap("content")
    public java.util.List<QueryDepartmentExtendInfoResponseBodyContent> content;

    public static QueryDepartmentExtendInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryDepartmentExtendInfoResponseBody self = new QueryDepartmentExtendInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryDepartmentExtendInfoResponseBody setContent(java.util.List<QueryDepartmentExtendInfoResponseBodyContent> content) {
        this.content = content;
        return this;
    }
    public java.util.List<QueryDepartmentExtendInfoResponseBodyContent> getContent() {
        return this.content;
    }

    public static class QueryDepartmentExtendInfoResponseBodyContent extends TeaModel {
        @NameInMap("deptCode")
        public String deptCode;

        @NameInMap("deptExtendDisplayName")
        public String deptExtendDisplayName;

        @NameInMap("deptExtendKey")
        public String deptExtendKey;

        @NameInMap("deptExtendValue")
        public String deptExtendValue;

        @NameInMap("gmtCreateStr")
        public String gmtCreateStr;

        @NameInMap("gmtModifiedStr")
        public String gmtModifiedStr;

        @NameInMap("id")
        public Long id;

        @NameInMap("status")
        public Integer status;

        public static QueryDepartmentExtendInfoResponseBodyContent build(java.util.Map<String, ?> map) throws Exception {
            QueryDepartmentExtendInfoResponseBodyContent self = new QueryDepartmentExtendInfoResponseBodyContent();
            return TeaModel.build(map, self);
        }

        public QueryDepartmentExtendInfoResponseBodyContent setDeptCode(String deptCode) {
            this.deptCode = deptCode;
            return this;
        }
        public String getDeptCode() {
            return this.deptCode;
        }

        public QueryDepartmentExtendInfoResponseBodyContent setDeptExtendDisplayName(String deptExtendDisplayName) {
            this.deptExtendDisplayName = deptExtendDisplayName;
            return this;
        }
        public String getDeptExtendDisplayName() {
            return this.deptExtendDisplayName;
        }

        public QueryDepartmentExtendInfoResponseBodyContent setDeptExtendKey(String deptExtendKey) {
            this.deptExtendKey = deptExtendKey;
            return this;
        }
        public String getDeptExtendKey() {
            return this.deptExtendKey;
        }

        public QueryDepartmentExtendInfoResponseBodyContent setDeptExtendValue(String deptExtendValue) {
            this.deptExtendValue = deptExtendValue;
            return this;
        }
        public String getDeptExtendValue() {
            return this.deptExtendValue;
        }

        public QueryDepartmentExtendInfoResponseBodyContent setGmtCreateStr(String gmtCreateStr) {
            this.gmtCreateStr = gmtCreateStr;
            return this;
        }
        public String getGmtCreateStr() {
            return this.gmtCreateStr;
        }

        public QueryDepartmentExtendInfoResponseBodyContent setGmtModifiedStr(String gmtModifiedStr) {
            this.gmtModifiedStr = gmtModifiedStr;
            return this;
        }
        public String getGmtModifiedStr() {
            return this.gmtModifiedStr;
        }

        public QueryDepartmentExtendInfoResponseBodyContent setId(Long id) {
            this.id = id;
            return this;
        }
        public Long getId() {
            return this.id;
        }

        public QueryDepartmentExtendInfoResponseBodyContent setStatus(Integer status) {
            this.status = status;
            return this;
        }
        public Integer getStatus() {
            return this.status;
        }

    }

}
