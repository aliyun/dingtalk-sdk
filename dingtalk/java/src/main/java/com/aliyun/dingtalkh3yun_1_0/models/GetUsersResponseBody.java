// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh3yun_1_0.models;

import com.aliyun.tea.*;

public class GetUsersResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>success</p>
     */
    @NameInMap("code")
    public String code;

    @NameInMap("data")
    public java.util.List<GetUsersResponseBodyData> data;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>OK</p>
     */
    @NameInMap("message")
    public String message;

    public static GetUsersResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetUsersResponseBody self = new GetUsersResponseBody();
        return TeaModel.build(map, self);
    }

    public GetUsersResponseBody setCode(String code) {
        this.code = code;
        return this;
    }
    public String getCode() {
        return this.code;
    }

    public GetUsersResponseBody setData(java.util.List<GetUsersResponseBodyData> data) {
        this.data = data;
        return this;
    }
    public java.util.List<GetUsersResponseBodyData> getData() {
        return this.data;
    }

    public GetUsersResponseBody setMessage(String message) {
        this.message = message;
        return this;
    }
    public String getMessage() {
        return this.message;
    }

    public static class GetUsersResponseBodyData extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>zhangsan</p>
         */
        @NameInMap("code")
        public String code;

        /**
         * <strong>example:</strong>
         * <p>18f923a7-5a5e-426d-94ae-a55ad1a4b240</p>
         */
        @NameInMap("departmentId")
        public String departmentId;

        /**
         * <strong>example:</strong>
         * <p>研发中心</p>
         */
        @NameInMap("departmentName")
        public String departmentName;

        /**
         * <strong>example:</strong>
         * <p>Null</p>
         */
        @NameInMap("description")
        public String description;

        /**
         * <strong>example:</strong>
         * <p>Internal</p>
         */
        @NameInMap("domainType")
        public String domainType;

        /**
         * <strong>example:</strong>
         * <p><a href="mailto:zhangsan@example.com">zhangsan@example.com</a></p>
         */
        @NameInMap("email")
        public String email;

        /**
         * <strong>example:</strong>
         * <p>018bbb56-a9dd-49a1-8495-129c6b0d95c5</p>
         */
        @NameInMap("id")
        public String id;

        /**
         * <strong>example:</strong>
         * <p>156********</p>
         */
        @NameInMap("mobile")
        public String mobile;

        /**
         * <strong>example:</strong>
         * <p>张三</p>
         */
        @NameInMap("name")
        public String name;

        @NameInMap("partDepartmentIds")
        public java.util.List<String> partDepartmentIds;

        /**
         * <strong>example:</strong>
         * <p>Man</p>
         */
        @NameInMap("sex")
        public String sex;

        /**
         * <strong>example:</strong>
         * <p>176294501822126512</p>
         */
        @NameInMap("sortKey")
        public Long sortKey;

        public static GetUsersResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            GetUsersResponseBodyData self = new GetUsersResponseBodyData();
            return TeaModel.build(map, self);
        }

        public GetUsersResponseBodyData setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public GetUsersResponseBodyData setDepartmentId(String departmentId) {
            this.departmentId = departmentId;
            return this;
        }
        public String getDepartmentId() {
            return this.departmentId;
        }

        public GetUsersResponseBodyData setDepartmentName(String departmentName) {
            this.departmentName = departmentName;
            return this;
        }
        public String getDepartmentName() {
            return this.departmentName;
        }

        public GetUsersResponseBodyData setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public GetUsersResponseBodyData setDomainType(String domainType) {
            this.domainType = domainType;
            return this;
        }
        public String getDomainType() {
            return this.domainType;
        }

        public GetUsersResponseBodyData setEmail(String email) {
            this.email = email;
            return this;
        }
        public String getEmail() {
            return this.email;
        }

        public GetUsersResponseBodyData setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public GetUsersResponseBodyData setMobile(String mobile) {
            this.mobile = mobile;
            return this;
        }
        public String getMobile() {
            return this.mobile;
        }

        public GetUsersResponseBodyData setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetUsersResponseBodyData setPartDepartmentIds(java.util.List<String> partDepartmentIds) {
            this.partDepartmentIds = partDepartmentIds;
            return this;
        }
        public java.util.List<String> getPartDepartmentIds() {
            return this.partDepartmentIds;
        }

        public GetUsersResponseBodyData setSex(String sex) {
            this.sex = sex;
            return this;
        }
        public String getSex() {
            return this.sex;
        }

        public GetUsersResponseBodyData setSortKey(Long sortKey) {
            this.sortKey = sortKey;
            return this;
        }
        public Long getSortKey() {
            return this.sortKey;
        }

    }

}
