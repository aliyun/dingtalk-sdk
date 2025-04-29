// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class GetSupplierResponseBody extends TeaModel {
    @NameInMap("accountantBookIdList")
    public java.util.List<String> accountantBookIdList;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>SUP_XXX</p>
     */
    @NameInMap("code")
    public String code;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1634786828686</p>
     */
    @NameInMap("createTime")
    public Long createTime;

    @NameInMap("customFormDataList")
    public java.util.List<GetSupplierResponseBodyCustomFormDataList> customFormDataList;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>原材料供应商</p>
     */
    @NameInMap("description")
    public String description;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>XX公司</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>valid</p>
     */
    @NameInMap("status")
    public String status;

    @NameInMap("userDefineCode")
    public String userDefineCode;

    public static GetSupplierResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetSupplierResponseBody self = new GetSupplierResponseBody();
        return TeaModel.build(map, self);
    }

    public GetSupplierResponseBody setAccountantBookIdList(java.util.List<String> accountantBookIdList) {
        this.accountantBookIdList = accountantBookIdList;
        return this;
    }
    public java.util.List<String> getAccountantBookIdList() {
        return this.accountantBookIdList;
    }

    public GetSupplierResponseBody setCode(String code) {
        this.code = code;
        return this;
    }
    public String getCode() {
        return this.code;
    }

    public GetSupplierResponseBody setCreateTime(Long createTime) {
        this.createTime = createTime;
        return this;
    }
    public Long getCreateTime() {
        return this.createTime;
    }

    public GetSupplierResponseBody setCustomFormDataList(java.util.List<GetSupplierResponseBodyCustomFormDataList> customFormDataList) {
        this.customFormDataList = customFormDataList;
        return this;
    }
    public java.util.List<GetSupplierResponseBodyCustomFormDataList> getCustomFormDataList() {
        return this.customFormDataList;
    }

    public GetSupplierResponseBody setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public GetSupplierResponseBody setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public GetSupplierResponseBody setStatus(String status) {
        this.status = status;
        return this;
    }
    public String getStatus() {
        return this.status;
    }

    public GetSupplierResponseBody setUserDefineCode(String userDefineCode) {
        this.userDefineCode = userDefineCode;
        return this;
    }
    public String getUserDefineCode() {
        return this.userDefineCode;
    }

    public static class GetSupplierResponseBodyCustomFormDataList extends TeaModel {
        @NameInMap("bizAlias")
        public String bizAlias;

        @NameInMap("componentType")
        public String componentType;

        @NameInMap("extValue")
        public String extValue;

        @NameInMap("id")
        public String id;

        @NameInMap("name")
        public String name;

        @NameInMap("value")
        public String value;

        public static GetSupplierResponseBodyCustomFormDataList build(java.util.Map<String, ?> map) throws Exception {
            GetSupplierResponseBodyCustomFormDataList self = new GetSupplierResponseBodyCustomFormDataList();
            return TeaModel.build(map, self);
        }

        public GetSupplierResponseBodyCustomFormDataList setBizAlias(String bizAlias) {
            this.bizAlias = bizAlias;
            return this;
        }
        public String getBizAlias() {
            return this.bizAlias;
        }

        public GetSupplierResponseBodyCustomFormDataList setComponentType(String componentType) {
            this.componentType = componentType;
            return this;
        }
        public String getComponentType() {
            return this.componentType;
        }

        public GetSupplierResponseBodyCustomFormDataList setExtValue(String extValue) {
            this.extValue = extValue;
            return this;
        }
        public String getExtValue() {
            return this.extValue;
        }

        public GetSupplierResponseBodyCustomFormDataList setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public GetSupplierResponseBodyCustomFormDataList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetSupplierResponseBodyCustomFormDataList setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

}
