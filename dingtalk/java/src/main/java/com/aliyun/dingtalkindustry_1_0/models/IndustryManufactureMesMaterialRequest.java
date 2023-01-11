// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class IndustryManufactureMesMaterialRequest extends TeaModel {
    /**
     * <p>本次操作的行为</p>
     */
    @NameInMap("action")
    public String action;

    /**
     * <p>生态唯一标识</p>
     */
    @NameInMap("appKey")
    public String appKey;

    /**
     * <p>主数据名称</p>
     */
    @NameInMap("baseDataName")
    public String baseDataName;

    /**
     * <p>物料品类</p>
     */
    @NameInMap("category")
    public String category;

    /**
     * <p>扩展字段</p>
     */
    @NameInMap("extendData")
    public java.util.List<IndustryManufactureMesMaterialRequestExtendData> extendData;

    /**
     * <p>物料编号</p>
     */
    @NameInMap("productCode")
    public String productCode;

    /**
     * <p>物料名称</p>
     */
    @NameInMap("productName")
    public String productName;

    /**
     * <p>物料规格</p>
     */
    @NameInMap("productSpecification")
    public String productSpecification;

    /**
     * <p>物料属性，如原材料/成品/半成品</p>
     */
    @NameInMap("prop")
    public String prop;

    /**
     * <p>物料单位</p>
     */
    @NameInMap("unit")
    public String unit;

    /**
     * <p>物料唯一标识</p>
     */
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
        /**
         * <p>字段唯一标识</p>
         */
        @NameInMap("code")
        public String code;

        /**
         * <p>字段中文描述</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>字段实际取值</p>
         */
        @NameInMap("value")
        public String value;

        /**
         * <p>字段类型</p>
         */
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
