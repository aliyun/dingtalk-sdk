// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CustomizeContactDeptCreateRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("code")
    public String code;

    @NameInMap("managerIdList")
    public java.util.List<String> managerIdList;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("name")
    public String name;

    @NameInMap("order")
    public Long order;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("parentDeptId")
    public Long parentDeptId;

    @NameInMap("refId")
    public Long refId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("type")
    public Long type;

    public static CustomizeContactDeptCreateRequest build(java.util.Map<String, ?> map) throws Exception {
        CustomizeContactDeptCreateRequest self = new CustomizeContactDeptCreateRequest();
        return TeaModel.build(map, self);
    }

    public CustomizeContactDeptCreateRequest setCode(String code) {
        this.code = code;
        return this;
    }
    public String getCode() {
        return this.code;
    }

    public CustomizeContactDeptCreateRequest setManagerIdList(java.util.List<String> managerIdList) {
        this.managerIdList = managerIdList;
        return this;
    }
    public java.util.List<String> getManagerIdList() {
        return this.managerIdList;
    }

    public CustomizeContactDeptCreateRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public CustomizeContactDeptCreateRequest setOrder(Long order) {
        this.order = order;
        return this;
    }
    public Long getOrder() {
        return this.order;
    }

    public CustomizeContactDeptCreateRequest setParentDeptId(Long parentDeptId) {
        this.parentDeptId = parentDeptId;
        return this;
    }
    public Long getParentDeptId() {
        return this.parentDeptId;
    }

    public CustomizeContactDeptCreateRequest setRefId(Long refId) {
        this.refId = refId;
        return this;
    }
    public Long getRefId() {
        return this.refId;
    }

    public CustomizeContactDeptCreateRequest setType(Long type) {
        this.type = type;
        return this;
    }
    public Long getType() {
        return this.type;
    }

}
