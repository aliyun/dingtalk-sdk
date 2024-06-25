// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh3yun_1_0.models;

import com.aliyun.tea.*;

public class GetOrganizationsResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>success</p>
     */
    @NameInMap("code")
    public String code;

    @NameInMap("data")
    public java.util.List<GetOrganizationsResponseBodyData> data;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>OK</p>
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
         * <strong>example:</strong>
         * <p>G06935</p>
         */
        @NameInMap("code")
        public String code;

        /**
         * <strong>example:</strong>
         * <p>null</p>
         */
        @NameInMap("description")
        public String description;

        /**
         * <strong>example:</strong>
         * <p>2b1a79e9-7545-437f-94ad-b6ab5561733f</p>
         */
        @NameInMap("id")
        public String id;

        /**
         * <strong>example:</strong>
         * <p>行政部</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <strong>example:</strong>
         * <p>18f923a7-5a5e-426d-94ae-a55ad1a4b240</p>
         */
        @NameInMap("parentId")
        public String parentId;

        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("sortKey")
        public Long sortKey;

        /**
         * <strong>example:</strong>
         * <p>OrganizationUnit</p>
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
