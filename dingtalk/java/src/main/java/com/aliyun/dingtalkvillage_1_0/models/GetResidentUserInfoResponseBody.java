// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvillage_1_0.models;

import com.aliyun.tea.*;

public class GetResidentUserInfoResponseBody extends TeaModel {
    /**
     * <p>员工特征</p>
     */
    @NameInMap("feature")
    public String feature;

    /**
     * <p>员工名字</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <p>标签列表</p>
     */
    @NameInMap("roles")
    public java.util.List<GetResidentUserInfoResponseBodyRoles> roles;

    /**
     * <p>钉钉唯一标识</p>
     */
    @NameInMap("unionId")
    public String unionId;

    /**
     * <p>员工id</p>
     */
    @NameInMap("userid")
    public String userid;

    public static GetResidentUserInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetResidentUserInfoResponseBody self = new GetResidentUserInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public GetResidentUserInfoResponseBody setFeature(String feature) {
        this.feature = feature;
        return this;
    }
    public String getFeature() {
        return this.feature;
    }

    public GetResidentUserInfoResponseBody setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public GetResidentUserInfoResponseBody setRoles(java.util.List<GetResidentUserInfoResponseBodyRoles> roles) {
        this.roles = roles;
        return this;
    }
    public java.util.List<GetResidentUserInfoResponseBodyRoles> getRoles() {
        return this.roles;
    }

    public GetResidentUserInfoResponseBody setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

    public GetResidentUserInfoResponseBody setUserid(String userid) {
        this.userid = userid;
        return this;
    }
    public String getUserid() {
        return this.userid;
    }

    public static class GetResidentUserInfoResponseBodyRoles extends TeaModel {
        /**
         * <p>标签id</p>
         */
        @NameInMap("roleId")
        public Long roleId;

        /**
         * <p>标签名称</p>
         */
        @NameInMap("roleName")
        public String roleName;

        /**
         * <p>标签名称 tagCode</p>
         */
        @NameInMap("tagCode")
        public String tagCode;

        public static GetResidentUserInfoResponseBodyRoles build(java.util.Map<String, ?> map) throws Exception {
            GetResidentUserInfoResponseBodyRoles self = new GetResidentUserInfoResponseBodyRoles();
            return TeaModel.build(map, self);
        }

        public GetResidentUserInfoResponseBodyRoles setRoleId(Long roleId) {
            this.roleId = roleId;
            return this;
        }
        public Long getRoleId() {
            return this.roleId;
        }

        public GetResidentUserInfoResponseBodyRoles setRoleName(String roleName) {
            this.roleName = roleName;
            return this;
        }
        public String getRoleName() {
            return this.roleName;
        }

        public GetResidentUserInfoResponseBodyRoles setTagCode(String tagCode) {
            this.tagCode = tagCode;
            return this;
        }
        public String getTagCode() {
            return this.tagCode;
        }

    }

}
