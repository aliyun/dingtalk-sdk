// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateEduAssetSpaceRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("bizCode")
    public String bizCode;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("spaceDesc")
    public String spaceDesc;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("spaceIcon")
    public String spaceIcon;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("spaceName")
    public String spaceName;

    /**
     * <p>This parameter is required.</p>
     */
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
