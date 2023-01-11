// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CustomizeContactCreateRequest extends TeaModel {
    /**
     * <p>通讯录管理员UserId</p>
     */
    @NameInMap("managerIdList")
    public java.util.List<String> managerIdList;

    /**
     * <p>自定义通讯录名称</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <p>在自定义通讯录列表中的排序</p>
     */
    @NameInMap("order")
    public Long order;

    public static CustomizeContactCreateRequest build(java.util.Map<String, ?> map) throws Exception {
        CustomizeContactCreateRequest self = new CustomizeContactCreateRequest();
        return TeaModel.build(map, self);
    }

    public CustomizeContactCreateRequest setManagerIdList(java.util.List<String> managerIdList) {
        this.managerIdList = managerIdList;
        return this;
    }
    public java.util.List<String> getManagerIdList() {
        return this.managerIdList;
    }

    public CustomizeContactCreateRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public CustomizeContactCreateRequest setOrder(Long order) {
        this.order = order;
        return this;
    }
    public Long getOrder() {
        return this.order;
    }

}
