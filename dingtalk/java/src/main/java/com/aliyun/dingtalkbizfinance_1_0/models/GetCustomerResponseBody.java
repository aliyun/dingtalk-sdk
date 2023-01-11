// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class GetCustomerResponseBody extends TeaModel {
    /**
     * <p>客户Code</p>
     */
    @NameInMap("code")
    public String code;

    /**
     * <p>创建时间(单位MS)</p>
     */
    @NameInMap("createTime")
    public Long createTime;

    /**
     * <p>客户描述</p>
     */
    @NameInMap("description")
    public String description;

    /**
     * <p>客户名称</p>
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

    public static GetCustomerResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetCustomerResponseBody self = new GetCustomerResponseBody();
        return TeaModel.build(map, self);
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
