// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CustomizeContactUpdateRequest extends TeaModel {
    @NameInMap("code")
    public String code;

    @NameInMap("managerIdList")
    public java.util.List<String> managerIdList;

    @NameInMap("name")
    public String name;

    @NameInMap("order")
    public Long order;

    public static CustomizeContactUpdateRequest build(java.util.Map<String, ?> map) throws Exception {
        CustomizeContactUpdateRequest self = new CustomizeContactUpdateRequest();
        return TeaModel.build(map, self);
    }

    public CustomizeContactUpdateRequest setCode(String code) {
        this.code = code;
        return this;
    }
    public String getCode() {
        return this.code;
    }

    public CustomizeContactUpdateRequest setManagerIdList(java.util.List<String> managerIdList) {
        this.managerIdList = managerIdList;
        return this;
    }
    public java.util.List<String> getManagerIdList() {
        return this.managerIdList;
    }

    public CustomizeContactUpdateRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public CustomizeContactUpdateRequest setOrder(Long order) {
        this.order = order;
        return this;
    }
    public Long getOrder() {
        return this.order;
    }

}
