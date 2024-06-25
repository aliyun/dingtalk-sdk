// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class GetCustomerResponseBody extends TeaModel {
    @NameInMap("accountantBookIdList")
    public java.util.List<String> accountantBookIdList;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>CUS_XXXX</p>
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
     * <p>重要客户</p>
     */
    @NameInMap("description")
    public String description;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>XX有限公司</p>
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

    public static GetCustomerResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetCustomerResponseBody self = new GetCustomerResponseBody();
        return TeaModel.build(map, self);
    }

    public GetCustomerResponseBody setAccountantBookIdList(java.util.List<String> accountantBookIdList) {
        this.accountantBookIdList = accountantBookIdList;
        return this;
    }
    public java.util.List<String> getAccountantBookIdList() {
        return this.accountantBookIdList;
    }

    public GetCustomerResponseBody setCode(String code) {
        this.code = code;
        return this;
    }
    public String getCode() {
        return this.code;
    }

    public GetCustomerResponseBody setCreateTime(Long createTime) {
        this.createTime = createTime;
        return this;
    }
    public Long getCreateTime() {
        return this.createTime;
    }

    public GetCustomerResponseBody setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public GetCustomerResponseBody setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public GetCustomerResponseBody setStatus(String status) {
        this.status = status;
        return this;
    }
    public String getStatus() {
        return this.status;
    }

    public GetCustomerResponseBody setUserDefineCode(String userDefineCode) {
        this.userDefineCode = userDefineCode;
        return this;
    }
    public String getUserDefineCode() {
        return this.userDefineCode;
    }

}
