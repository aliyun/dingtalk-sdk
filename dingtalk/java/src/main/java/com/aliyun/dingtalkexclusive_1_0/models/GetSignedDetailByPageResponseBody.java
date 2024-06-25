// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetSignedDetailByPageResponseBody extends TeaModel {
    @NameInMap("auditSignedDetailDTOList")
    public java.util.List<GetSignedDetailByPageResponseBodyAuditSignedDetailDTOList> auditSignedDetailDTOList;

    /**
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("currentPage")
    public Long currentPage;

    /**
     * <strong>example:</strong>
     * <p>50</p>
     */
    @NameInMap("pageSize")
    public Long pageSize;

    /**
     * <strong>example:</strong>
     * <p>1000</p>
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
         * <strong>example:</strong>
         * <p>部门1</p>
         */
        @NameInMap("deptName")
        public String deptName;

        /**
         * <strong>example:</strong>
         * <p><strong>@</strong>.com</p>
         */
        @NameInMap("email")
        public String email;

        /**
         * <strong>example:</strong>
         * <p>小张</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <strong>example:</strong>
         * <hr>
         */
        @NameInMap("phone")
        public String phone;

        /**
         * <strong>example:</strong>
         * <p>主管理员</p>
         */
        @NameInMap("roles")
        public String roles;

        /**
         * <strong>example:</strong>
         * <p>123***</p>
         */
        @NameInMap("staffId")
        public String staffId;

        /**
         * <strong>example:</strong>
         * <p>经理</p>
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
