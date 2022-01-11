// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdrive_1_0.models;

import com.aliyun.tea.*;

public class AddSpaceResponseBody extends TeaModel {
    // 创建时间
    @NameInMap("createTime")
    public String createTime;

    // 修改时间
    @NameInMap("modifyTime")
    public String modifyTime;

    // 授权模式
    @NameInMap("permissionMode")
    public String permissionMode;

    // 空间总额度
    @NameInMap("quota")
    public Long quota;

    // 空间id
    @NameInMap("spaceId")
    public String spaceId;

    // 空间名称
    @NameInMap("spaceName")
    public String spaceName;

    // 空间类型
    @NameInMap("spaceType")
    public String spaceType;

    // 空间已使用额度
    @NameInMap("usedQuota")
    public Long usedQuota;

    public static AddSpaceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AddSpaceResponseBody self = new AddSpaceResponseBody();
        return TeaModel.build(map, self);
    }

    public AddSpaceResponseBody setCreateTime(String createTime) {
        this.createTime = createTime;
        return this;
    }
    public String getCreateTime() {
        return this.createTime;
    }

    public AddSpaceResponseBody setModifyTime(String modifyTime) {
        this.modifyTime = modifyTime;
        return this;
    }
    public String getModifyTime() {
        return this.modifyTime;
    }

    public AddSpaceResponseBody setPermissionMode(String permissionMode) {
        this.permissionMode = permissionMode;
        return this;
    }
    public String getPermissionMode() {
        return this.permissionMode;
    }

    public AddSpaceResponseBody setQuota(Long quota) {
        this.quota = quota;
        return this;
    }
    public Long getQuota() {
        return this.quota;
    }

    public AddSpaceResponseBody setSpaceId(String spaceId) {
        this.spaceId = spaceId;
        return this;
    }
    public String getSpaceId() {
        return this.spaceId;
    }

    public AddSpaceResponseBody setSpaceName(String spaceName) {
        this.spaceName = spaceName;
        return this;
    }
    public String getSpaceName() {
        return this.spaceName;
    }

    public AddSpaceResponseBody setSpaceType(String spaceType) {
        this.spaceType = spaceType;
        return this;
    }
    public String getSpaceType() {
        return this.spaceType;
    }

    public AddSpaceResponseBody setUsedQuota(Long usedQuota) {
        this.usedQuota = usedQuota;
        return this;
    }
    public Long getUsedQuota() {
        return this.usedQuota;
    }

}
