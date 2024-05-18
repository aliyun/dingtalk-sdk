// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class InsertOrUpdateDirRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("bizGroup")
    public String bizGroup;

    @NameInMap("description")
    public String description;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("name18n")
    public String name18n;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("operateUserId")
    public String operateUserId;

    public static InsertOrUpdateDirRequest build(java.util.Map<String, ?> map) throws Exception {
        InsertOrUpdateDirRequest self = new InsertOrUpdateDirRequest();
        return TeaModel.build(map, self);
    }

    public InsertOrUpdateDirRequest setBizGroup(String bizGroup) {
        this.bizGroup = bizGroup;
        return this;
    }
    public String getBizGroup() {
        return this.bizGroup;
    }

    public InsertOrUpdateDirRequest setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public InsertOrUpdateDirRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public InsertOrUpdateDirRequest setName18n(String name18n) {
        this.name18n = name18n;
        return this;
    }
    public String getName18n() {
        return this.name18n;
    }

    public InsertOrUpdateDirRequest setOperateUserId(String operateUserId) {
        this.operateUserId = operateUserId;
        return this;
    }
    public String getOperateUserId() {
        return this.operateUserId;
    }

}
