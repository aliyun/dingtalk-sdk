// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class AddOrgTextEmotionRequest extends TeaModel {
    /**
     * <p>展示在消息气泡上的表情的mediaId，mediaId可以通过使用文件上传接口上传表情图片得到，图片上限为500KB。</p>
     * <br>
     * <p>请严格按照表情设计规范设计表情，服务端会检查图片的大小、宽度、高度是否符合规范。</p>
     */
    @NameInMap("backgroundMediaId")
    public String backgroundMediaId;

    /**
     * <p>展示在消息长按菜单的表情的mediaId，mediaId可以通过使用文件上传接口上传表情图片得到，图片上限为500KB。</p>
     * <br>
     * <p>请严格按照表情设计规范设计表情，服务端会检查图片的大小、宽度、高度是否符合规范。</p>
     */
    @NameInMap("backgroundMediaIdForPanel")
    public String backgroundMediaIdForPanel;

    /**
     * <p>部门Id，设置规则：</p>
     * <br>
     * <p>-1：当添加企业层面的文字表情时使用-1，此时表情对企业内所有员工可见</p>
     * <br>
     * <p>一级部门Id：当添加一级部门层面的文字表情时使用一级部门Id，此时表情对该一级部门及该一级部门下的所有子部门的员工可见</p>
     */
    @NameInMap("deptId")
    public Long deptId;

    /**
     * <p>表情名称，对用户不可见</p>
     */
    @NameInMap("emotionName")
    public String emotionName;

    public static AddOrgTextEmotionRequest build(java.util.Map<String, ?> map) throws Exception {
        AddOrgTextEmotionRequest self = new AddOrgTextEmotionRequest();
        return TeaModel.build(map, self);
    }

    public AddOrgTextEmotionRequest setBackgroundMediaId(String backgroundMediaId) {
        this.backgroundMediaId = backgroundMediaId;
        return this;
    }
    public String getBackgroundMediaId() {
        return this.backgroundMediaId;
    }

    public AddOrgTextEmotionRequest setBackgroundMediaIdForPanel(String backgroundMediaIdForPanel) {
        this.backgroundMediaIdForPanel = backgroundMediaIdForPanel;
        return this;
    }
    public String getBackgroundMediaIdForPanel() {
        return this.backgroundMediaIdForPanel;
    }

    public AddOrgTextEmotionRequest setDeptId(Long deptId) {
        this.deptId = deptId;
        return this;
    }
    public Long getDeptId() {
        return this.deptId;
    }

    public AddOrgTextEmotionRequest setEmotionName(String emotionName) {
        this.emotionName = emotionName;
        return this;
    }
    public String getEmotionName() {
        return this.emotionName;
    }

}
