// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryHospitalRolesResponseBody extends TeaModel {
    @NameInMap("content")
    public java.util.List<QueryHospitalRolesResponseBodyContent> content;

    public static QueryHospitalRolesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryHospitalRolesResponseBody self = new QueryHospitalRolesResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryHospitalRolesResponseBody setContent(java.util.List<QueryHospitalRolesResponseBodyContent> content) {
        this.content = content;
        return this;
    }
    public java.util.List<QueryHospitalRolesResponseBodyContent> getContent() {
        return this.content;
    }

    public static class QueryHospitalRolesResponseBodyContent extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("gmtCreate")
        public String gmtCreate;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("id")
        public Long id;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>0</p>
         */
        @NameInMap("isDeleted")
        public Long isDeleted;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>0</p>
         */
        @NameInMap("readOnly")
        public Long readOnly;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("remark")
        public String remark;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>sys_admin</p>
         */
        @NameInMap("roleCode")
        public String roleCode;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>系统管理员</p>
         */
        @NameInMap("roleName")
        public String roleName;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>0</p>
         */
        @NameInMap("sort")
        public Long sort;

        public static QueryHospitalRolesResponseBodyContent build(java.util.Map<String, ?> map) throws Exception {
            QueryHospitalRolesResponseBodyContent self = new QueryHospitalRolesResponseBodyContent();
            return TeaModel.build(map, self);
        }

        public QueryHospitalRolesResponseBodyContent setGmtCreate(String gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public String getGmtCreate() {
            return this.gmtCreate;
        }

        public QueryHospitalRolesResponseBodyContent setId(Long id) {
            this.id = id;
            return this;
        }
        public Long getId() {
            return this.id;
        }

        public QueryHospitalRolesResponseBodyContent setIsDeleted(Long isDeleted) {
            this.isDeleted = isDeleted;
            return this;
        }
        public Long getIsDeleted() {
            return this.isDeleted;
        }

        public QueryHospitalRolesResponseBodyContent setReadOnly(Long readOnly) {
            this.readOnly = readOnly;
            return this;
        }
        public Long getReadOnly() {
            return this.readOnly;
        }

        public QueryHospitalRolesResponseBodyContent setRemark(String remark) {
            this.remark = remark;
            return this;
        }
        public String getRemark() {
            return this.remark;
        }

        public QueryHospitalRolesResponseBodyContent setRoleCode(String roleCode) {
            this.roleCode = roleCode;
            return this;
        }
        public String getRoleCode() {
            return this.roleCode;
        }

        public QueryHospitalRolesResponseBodyContent setRoleName(String roleName) {
            this.roleName = roleName;
            return this;
        }
        public String getRoleName() {
            return this.roleName;
        }

        public QueryHospitalRolesResponseBodyContent setSort(Long sort) {
            this.sort = sort;
            return this;
        }
        public Long getSort() {
            return this.sort;
        }

    }

}
