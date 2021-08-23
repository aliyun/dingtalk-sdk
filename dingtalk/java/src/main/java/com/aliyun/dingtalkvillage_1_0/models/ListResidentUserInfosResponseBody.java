// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvillage_1_0.models;

import com.aliyun.tea.*;

public class ListResidentUserInfosResponseBody extends TeaModel {
    // result
    @NameInMap("result")
    public java.util.List<ListResidentUserInfosResponseBodyResult> result;

    public static ListResidentUserInfosResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListResidentUserInfosResponseBody self = new ListResidentUserInfosResponseBody();
        return TeaModel.build(map, self);
    }

    public ListResidentUserInfosResponseBody setResult(java.util.List<ListResidentUserInfosResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<ListResidentUserInfosResponseBodyResult> getResult() {
        return this.result;
    }

    public static class ListResidentUserInfosResponseBodyResultRoles extends TeaModel {
        // 标签id
        @NameInMap("id")
        public Long id;

        // 标签名称
        @NameInMap("name")
        public String name;

        // 标签名称 tagCode
        @NameInMap("tagCode")
        public String tagCode;

        public static ListResidentUserInfosResponseBodyResultRoles build(java.util.Map<String, ?> map) throws Exception {
            ListResidentUserInfosResponseBodyResultRoles self = new ListResidentUserInfosResponseBodyResultRoles();
            return TeaModel.build(map, self);
        }

        public ListResidentUserInfosResponseBodyResultRoles setId(Long id) {
            this.id = id;
            return this;
        }
        public Long getId() {
            return this.id;
        }

        public ListResidentUserInfosResponseBodyResultRoles setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ListResidentUserInfosResponseBodyResultRoles setTagCode(String tagCode) {
            this.tagCode = tagCode;
            return this;
        }
        public String getTagCode() {
            return this.tagCode;
        }

    }

    public static class ListResidentUserInfosResponseBodyResult extends TeaModel {
        // 员工id
        @NameInMap("userid")
        public String userid;

        // 员工名字
        @NameInMap("name")
        public String name;

        // 标签列表
        @NameInMap("roles")
        public java.util.List<ListResidentUserInfosResponseBodyResultRoles> roles;

        // 员工特征
        @NameInMap("feature")
        public String feature;

        // 钉钉唯一标识
        @NameInMap("unionId")
        public String unionId;

        public static ListResidentUserInfosResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            ListResidentUserInfosResponseBodyResult self = new ListResidentUserInfosResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public ListResidentUserInfosResponseBodyResult setUserid(String userid) {
            this.userid = userid;
            return this;
        }
        public String getUserid() {
            return this.userid;
        }

        public ListResidentUserInfosResponseBodyResult setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ListResidentUserInfosResponseBodyResult setRoles(java.util.List<ListResidentUserInfosResponseBodyResultRoles> roles) {
            this.roles = roles;
            return this;
        }
        public java.util.List<ListResidentUserInfosResponseBodyResultRoles> getRoles() {
            return this.roles;
        }

        public ListResidentUserInfosResponseBodyResult setFeature(String feature) {
            this.feature = feature;
            return this;
        }
        public String getFeature() {
            return this.feature;
        }

        public ListResidentUserInfosResponseBodyResult setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

    }

}
