// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvillage_1_0.models;

import com.aliyun.tea.*;

public class GetResidentUserInfoResponseBody extends TeaModel {
    // 员工id
    @NameInMap("userid")
    public String userid;

    // 员工名字
    @NameInMap("name")
    public String name;

    // 标签列表
    @NameInMap("roles")
    public java.util.List<GetResidentUserInfoResponseBodyRoles> roles;

    // 员工特征
    @NameInMap("feature")
    public String feature;

    // 钉钉唯一标识
    @NameInMap("unionId")
    public String unionId;

    public static GetResidentUserInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetResidentUserInfoResponseBody self = new GetResidentUserInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public GetResidentUserInfoResponseBody setUserid(String userid) {
        this.userid = userid;
        return this;
    }
    public String getUserid() {
        return this.userid;
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

    public GetResidentUserInfoResponseBody setFeature(String feature) {
        this.feature = feature;
        return this;
    }
    public String getFeature() {
        return this.feature;
    }

    public GetResidentUserInfoResponseBody setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

    public static class GetResidentUserInfoResponseBodyRoles extends TeaModel {
        // 标签id
        @NameInMap("id")
        public Long id;

        // 标签名称
        @NameInMap("name")
        public String name;

        // 标签名称 tagCode
        @NameInMap("tagCode")
        public String tagCode;

        public static GetResidentUserInfoResponseBodyRoles build(java.util.Map<String, ?> map) throws Exception {
            GetResidentUserInfoResponseBodyRoles self = new GetResidentUserInfoResponseBodyRoles();
            return TeaModel.build(map, self);
        }

        public GetResidentUserInfoResponseBodyRoles setId(Long id) {
            this.id = id;
            return this;
        }
        public Long getId() {
            return this.id;
        }

        public GetResidentUserInfoResponseBodyRoles setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
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
