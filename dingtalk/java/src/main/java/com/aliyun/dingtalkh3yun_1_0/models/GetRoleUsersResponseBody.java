// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh3yun_1_0.models;

import com.aliyun.tea.*;

public class GetRoleUsersResponseBody extends TeaModel {
    // 状态码
    @NameInMap("code")
    public String code;

    // 返回结果
    @NameInMap("data")
    public java.util.List<GetRoleUsersResponseBodyData> data;

    // 提示信息
    @NameInMap("message")
    public String message;

    public static GetRoleUsersResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetRoleUsersResponseBody self = new GetRoleUsersResponseBody();
        return TeaModel.build(map, self);
    }

    public GetRoleUsersResponseBody setCode(String code) {
        this.code = code;
        return this;
    }
    public String getCode() {
        return this.code;
    }

    public GetRoleUsersResponseBody setData(java.util.List<GetRoleUsersResponseBodyData> data) {
        this.data = data;
        return this;
    }
    public java.util.List<GetRoleUsersResponseBodyData> getData() {
        return this.data;
    }

    public GetRoleUsersResponseBody setMessage(String message) {
        this.message = message;
        return this;
    }
    public String getMessage() {
        return this.message;
    }

    public static class GetRoleUsersResponseBodyData extends TeaModel {
        // 用户编码
        @NameInMap("code")
        public String code;

        // 所属部门id
        @NameInMap("departmentId")
        public String departmentId;

        // 所属部门名称
        @NameInMap("departmentName")
        public String departmentName;

        // 描述
        @NameInMap("description")
        public String description;

        // 所属范围。Internal=内部，External=外部
        @NameInMap("domainType")
        public String domainType;

        // 邮箱
        @NameInMap("email")
        public String email;

        // 手机号码
        @NameInMap("mobile")
        public String mobile;

        // 用户名称
        @NameInMap("name")
        public String name;

        // 兼职部门id集合（含主部门id）
        @NameInMap("partDepartmentIds")
        public java.util.List<String> partDepartmentIds;

        // 性别.None=未指定，Man=男性，Female=女性
        @NameInMap("sex")
        public String sex;

        // 排序值
        @NameInMap("sortKey")
        public Long sortKey;

        // 用户id
        @NameInMap("userId")
        public String userId;

        public static GetRoleUsersResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            GetRoleUsersResponseBodyData self = new GetRoleUsersResponseBodyData();
            return TeaModel.build(map, self);
        }

        public GetRoleUsersResponseBodyData setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public GetRoleUsersResponseBodyData setDepartmentId(String departmentId) {
            this.departmentId = departmentId;
            return this;
        }
        public String getDepartmentId() {
            return this.departmentId;
        }

        public GetRoleUsersResponseBodyData setDepartmentName(String departmentName) {
            this.departmentName = departmentName;
            return this;
        }
        public String getDepartmentName() {
            return this.departmentName;
        }

        public GetRoleUsersResponseBodyData setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public GetRoleUsersResponseBodyData setDomainType(String domainType) {
            this.domainType = domainType;
            return this;
        }
        public String getDomainType() {
            return this.domainType;
        }

        public GetRoleUsersResponseBodyData setEmail(String email) {
            this.email = email;
            return this;
        }
        public String getEmail() {
            return this.email;
        }

        public GetRoleUsersResponseBodyData setMobile(String mobile) {
            this.mobile = mobile;
            return this;
        }
        public String getMobile() {
            return this.mobile;
        }

        public GetRoleUsersResponseBodyData setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetRoleUsersResponseBodyData setPartDepartmentIds(java.util.List<String> partDepartmentIds) {
            this.partDepartmentIds = partDepartmentIds;
            return this;
        }
        public java.util.List<String> getPartDepartmentIds() {
            return this.partDepartmentIds;
        }

        public GetRoleUsersResponseBodyData setSex(String sex) {
            this.sex = sex;
            return this;
        }
        public String getSex() {
            return this.sex;
        }

        public GetRoleUsersResponseBodyData setSortKey(Long sortKey) {
            this.sortKey = sortKey;
            return this;
        }
        public Long getSortKey() {
            return this.sortKey;
        }

        public GetRoleUsersResponseBodyData setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
