// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetSignedDetailByPageResponseBody extends TeaModel {
    /**
     * <p>员工信息</p>
     */
    @NameInMap("auditSignedDetailDTOList")
    public java.util.List<GetSignedDetailByPageResponseBodyAuditSignedDetailDTOList> auditSignedDetailDTOList;

    /**
     * <p>当前页</p>
     */
    @NameInMap("currentPage")
    public Long currentPage;

    /**
     * <p>一页数据量</p>
     */
    @NameInMap("pageSize")
    public Long pageSize;

    /**
     * <p>总数据量</p>
     */
    @NameInMap("total")
    public Long total;

    public static GetSignedDetailByPageResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetSignedDetailByPageResponseBody self = new GetSignedDetailByPageResponseBody();
        return TeaModel.build(map, self);
    }

    public GetSignedDetailByPageResponseBody setAuditSignedDetailDTOList(java.util.List<GetSignedDetailByPageResponseBodyAuditSignedDetailDTOList> auditSignedDetailDTOList) {
        this.auditSignedDetailDTOList = auditSignedDetailDTOList;
        return this;
    }
    public java.util.List<GetSignedDetailByPageResponseBodyAuditSignedDetailDTOList> getAuditSignedDetailDTOList() {
        return this.auditSignedDetailDTOList;
    }

    public GetSignedDetailByPageResponseBody setCurrentPage(Long currentPage) {
        this.currentPage = currentPage;
        return this;
    }
    public Long getCurrentPage() {
        return this.currentPage;
    }

    public GetSignedDetailByPageResponseBody setPageSize(Long pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Long getPageSize() {
        return this.pageSize;
    }

    public GetSignedDetailByPageResponseBody setTotal(Long total) {
        this.total = total;
        return this;
    }
    public Long getTotal() {
        return this.total;
    }

    public static class GetSignedDetailByPageResponseBodyAuditSignedDetailDTOList extends TeaModel {
        /**
         * <p>部门名称</p>
         */
        @NameInMap("deptName")
        public String deptName;

        /**
         * <p>邮件</p>
         */
        @NameInMap("email")
        public String email;

        /**
         * <p>员工名称</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>手机号</p>
         */
        @NameInMap("phone")
        public String phone;

        /**
         * <p>角色</p>
         */
        @NameInMap("roles")
        public String roles;

        /**
         * <p>工号</p>
         */
        @NameInMap("staffId")
        public String staffId;

        /**
         * <p>职位</p>
         */
        @NameInMap("title")
        public String title;

        public static GetSignedDetailByPageResponseBodyAuditSignedDetailDTOList build(java.util.Map<String, ?> map) throws Exception {
            GetSignedDetailByPageResponseBodyAuditSignedDetailDTOList self = new GetSignedDetailByPageResponseBodyAuditSignedDetailDTOList();
            return TeaModel.build(map, self);
        }

        public GetSignedDetailByPageResponseBodyAuditSignedDetailDTOList setDeptName(String deptName) {
            this.deptName = deptName;
            return this;
        }
        public String getDeptName() {
            return this.deptName;
        }

        public GetSignedDetailByPageResponseBodyAuditSignedDetailDTOList setEmail(String email) {
            this.email = email;
            return this;
        }
        public String getEmail() {
            return this.email;
        }

        public GetSignedDetailByPageResponseBodyAuditSignedDetailDTOList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetSignedDetailByPageResponseBodyAuditSignedDetailDTOList setPhone(String phone) {
            this.phone = phone;
            return this;
        }
        public String getPhone() {
            return this.phone;
        }

        public GetSignedDetailByPageResponseBodyAuditSignedDetailDTOList setRoles(String roles) {
            this.roles = roles;
            return this;
        }
        public String getRoles() {
            return this.roles;
        }

        public GetSignedDetailByPageResponseBodyAuditSignedDetailDTOList setStaffId(String staffId) {
            this.staffId = staffId;
            return this;
        }
        public String getStaffId() {
            return this.staffId;
        }

        public GetSignedDetailByPageResponseBodyAuditSignedDetailDTOList setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

}
