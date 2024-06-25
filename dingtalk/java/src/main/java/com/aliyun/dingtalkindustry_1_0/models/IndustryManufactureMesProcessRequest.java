// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class IndustryManufactureMesProcessRequest extends TeaModel {
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
     * <p>process</p>
     */
    @NameInMap("baseDataName")
    public String baseDataName;

    @NameInMap("extendData")
    public java.util.List<IndustryManufactureMesProcessRequestExtendData> extendData;

    /**
     * <strong>example:</strong>
     * <p>打磨</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <strong>example:</strong>
     * <p>y</p>
     */
    @NameInMap("needDispatch")
    public String needDispatch;

    /**
     * <strong>example:</strong>
     * <p>n</p>
     */
    @NameInMap("needQualityTest")
    public String needQualityTest;

    /**
     * <strong>example:</strong>
     * <p>011354</p>
     */
    @NameInMap("no")
    public String no;

    /**
     * <strong>example:</strong>
     * <p>0.21</p>
     */
    @NameInMap("price")
    public String price;

    /**
     * <strong>example:</strong>
     * <p>自制</p>
     */
    @NameInMap("prop")
    public String prop;

    /**
     * <strong>example:</strong>
     * <p>这里是备注</p>
     */
    @NameInMap("remark")
    public String remark;

    /**
     * <strong>example:</strong>
     * <p>止口面攻牙的操作方法</p>
     */
    @NameInMap("sop")
    public String sop;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>39C1E213-86B2-706B-9615-5B957DF8C15D</p>
     */
    @NameInMap("uuid")
    public String uuid;

    public static IndustryManufactureMesProcessRequest build(java.util.Map<String, ?> map) throws Exception {
        IndustryManufactureMesProcessRequest self = new IndustryManufactureMesProcessRequest();
        return TeaModel.build(map, self);
    }

    public IndustryManufactureMesProcessRequest setAction(String action) {
        this.action = action;
        return this;
    }
    public String getAction() {
        return this.action;
    }

    public IndustryManufactureMesProcessRequest setAppKey(String appKey) {
        this.appKey = appKey;
        return this;
    }
    public String getAppKey() {
        return this.appKey;
    }

    public IndustryManufactureMesProcessRequest setBaseDataName(String baseDataName) {
        this.baseDataName = baseDataName;
        return this;
    }
    public String getBaseDataName() {
        return this.baseDataName;
    }

    public IndustryManufactureMesProcessRequest setExtendData(java.util.List<IndustryManufactureMesProcessRequestExtendData> extendData) {
        this.extendData = extendData;
        return this;
    }
    public java.util.List<IndustryManufactureMesProcessRequestExtendData> getExtendData() {
        return this.extendData;
    }

    public IndustryManufactureMesProcessRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public IndustryManufactureMesProcessRequest setNeedDispatch(String needDispatch) {
        this.needDispatch = needDispatch;
        return this;
    }
    public String getNeedDispatch() {
        return this.needDispatch;
    }

    public IndustryManufactureMesProcessRequest setNeedQualityTest(String needQualityTest) {
        this.needQualityTest = needQualityTest;
        return this;
    }
    public String getNeedQualityTest() {
        return this.needQualityTest;
    }

    public IndustryManufactureMesProcessRequest setNo(String no) {
        this.no = no;
        return this;
    }
    public String getNo() {
        return this.no;
    }

    public IndustryManufactureMesProcessRequest setPrice(String price) {
        this.price = price;
        return this;
    }
    public String getPrice() {
        return this.price;
    }

    public IndustryManufactureMesProcessRequest setProp(String prop) {
        this.prop = prop;
        return this;
    }
    public String getProp() {
        return this.prop;
    }

    public IndustryManufactureMesProcessRequest setRemark(String remark) {
        this.remark = remark;
        return this;
    }
    public String getRemark() {
        return this.remark;
    }

    public IndustryManufactureMesProcessRequest setSop(String sop) {
        this.sop = sop;
        return this;
    }
    public String getSop() {
        return this.sop;
    }

    public IndustryManufactureMesProcessRequest setUuid(String uuid) {
        this.uuid = uuid;
        return this;
    }
    public String getUuid() {
        return this.uuid;
    }

    public static class IndustryManufactureMesProcessRequestExtendData extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>username</p>
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
         * <p>李四</p>
         */
        @NameInMap("value")
        public String value;

        /**
         * <strong>example:</strong>
         * <p>string</p>
         */
        @NameInMap("valueType")
        public String valueType;

        public static IndustryManufactureMesProcessRequestExtendData build(java.util.Map<String, ?> map) throws Exception {
            IndustryManufactureMesProcessRequestExtendData self = new IndustryManufactureMesProcessRequestExtendData();
            return TeaModel.build(map, self);
        }

        public IndustryManufactureMesProcessRequestExtendData setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public IndustryManufactureMesProcessRequestExtendData setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public IndustryManufactureMesProcessRequestExtendData setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

        public IndustryManufactureMesProcessRequestExtendData setValueType(String valueType) {
            this.valueType = valueType;
            return this;
        }
        public String getValueType() {
            return this.valueType;
        }

    }

}
