// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdrive_1_0.models;

import com.aliyun.tea.*;

public class AddCustomSpaceRequest extends TeaModel {
    /**
     * <p>业务类型</p>
     */
    @NameInMap("bizType")
    public String bizType;

    /**
     * <p>空间标识</p>
     */
    @NameInMap("identifier")
    public String identifier;

    /**
     * <p>授权模式</p>
     */
    @NameInMap("permissionMode")
    public String permissionMode;

    /**
     * <p>用户id</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static AddCustomSpaceRequest build(java.util.Map<String, ?> map) throws Exception {
        AddCustomSpaceRequest self = new AddCustomSpaceRequest();
        return TeaModel.build(map, self);
    }

    public AddCustomSpaceRequest setBizType(String bizType) {
        this.bizType = bizType;
        return this;
    }
    public String getBizType() {
        return this.bizType;
    }

    public AddCustomSpaceRequest setIdentifier(String identifier) {
        this.identifier = identifier;
        return this;
    }
    public String getIdentifier() {
        return this.identifier;
    }

    public AddCustomSpaceRequest setPermissionMode(String permissionMode) {
        this.permissionMode = permissionMode;
        return this;
    }
    public String getPermissionMode() {
        return this.permissionMode;
    }

    public AddCustomSpaceRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
