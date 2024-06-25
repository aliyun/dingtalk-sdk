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

}
