// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryHospitalRolesResponseBody extends TeaModel {
    // 角色列表
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
        // 主键
        @NameInMap("id")
        public Long id;

        // 修改时间
        @NameInMap("gmtCreate")
        public String gmtCreate;

        // 是否已删除，默认0未删除，1已删除
        @NameInMap("isDeleted")
        public Long isDeleted;

        // 角色编码
        @NameInMap("roleCode")
        public String roleCode;

        // 角色名称
        @NameInMap("roleName")
        public String roleName;

        // 备注
        @NameInMap("remark")
        public String remark;

        // 排序，数字越小越靠前，默认0
        @NameInMap("sort")
        public Long sort;

        // 角色关联权限点是否只读
        @NameInMap("readOnly")
        public Long readOnly;

        public static QueryHospitalRolesResponseBodyContent build(java.util.Map<String, ?> map) throws Exception {
            QueryHospitalRolesResponseBodyContent self = new QueryHospitalRolesResponseBodyContent();
            return TeaModel.build(map, self);
        }

        public QueryHospitalRolesResponseBodyContent setId(Long id) {
            this.id = id;
            return this;
        }
        public Long getId() {
            return this.id;
        }

        public QueryHospitalRolesResponseBodyContent setGmtCreate(String gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public String getGmtCreate() {
            return this.gmtCreate;
        }

        public QueryHospitalRolesResponseBodyContent setIsDeleted(Long isDeleted) {
            this.isDeleted = isDeleted;
            return this;
        }
        public Long getIsDeleted() {
            return this.isDeleted;
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

        public QueryHospitalRolesResponseBodyContent setRemark(String remark) {
            this.remark = remark;
            return this;
        }
        public String getRemark() {
            return this.remark;
        }

        public QueryHospitalRolesResponseBodyContent setSort(Long sort) {
            this.sort = sort;
            return this;
        }
        public Long getSort() {
            return this.sort;
        }

        public QueryHospitalRolesResponseBodyContent setReadOnly(Long readOnly) {
            this.readOnly = readOnly;
            return this;
        }
        public Long getReadOnly() {
            return this.readOnly;
        }

    }

}
