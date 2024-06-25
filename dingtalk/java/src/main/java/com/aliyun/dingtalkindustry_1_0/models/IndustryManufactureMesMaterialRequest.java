// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class IndustryManufactureMesMaterialRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>add</p>
     */
    @NameInMap("action")
    public String action;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>opsoft</p>
     */
    @NameInMap("appKey")
    public String appKey;

    /**
     * <strong>example:</strong>
     * <p>material</p>
     */
    @NameInMap("baseDataName")
    public String baseDataName;

    /**
     * <strong>example:</strong>
     * <p>紧压白茶,白茶,红茶</p>
     */
    @NameInMap("category")
    public String category;

    /**
     * <strong>if can be null:</strong>
     * <p>true</p>
     */
    @NameInMap("extendData")
    public java.util.List<IndustryManufactureMesMaterialRequestExtendData> extendData;

    /**
     * <strong>example:</strong>
     * <p>20220509028</p>
     */
    @NameInMap("productCode")
    public String productCode;

    /**
     * <strong>example:</strong>
     * <p>毛坯SNR47端盖</p>
     */
    @NameInMap("productName")
    public String productName;

    /**
     * <strong>example:</strong>
     * <p>KM63</p>
     */
    @NameInMap("productSpecification")
    public String productSpecification;

    /**
     * <strong>example:</strong>
     * <p>原材料</p>
     */
    @NameInMap("prop")
    public String prop;

    /**
     * <strong>example:</strong>
     * <p>件</p>
     */
    @NameInMap("unit")
    public String unit;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>39C1E213-86B2-706B-9615-5B957DF8C15D</p>
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
         * <strong>example:</strong>
         * <p>staffName</p>
         */
        @NameInMap("code")
        public String code;

        /**
         * <strong>example:</strong>
         * <p>生产人员</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <strong>example:</strong>
         * <p>张三</p>
         */
        @NameInMap("value")
        public String value;

        /**
         * <strong>example:</strong>
         * <p>string</p>
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
