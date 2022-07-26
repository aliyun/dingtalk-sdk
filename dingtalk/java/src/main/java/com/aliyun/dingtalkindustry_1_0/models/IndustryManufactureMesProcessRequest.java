// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class IndustryManufactureMesProcessRequest extends TeaModel {
    // 本次操作的行为
    @NameInMap("action")
    public String action;

    // 生态唯一标识,枚举:opsoft， 需要注册
    @NameInMap("appKey")
    public String appKey;

    // 主数据名称
    @NameInMap("baseDataName")
    public String baseDataName;

    // 扩展字段
    @NameInMap("extendData")
    public java.util.List<IndustryManufactureMesProcessRequestExtendData> extendData;

    // 工序名称
    @NameInMap("name")
    public String name;

    // 是否必须派工
    @NameInMap("needDispatch")
    public String needDispatch;

    // 是否需要质检
    @NameInMap("needQualityTest")
    public String needQualityTest;

    // 工序代码
    @NameInMap("no")
    public String no;

    // 单价
    @NameInMap("price")
    public String price;

    // 工序属性(自制/委外)
    @NameInMap("prop")
    public String prop;

    // 备注
    @NameInMap("remark")
    public String remark;

    // 操作流程
    @NameInMap("sop")
    public String sop;

    // 工序唯一标识
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
        // 扩展字段唯一标识(英文)
        @NameInMap("code")
        public String code;

        // 扩展字段中文描述
        @NameInMap("name")
        public String name;

        // 扩展字段实际取值
        @NameInMap("value")
        public String value;

        // 扩展字段类型,例如string
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
