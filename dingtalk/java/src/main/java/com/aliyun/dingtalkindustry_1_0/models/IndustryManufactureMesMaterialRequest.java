// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class IndustryManufactureMesMaterialRequest extends TeaModel {
    @NameInMap("action")
    public String action;

    @NameInMap("appKey")
    public String appKey;

    @NameInMap("baseDataName")
    public String baseDataName;

    @NameInMap("category")
    public String category;

    @NameInMap("extendData")
    public java.util.List<IndustryManufactureMesMaterialRequestExtendData> extendData;

    @NameInMap("productCode")
    public String productCode;

    @NameInMap("productName")
    public String productName;

    @NameInMap("productSpecification")
    public String productSpecification;

    @NameInMap("prop")
    public String prop;

    @NameInMap("unit")
    public String unit;

    @NameInMap("uuid")
    public String uuid;

    public static IndustryManufactureMesMaterialRequest build(java.util.Map<String, ?> map) throws Exception {
        IndustryManufactureMesMaterialRequest self = new IndustryManufactureMesMaterialRequest();
        return TeaModel.build(map, self);
    }

    public IndustryManufactureMesMaterialRequest setAction(String action) {
        this.action = action;
        return this;
    }
    public String getAction() {
        return this.action;
    }

    public IndustryManufactureMesMaterialRequest setAppKey(String appKey) {
        this.appKey = appKey;
        return this;
    }
    public String getAppKey() {
        return this.appKey;
    }

    public IndustryManufactureMesMaterialRequest setBaseDataName(String baseDataName) {
        this.baseDataName = baseDataName;
        return this;
    }
    public String getBaseDataName() {
        return this.baseDataName;
    }

    public IndustryManufactureMesMaterialRequest setCategory(String category) {
        this.category = category;
        return this;
    }
    public String getCategory() {
        return this.category;
    }

    public IndustryManufactureMesMaterialRequest setExtendData(java.util.List<IndustryManufactureMesMaterialRequestExtendData> extendData) {
        this.extendData = extendData;
        return this;
    }
    public java.util.List<IndustryManufactureMesMaterialRequestExtendData> getExtendData() {
        return this.extendData;
    }

    public IndustryManufactureMesMaterialRequest setProductCode(String productCode) {
        this.productCode = productCode;
        return this;
    }
    public String getProductCode() {
        return this.productCode;
    }

    public IndustryManufactureMesMaterialRequest setProductName(String productName) {
        this.productName = productName;
        return this;
    }
    public String getProductName() {
        return this.productName;
    }

    public IndustryManufactureMesMaterialRequest setProductSpecification(String productSpecification) {
        this.productSpecification = productSpecification;
        return this;
    }
    public String getProductSpecification() {
        return this.productSpecification;
    }

    public IndustryManufactureMesMaterialRequest setProp(String prop) {
        this.prop = prop;
        return this;
    }
    public String getProp() {
        return this.prop;
    }

    public IndustryManufactureMesMaterialRequest setUnit(String unit) {
        this.unit = unit;
        return this;
    }
    public String getUnit() {
        return this.unit;
    }

    public IndustryManufactureMesMaterialRequest setUuid(String uuid) {
        this.uuid = uuid;
        return this;
    }
    public String getUuid() {
        return this.uuid;
    }

    public static class IndustryManufactureMesMaterialRequestExtendData extends TeaModel {
        @NameInMap("code")
        public String code;

        @NameInMap("name")
        public String name;

        @NameInMap("value")
        public String value;

        @NameInMap("valueType")
        public String valueType;

        public static IndustryManufactureMesMaterialRequestExtendData build(java.util.Map<String, ?> map) throws Exception {
            IndustryManufactureMesMaterialRequestExtendData self = new IndustryManufactureMesMaterialRequestExtendData();
            return TeaModel.build(map, self);
        }

        public IndustryManufactureMesMaterialRequestExtendData setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public IndustryManufactureMesMaterialRequestExtendData setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public IndustryManufactureMesMaterialRequestExtendData setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

        public IndustryManufactureMesMaterialRequestExtendData setValueType(String valueType) {
            this.valueType = valueType;
            return this;
        }
        public String getValueType() {
            return this.valueType;
        }

    }

}
