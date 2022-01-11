// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateEduAssetSpaceRequest extends TeaModel {
    // 业务类型编码
    @NameInMap("bizCode")
    public String bizCode;

    // 空间描述
    @NameInMap("spaceDesc")
    public String spaceDesc;

    // 空间图标
    @NameInMap("spaceIcon")
    public String spaceIcon;

    // 空间名称
    @NameInMap("spaceName")
    public String spaceName;

    // 用户staffId
    @NameInMap("userId")
    public String userId;

    public static CreateEduAssetSpaceRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateEduAssetSpaceRequest self = new CreateEduAssetSpaceRequest();
        return TeaModel.build(map, self);
    }

    public CreateEduAssetSpaceRequest setBizCode(String bizCode) {
        this.bizCode = bizCode;
        return this;
    }
    public String getBizCode() {
        return this.bizCode;
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

    public CreateEduAssetSpaceRequest setSpaceName(String spaceName) {
        this.spaceName = spaceName;
        return this;
    }
    public String getSpaceName() {
        return this.spaceName;
    }

    public CreateEduAssetSpaceRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
