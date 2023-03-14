// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class GetProductResponseBody extends TeaModel {
    /**
     * <p>Id of the request</p>
     */
    @NameInMap("code")
    public String code;

    /**
     * <p>创建时间</p>
     */
    @NameInMap("createTime")
    public Long createTime;

    /**
     * <p>商品备注</p>
     */
    @NameInMap("description")
    public String description;

    /**
     * <p>商品名称</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <p>规格型号</p>
     */
    @NameInMap("specification")
    public String specification;

    /**
     * <p>商品状态</p>
     */
    @NameInMap("status")
    public String status;

    /**
     * <p>商品单位</p>
     */
    @NameInMap("unit")
    public String unit;

    /**
     * <p>商品用户自定义码</p>
     */
    @NameInMap("userDefineCode")
    public String userDefineCode;

    public static GetProductResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetProductResponseBody self = new GetProductResponseBody();
        return TeaModel.build(map, self);
    }

    public GetProductResponseBody setCode(String code) {
        this.code = code;
        return this;
    }
    public String getCode() {
        return this.code;
    }

    public GetProductResponseBody setCreateTime(Long createTime) {
        this.createTime = createTime;
        return this;
    }
    public Long getCreateTime() {
        return this.createTime;
    }

    public GetProductResponseBody setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public GetProductResponseBody setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public GetProductResponseBody setSpecification(String specification) {
        this.specification = specification;
        return this;
    }
    public String getSpecification() {
        return this.specification;
    }

    public GetProductResponseBody setStatus(String status) {
        this.status = status;
        return this;
    }
    public String getStatus() {
        return this.status;
    }

    public GetProductResponseBody setUnit(String unit) {
        this.unit = unit;
        return this;
    }
    public String getUnit() {
        return this.unit;
    }

    public GetProductResponseBody setUserDefineCode(String userDefineCode) {
        this.userDefineCode = userDefineCode;
        return this;
    }
    public String getUserDefineCode() {
        return this.userDefineCode;
    }

}
