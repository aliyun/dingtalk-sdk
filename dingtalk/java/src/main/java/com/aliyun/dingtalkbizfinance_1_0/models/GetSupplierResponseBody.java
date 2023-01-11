// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class GetSupplierResponseBody extends TeaModel {
    /**
     * <p>供应商Code</p>
     */
    @NameInMap("code")
    public String code;

    /**
     * <p>创建时间(单位MS)</p>
     */
    @NameInMap("createTime")
    public Long createTime;

    /**
     * <p>供应商描述</p>
     */
    @NameInMap("description")
    public String description;

    /**
     * <p>供应商名称</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <p>状态：启用(valid), 停用(invalid), 删除(deleted)</p>
     */
    @NameInMap("status")
    public String status;

    /**
     * <p>用户自定义code</p>
     */
    @NameInMap("userDefineCode")
    public String userDefineCode;

    public static GetSupplierResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetSupplierResponseBody self = new GetSupplierResponseBody();
        return TeaModel.build(map, self);
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
