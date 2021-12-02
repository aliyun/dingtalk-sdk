// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateEduAssetSpaceResponseBody extends TeaModel {
    // 空间id
    @NameInMap("spaceId")
    public String spaceId;

    // 空间名称
    @NameInMap("spaceName")
    public String spaceName;

    // 空间类型
    @NameInMap("spaceType")
    public String spaceType;

    // 总容量
    @NameInMap("quota")
    public Long quota;

    // 已使用容量
    @NameInMap("usedQuota")
    public Long usedQuota;

    // 权限模型
    @NameInMap("permissionMode")
    public String permissionMode;

    // 创建时间戳
    @NameInMap("createTimeMillis")
    public Long createTimeMillis;

    // 修改时间戳
    @NameInMap("modifyTimeMillis")
    public Long modifyTimeMillis;

    public static CreateEduAssetSpaceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateEduAssetSpaceResponseBody self = new CreateEduAssetSpaceResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateEduAssetSpaceResponseBody setSpaceId(String spaceId) {
        this.spaceId = spaceId;
        return this;
    }
    public String getSpaceId() {
        return this.spaceId;
    }

    public CreateEduAssetSpaceResponseBody setSpaceName(String spaceName) {
        this.spaceName = spaceName;
        return this;
    }
    public String getSpaceName() {
        return this.spaceName;
    }

    public CreateEduAssetSpaceResponseBody setSpaceType(String spaceType) {
        this.spaceType = spaceType;
        return this;
    }
    public String getSpaceType() {
        return this.spaceType;
    }

    public CreateEduAssetSpaceResponseBody setQuota(Long quota) {
        this.quota = quota;
        return this;
    }
    public Long getQuota() {
        return this.quota;
    }

    public CreateEduAssetSpaceResponseBody setUsedQuota(Long usedQuota) {
        this.usedQuota = usedQuota;
        return this;
    }
    public Long getUsedQuota() {
        return this.usedQuota;
    }

    public CreateEduAssetSpaceResponseBody setPermissionMode(String permissionMode) {
        this.permissionMode = permissionMode;
        return this;
    }
    public String getPermissionMode() {
        return this.permissionMode;
    }

    public CreateEduAssetSpaceResponseBody setCreateTimeMillis(Long createTimeMillis) {
        this.createTimeMillis = createTimeMillis;
        return this;
    }
    public Long getCreateTimeMillis() {
        return this.createTimeMillis;
    }

    public CreateEduAssetSpaceResponseBody setModifyTimeMillis(Long modifyTimeMillis) {
        this.modifyTimeMillis = modifyTimeMillis;
        return this;
    }
    public Long getModifyTimeMillis() {
        return this.modifyTimeMillis;
    }

}
