// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryHospitalRoleUserInfoResponseBody extends TeaModel {
    // 角色人员信息
    @NameInMap("content")
    public java.util.List<QueryHospitalRoleUserInfoResponseBodyContent> content;

    // 总页数
    @NameInMap("totalPages")
    public Integer totalPages;

    // 总数量
    @NameInMap("totalCount")
    public Long totalCount;

    // 当前页码
    @NameInMap("currentPage")
    public Integer currentPage;

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

    public QueryHospitalRoleUserInfoResponseBody setTotalPages(Integer totalPages) {
        this.totalPages = totalPages;
        return this;
    }
    public Integer getTotalPages() {
        return this.totalPages;
    }

    public QueryHospitalRoleUserInfoResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public QueryHospitalRoleUserInfoResponseBody setCurrentPage(Integer currentPage) {
        this.currentPage = currentPage;
        return this;
    }
    public Integer getCurrentPage() {
        return this.currentPage;
    }

    public static class QueryHospitalRoleUserInfoResponseBodyContent extends TeaModel {
        // 用户编码
        @NameInMap("userCode")
        public String userCode;

        // 用户名称
        @NameInMap("userName")
        public String userName;

        // 用户工号
        @NameInMap("jobNumber")
        public String jobNumber;

        // 角色编码
        @NameInMap("roleCode")
        public String roleCode;

        // 角色名称
        @NameInMap("roleName")
        public String roleName;

        // gmtCreate
        @NameInMap("gmtCreate")
        public String gmtCreate;

        // 修改时间
        @NameInMap("gmtModified")
        public String gmtModified;

        public static QueryHospitalRoleUserInfoResponseBodyContent build(java.util.Map<String, ?> map) throws Exception {
            QueryHospitalRoleUserInfoResponseBodyContent self = new QueryHospitalRoleUserInfoResponseBodyContent();
            return TeaModel.build(map, self);
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

    }

}
