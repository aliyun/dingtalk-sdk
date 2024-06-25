// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class GetCategoryResponseBody extends TeaModel {
    @NameInMap("accountantBookIdList")
    public java.util.List<String> accountantBookIdList;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>INCOME_XXX</p>
     */
    @NameInMap("code")
    public String code;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>false</p>
     */
    @NameInMap("isDir")
    public Boolean isDir;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>汽车</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <strong>example:</strong>
     * <p>DIR_XXX</p>
     */
    @NameInMap("parentCode")
    public String parentCode;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>valid</p>
     */
    @NameInMap("status")
    public String status;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>income</p>
     */
    @NameInMap("type")
    public String type;

    public static GetCategoryResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetCategoryResponseBody self = new GetCategoryResponseBody();
        return TeaModel.build(map, self);
    }

    public GetCategoryResponseBody setAccountantBookIdList(java.util.List<String> accountantBookIdList) {
        this.accountantBookIdList = accountantBookIdList;
        return this;
    }
    public java.util.List<String> getAccountantBookIdList() {
        return this.accountantBookIdList;
    }

    public GetCategoryResponseBody setCode(String code) {
        this.code = code;
        return this;
    }
    public String getCode() {
        return this.code;
    }

    public GetCategoryResponseBody setIsDir(Boolean isDir) {
        this.isDir = isDir;
        return this;
    }
    public Boolean getIsDir() {
        return this.isDir;
    }

    public GetCategoryResponseBody setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public GetCategoryResponseBody setParentCode(String parentCode) {
        this.parentCode = parentCode;
        return this;
    }
    public String getParentCode() {
        return this.parentCode;
    }

    public GetCategoryResponseBody setStatus(String status) {
        this.status = status;
        return this;
    }
    public String getStatus() {
        return this.status;
    }

    public GetCategoryResponseBody setType(String type) {
        this.type = type;
        return this;
    }
    public String getType() {
        return this.type;
    }

}
