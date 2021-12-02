// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateEduAssetSpaceRequest extends TeaModel {
    // 空间名称
    @NameInMap("spaceName")
    public String spaceName;

    // 空间描述
    @NameInMap("spaceDesc")
    public String spaceDesc;

    // 空间图标
    @NameInMap("spaceIcon")
    public String spaceIcon;

    // 用户staffId
    @NameInMap("userId")
    public String userId;

    // 业务类型编码
    @NameInMap("bizCode")
    public String bizCode;

    // 组织corpId
    @NameInMap("dingCorpId")
    public String dingCorpId;

    // 组织id
    @NameInMap("dingOrgId")
    public Long dingOrgId;

    public static CreateEduAssetSpaceRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateEduAssetSpaceRequest self = new CreateEduAssetSpaceRequest();
        return TeaModel.build(map, self);
    }

    public CreateEduAssetSpaceRequest setSpaceName(String spaceName) {
        this.spaceName = spaceName;
        return this;
    }
    public String getSpaceName() {
        return this.spaceName;
    }

    public CreateEduAssetSpaceRequest setSpaceDesc(String spaceDesc) {
        this.spaceDesc = spaceDesc;
        return this;
    }
    public String getSpaceDesc() {
        return this.spaceDesc;
    }

    public CreateEduAssetSpaceRequest setSpaceIcon(String spaceIcon) {
        this.spaceIcon = spaceIcon;
        return this;
    }
    public String getSpaceIcon() {
        return this.spaceIcon;
    }

    public CreateEduAssetSpaceRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public CreateEduAssetSpaceRequest setBizCode(String bizCode) {
        this.bizCode = bizCode;
        return this;
    }
    public String getBizCode() {
        return this.bizCode;
    }

    public CreateEduAssetSpaceRequest setDingCorpId(String dingCorpId) {
        this.dingCorpId = dingCorpId;
        return this;
    }
    public String getDingCorpId() {
        return this.dingCorpId;
    }

    public CreateEduAssetSpaceRequest setDingOrgId(Long dingOrgId) {
        this.dingOrgId = dingOrgId;
        return this;
    }
    public Long getDingOrgId() {
        return this.dingOrgId;
    }

}
