// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh3yun_1_0.models;

import com.aliyun.tea.*;

public class GetOrganizationsResponseBody extends TeaModel {
    /**
     * <p>状态码。success=成功</p>
     */
    @NameInMap("code")
    public String code;

    /**
     * <p>返回结果</p>
     */
    @NameInMap("data")
    public java.util.List<GetOrganizationsResponseBodyData> data;

    /**
     * <p>提示信息</p>
     */
    @NameInMap("message")
    public String message;

    public static GetOrganizationsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetOrganizationsResponseBody self = new GetOrganizationsResponseBody();
        return TeaModel.build(map, self);
    }

    public GetOrganizationsResponseBody setCode(String code) {
        this.code = code;
        return this;
    }
    public String getCode() {
        return this.code;
    }

    public GetOrganizationsResponseBody setData(java.util.List<GetOrganizationsResponseBodyData> data) {
        this.data = data;
        return this;
    }
    public java.util.List<GetOrganizationsResponseBodyData> getData() {
        return this.data;
    }

    public GetOrganizationsResponseBody setMessage(String message) {
        this.message = message;
        return this;
    }
    public String getMessage() {
        return this.message;
    }

    public static class GetOrganizationsResponseBodyData extends TeaModel {
        /**
         * <p>部门编码</p>
         */
        @NameInMap("code")
        public String code;

        /**
         * <p>描述</p>
         */
        @NameInMap("description")
        public String description;

        /**
         * <p>部门id</p>
         */
        @NameInMap("id")
        public String id;

        /**
         * <p>部门名称</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>父级部门id</p>
         */
        @NameInMap("parentId")
        public String parentId;

        /**
         * <p>排序值</p>
         */
        @NameInMap("sortKey")
        public Long sortKey;

        /**
         * <p>组织类型。Company=公司，OrganizationUnit=组织单元</p>
         */
        @NameInMap("unitType")
        public String unitType;

        public static GetOrganizationsResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            GetOrganizationsResponseBodyData self = new GetOrganizationsResponseBodyData();
            return TeaModel.build(map, self);
        }

        public GetOrganizationsResponseBodyData setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public GetOrganizationsResponseBodyData setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public GetOrganizationsResponseBodyData setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public GetOrganizationsResponseBodyData setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetOrganizationsResponseBodyData setParentId(String parentId) {
            this.parentId = parentId;
            return this;
        }
        public String getParentId() {
            return this.parentId;
        }

        public GetOrganizationsResponseBodyData setSortKey(Long sortKey) {
            this.sortKey = sortKey;
            return this;
        }
        public Long getSortKey() {
            return this.sortKey;
        }

        public GetOrganizationsResponseBodyData setUnitType(String unitType) {
            this.unitType = unitType;
            return this;
        }
        public String getUnitType() {
            return this.unitType;
        }

    }

}
