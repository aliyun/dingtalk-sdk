// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateEduAssetSpaceResponseBody extends TeaModel {
    /**
     * <p>创建时间戳</p>
     */
    @NameInMap("createTimeMillis")
    public Long createTimeMillis;

    /**
     * <p>修改时间戳</p>
     */
    @NameInMap("modifyTimeMillis")
    public Long modifyTimeMillis;

    /**
     * <p>权限模型</p>
     */
    @NameInMap("permissionMode")
    public String permissionMode;

    /**
     * <p>总容量</p>
     */
    @NameInMap("quota")
    public Long quota;

    /**
     * <p>空间id</p>
     */
    @NameInMap("spaceId")
    public String spaceId;

    /**
     * <p>空间名称</p>
     */
    @NameInMap("spaceName")
    public String spaceName;

    /**
     * <p>空间类型</p>
     */
    @NameInMap("spaceType")
    public String spaceType;

    /**
     * <p>已使用容量</p>
     */
    @NameInMap("usedQuota")
    public Long usedQuota;

    public static CreateEduAssetSpaceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateEduAssetSpaceResponseBody self = new CreateEduAssetSpaceResponseBody();
        return TeaModel.build(map, self);
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

    public CreateEduAssetSpaceResponseBody setPermissionMode(String permissionMode) {
        this.permissionMode = permissionMode;
        return this;
    }
    public String getPermissionMode() {
        return this.permissionMode;
    }

    public CreateEduAssetSpaceResponseBody setQuota(Long quota) {
        this.quota = quota;
        return this;
    }
    public Long getQuota() {
        return this.quota;
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

    public CreateEduAssetSpaceResponseBody setUsedQuota(Long usedQuota) {
        this.usedQuota = usedQuota;
        return this;
    }
    public Long getUsedQuota() {
        return this.usedQuota;
    }

}
