// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryHospitalRoleUserInfoResponseBody extends TeaModel {
    @NameInMap("content")
    public java.util.List<QueryHospitalRoleUserInfoResponseBodyContent> content;

    @NameInMap("currentPage")
    public Integer currentPage;

    @NameInMap("totalCount")
    public Long totalCount;

    @NameInMap("totalPages")
    public Integer totalPages;

    public static QueryHospitalRoleUserInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryHospitalRoleUserInfoResponseBody self = new QueryHospitalRoleUserInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryHospitalRoleUserInfoResponseBody setContent(java.util.List<QueryHospitalRoleUserInfoResponseBodyContent> content) {
        this.content = content;
        return this;
    }
    public java.util.List<QueryHospitalRoleUserInfoResponseBodyContent> getContent() {
        return this.content;
    }

    public QueryHospitalRoleUserInfoResponseBody setCurrentPage(Integer currentPage) {
        this.currentPage = currentPage;
        return this;
    }
    public Integer getCurrentPage() {
        return this.currentPage;
    }

    public QueryHospitalRoleUserInfoResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public QueryHospitalRoleUserInfoResponseBody setTotalPages(Integer totalPages) {
        this.totalPages = totalPages;
        return this;
    }
    public Integer getTotalPages() {
        return this.totalPages;
    }

    public static class QueryHospitalRoleUserInfoResponseBodyContent extends TeaModel {
        @NameInMap("gmtCreate")
        public String gmtCreate;

        @NameInMap("gmtModified")
        public String gmtModified;

        @NameInMap("jobNumber")
        public String jobNumber;

        @NameInMap("roleCode")
        public String roleCode;

        @NameInMap("roleName")
        public String roleName;

        @NameInMap("status")
        public Integer status;

        @NameInMap("userCode")
        public String userCode;

        @NameInMap("userName")
        public String userName;

        public static QueryHospitalRoleUserInfoResponseBodyContent build(java.util.Map<String, ?> map) throws Exception {
            QueryHospitalRoleUserInfoResponseBodyContent self = new QueryHospitalRoleUserInfoResponseBodyContent();
            return TeaModel.build(map, self);
        }

        public QueryHospitalRoleUserInfoResponseBodyContent setGmtCreate(String gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public String getGmtCreate() {
            return this.gmtCreate;
        }

        public QueryHospitalRoleUserInfoResponseBodyContent setGmtModified(String gmtModified) {
            this.gmtModified = gmtModified;
            return this;
        }
        public String getGmtModified() {
            return this.gmtModified;
        }

        public QueryHospitalRoleUserInfoResponseBodyContent setJobNumber(String jobNumber) {
            this.jobNumber = jobNumber;
            return this;
        }
        public String getJobNumber() {
            return this.jobNumber;
        }

        public QueryHospitalRoleUserInfoResponseBodyContent setRoleCode(String roleCode) {
            this.roleCode = roleCode;
            return this;
        }
        public String getRoleCode() {
            return this.roleCode;
        }

        public QueryHospitalRoleUserInfoResponseBodyContent setRoleName(String roleName) {
            this.roleName = roleName;
            return this;
        }
        public String getRoleName() {
            return this.roleName;
        }

        public QueryHospitalRoleUserInfoResponseBodyContent setStatus(Integer status) {
            this.status = status;
            return this;
        }
        public Integer getStatus() {
            return this.status;
        }

        public QueryHospitalRoleUserInfoResponseBodyContent setUserCode(String userCode) {
            this.userCode = userCode;
            return this;
        }
        public String getUserCode() {
            return this.userCode;
        }

        public QueryHospitalRoleUserInfoResponseBodyContent setUserName(String userName) {
            this.userName = userName;
            return this;
        }
        public String getUserName() {
            return this.userName;
        }

    }

}
