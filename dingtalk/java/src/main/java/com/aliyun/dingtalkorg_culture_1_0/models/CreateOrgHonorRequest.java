// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkorg_culture_1_0.models;

import com.aliyun.tea.*;

public class CreateOrgHonorRequest extends TeaModel {
    @NameInMap("avatarFrameMediaId")
    public String avatarFrameMediaId;

    @NameInMap("defaultBgColor")
    public String defaultBgColor;

    @NameInMap("medalDesc")
    public String medalDesc;

    @NameInMap("medalMediaId")
    public String medalMediaId;

    @NameInMap("medalName")
    public String medalName;

    @NameInMap("userId")
    public String userId;

    public static CreateOrgHonorRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateOrgHonorRequest self = new CreateOrgHonorRequest();
        return TeaModel.build(map, self);
    }

    public CreateOrgHonorRequest setAvatarFrameMediaId(String avatarFrameMediaId) {
        this.avatarFrameMediaId = avatarFrameMediaId;
        return this;
    }
    public String getAvatarFrameMediaId() {
        return this.avatarFrameMediaId;
    }

    public CreateOrgHonorRequest setDefaultBgColor(String defaultBgColor) {
        this.defaultBgColor = defaultBgColor;
        return this;
    }
    public String getDefaultBgColor() {
        return this.defaultBgColor;
    }

    public CreateOrgHonorRequest setMedalDesc(String medalDesc) {
        this.medalDesc = medalDesc;
        return this;
    }
    public String getMedalDesc() {
        return this.medalDesc;
    }

    public CreateOrgHonorRequest setMedalMediaId(String medalMediaId) {
        this.medalMediaId = medalMediaId;
        return this;
    }
    public String getMedalMediaId() {
        return this.medalMediaId;
    }

    public CreateOrgHonorRequest setMedalName(String medalName) {
        this.medalName = medalName;
        return this;
    }
    public String getMedalName() {
        return this.medalName;
    }

    public CreateOrgHonorRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
