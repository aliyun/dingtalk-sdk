// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class GetProductResponseBody extends TeaModel {
    @NameInMap("accountantBookIdList")
    public java.util.List<String> accountantBookIdList;

    /**
     * <strong>example:</strong>
     * <p>PROD-xxx</p>
     */
    @NameInMap("code")
    public String code;

    /**
     * <strong>example:</strong>
     * <p>1634786828686</p>
     */
    @NameInMap("createTime")
    public Long createTime;

    /**
     * <strong>example:</strong>
     * <p>和外部合作</p>
     */
    @NameInMap("description")
    public String description;

    @NameInMap("information")
    public String information;

    /**
     * <strong>example:</strong>
     * <p>外包商品</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <strong>example:</strong>
     * <p>规格型号</p>
     */
    @NameInMap("specification")
    public String specification;

    /**
     * <strong>example:</strong>
     * <p>valid</p>
     */
    @NameInMap("status")
    public String status;

    /**
     * <strong>example:</strong>
     * <p>个</p>
     */
    @NameInMap("unit")
    public String unit;

    @NameInMap("userDefineCode")
    public String userDefineCode;

    public static GetProductResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetProductResponseBody self = new GetProductResponseBody();
        return TeaModel.build(map, self);
    }

    public GetProductResponseBody setAccountantBookIdList(java.util.List<String> accountantBookIdList) {
        this.accountantBookIdList = accountantBookIdList;
        return this;
    }
    public java.util.List<String> getAccountantBookIdList() {
        return this.accountantBookIdList;
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

    public GetProductResponseBody setInformation(String information) {
        this.information = information;
        return this;
    }
    public String getInformation() {
        return this.information;
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
