// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class GetCustomerResponseBody extends TeaModel {
    // 客户Code
    @NameInMap("code")
    public String code;

    // 客户名称
    @NameInMap("name")
    public String name;

    // 客户描述
    @NameInMap("description")
    public String description;

    // 创建时间(单位MS)
    @NameInMap("createTime")
    public Long createTime;

    // 状态：启用(valid), 停用(invalid), 删除(deleted)
    @NameInMap("status")
    public String status;

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

    public GetCustomerResponseBody setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public GetCustomerResponseBody setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public GetCustomerResponseBody setCreateTime(Long createTime) {
        this.createTime = createTime;
        return this;
    }
    public Long getCreateTime() {
        return this.createTime;
    }

    public GetCustomerResponseBody setStatus(String status) {
        this.status = status;
        return this;
    }
    public String getStatus() {
        return this.status;
    }

}
