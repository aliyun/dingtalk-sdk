// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class ListUserIndustryRolesResponseBody extends TeaModel {
    /**
     * <p>result</p>
     */
    @NameInMap("roleList")
    public java.util.List<ListUserIndustryRolesResponseBodyRoleList> roleList;

    public static ListUserIndustryRolesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListUserIndustryRolesResponseBody self = new ListUserIndustryRolesResponseBody();
        return TeaModel.build(map, self);
    }

    public ListUserIndustryRolesResponseBody setRoleList(java.util.List<ListUserIndustryRolesResponseBodyRoleList> roleList) {
        this.roleList = roleList;
        return this;
    }
    public java.util.List<ListUserIndustryRolesResponseBodyRoleList> getRoleList() {
        return this.roleList;
    }

    public static class ListUserIndustryRolesResponseBodyRoleList extends TeaModel {
        /**
         * <p>角色id</p>
         */
        @NameInMap("roleId")
        public Long roleId;

        /**
         * <p>角色名字</p>
         */
        @NameInMap("roleName")
        public String roleName;

        /**
         * <p>行业角色编码</p>
         */
        @NameInMap("tagCode")
        public String tagCode;

        public static ListUserIndustryRolesResponseBodyRoleList build(java.util.Map<String, ?> map) throws Exception {
            ListUserIndustryRolesResponseBodyRoleList self = new ListUserIndustryRolesResponseBodyRoleList();
            return TeaModel.build(map, self);
        }

        public ListUserIndustryRolesResponseBodyRoleList setRoleId(Long roleId) {
            this.roleId = roleId;
            return this;
        }
        public Long getRoleId() {
            return this.roleId;
        }

        public ListUserIndustryRolesResponseBodyRoleList setRoleName(String roleName) {
            this.roleName = roleName;
            return this;
        }
        public String getRoleName() {
            return this.roleName;
        }

        public ListUserIndustryRolesResponseBodyRoleList setTagCode(String tagCode) {
            this.tagCode = tagCode;
            return this;
        }
        public String getTagCode() {
            return this.tagCode;
        }

    }

}
