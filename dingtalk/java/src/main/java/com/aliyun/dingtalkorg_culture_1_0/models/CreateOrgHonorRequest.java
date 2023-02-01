// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkorg_culture_1_0.models;

import com.aliyun.tea.*;

public class CreateOrgHonorRequest extends TeaModel {
    /**
     * <p>头像挂件   图片尺寸 240*240，不超过1M，支持PNG。图片请使用钉钉媒体资源标识符media_id，参考文档：https://open.dingtalk.com/document/isvapp-server/upload-media-files</p>
     */
    @NameInMap("avatarFrameMediaId")
    public String avatarFrameMediaId;

    /**
     * <p>背景颜色，如下可选：#FFFBB4 #FFE7BC #FFDAF4 #DAF6A8 #E4D7FF #BFDFFF #B9F2D6</p>
     */
    @NameInMap("defaultBgColor")
    public String defaultBgColor;

    /**
     * <p>描述 长度30字符 不支持表情图标等</p>
     */
    @NameInMap("medalDesc")
    public String medalDesc;

    /**
     * <p>荣誉图片  图片尺寸 900*900，不超过1M，支持PNG 。图片请使用钉钉媒体资源标识符media_id，参考文档：https://open.dingtalk.com/document/isvapp-server/upload-media-files</p>
     */
    @NameInMap("medalMediaId")
    public String medalMediaId;

    /**
     * <p>组织的勋章名称 长度10字符 不支持表情图标等</p>
     */
    @NameInMap("medalName")
    public String medalName;

    /**
     * <p>创建荣誉勋章模板人在组织内的userid，需要主/子管理员角色</p>
     */
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
