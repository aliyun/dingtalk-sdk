// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrooms_1_0.models;

import com.aliyun.tea.*;

public class UpdateDeviceCustomTemplateRequest extends TeaModel {
    @NameInMap("bgImgList")
    public java.util.List<String> bgImgList;

    /**
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("bgType")
    public Integer bgType;

    /**
     * <strong>example:</strong>
     * <p><a href="https://img.alicdn.com/imgextra/i2/O1CN01GWWCCR1y2D9D9EHej_!!6000000006520-2-tps-1920-470.png">https://img.alicdn.com/imgextra/i2/O1CN01GWWCCR1y2D9D9EHej_!!6000000006520-2-tps-1920-470.png</a></p>
     */
    @NameInMap("bgUrl")
    public String bgUrl;

    /**
     * <strong>example:</strong>
     * <p>测试文本</p>
     */
    @NameInMap("customDoc")
    public String customDoc;

    /**
     * <strong>example:</strong>
     * <p>true：脱敏 false：不脱敏</p>
     */
    @NameInMap("desensitizeUserName")
    public Boolean desensitizeUserName;

    @NameInMap("deviceUnionIds")
    public java.util.List<String> deviceUnionIds;

    @NameInMap("groupIds")
    public java.util.List<Long> groupIds;

    /**
     * <strong>example:</strong>
     * <p>true：隐藏 false：不隐藏</p>
     */
    @NameInMap("hideServerCodeWhenProjecting")
    public Boolean hideServerCodeWhenProjecting;

    /**
     * <strong>example:</strong>
     * <p>true：显示 false：不显示</p>
     */
    @NameInMap("instruction")
    public Boolean instruction;

    /**
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("isPicTop")
    public Integer isPicTop;

    /**
     * <strong>example:</strong>
     * <p>logo</p>
     */
    @NameInMap("logo")
    public String logo;

    /**
     * <strong>example:</strong>
     * <p>测试企业</p>
     */
    @NameInMap("orgName")
    public String orgName;

    /**
     * <strong>example:</strong>
     * <p>10</p>
     */
    @NameInMap("picturePlayInterval")
    public Integer picturePlayInterval;

    @NameInMap("roomIds")
    public java.util.List<String> roomIds;

    /**
     * <strong>example:</strong>
     * <p>true：展示 false：不展示</p>
     */
    @NameInMap("showCalendarCard")
    public Boolean showCalendarCard;

    /**
     * <strong>example:</strong>
     * <p>true：展示 false：不展示</p>
     */
    @NameInMap("showCalendarTitle")
    public Boolean showCalendarTitle;

    /**
     * <strong>example:</strong>
     * <p>true：展示 false：不展示</p>
     */
    @NameInMap("showFunctionCard")
    public Boolean showFunctionCard;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>89</p>
     */
    @NameInMap("templateId")
    public Long templateId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>测试模板</p>
     */
    @NameInMap("templateName")
    public String templateName;

    public static UpdateDeviceCustomTemplateRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateDeviceCustomTemplateRequest self = new UpdateDeviceCustomTemplateRequest();
        return TeaModel.build(map, self);
    }

    public UpdateDeviceCustomTemplateRequest setBgImgList(java.util.List<String> bgImgList) {
        this.bgImgList = bgImgList;
        return this;
    }
    public java.util.List<String> getBgImgList() {
        return this.bgImgList;
    }

    public UpdateDeviceCustomTemplateRequest setBgType(Integer bgType) {
        this.bgType = bgType;
        return this;
    }
    public Integer getBgType() {
        return this.bgType;
    }

    public UpdateDeviceCustomTemplateRequest setBgUrl(String bgUrl) {
        this.bgUrl = bgUrl;
        return this;
    }
    public String getBgUrl() {
        return this.bgUrl;
    }

    public UpdateDeviceCustomTemplateRequest setCustomDoc(String customDoc) {
        this.customDoc = customDoc;
        return this;
    }
    public String getCustomDoc() {
        return this.customDoc;
    }

    public UpdateDeviceCustomTemplateRequest setDesensitizeUserName(Boolean desensitizeUserName) {
        this.desensitizeUserName = desensitizeUserName;
        return this;
    }
    public Boolean getDesensitizeUserName() {
        return this.desensitizeUserName;
    }

    public UpdateDeviceCustomTemplateRequest setDeviceUnionIds(java.util.List<String> deviceUnionIds) {
        this.deviceUnionIds = deviceUnionIds;
        return this;
    }
    public java.util.List<String> getDeviceUnionIds() {
        return this.deviceUnionIds;
    }

    public UpdateDeviceCustomTemplateRequest setGroupIds(java.util.List<Long> groupIds) {
        this.groupIds = groupIds;
        return this;
    }
    public java.util.List<Long> getGroupIds() {
        return this.groupIds;
    }

    public UpdateDeviceCustomTemplateRequest setHideServerCodeWhenProjecting(Boolean hideServerCodeWhenProjecting) {
        this.hideServerCodeWhenProjecting = hideServerCodeWhenProjecting;
        return this;
    }
    public Boolean getHideServerCodeWhenProjecting() {
        return this.hideServerCodeWhenProjecting;
    }

    public UpdateDeviceCustomTemplateRequest setInstruction(Boolean instruction) {
        this.instruction = instruction;
        return this;
    }
    public Boolean getInstruction() {
        return this.instruction;
    }

    public UpdateDeviceCustomTemplateRequest setIsPicTop(Integer isPicTop) {
        this.isPicTop = isPicTop;
        return this;
    }
    public Integer getIsPicTop() {
        return this.isPicTop;
    }

    public UpdateDeviceCustomTemplateRequest setLogo(String logo) {
        this.logo = logo;
        return this;
    }
    public String getLogo() {
        return this.logo;
    }

    public UpdateDeviceCustomTemplateRequest setOrgName(String orgName) {
        this.orgName = orgName;
        return this;
    }
    public String getOrgName() {
        return this.orgName;
    }

    public UpdateDeviceCustomTemplateRequest setPicturePlayInterval(Integer picturePlayInterval) {
        this.picturePlayInterval = picturePlayInterval;
        return this;
    }
    public Integer getPicturePlayInterval() {
        return this.picturePlayInterval;
    }

    public UpdateDeviceCustomTemplateRequest setRoomIds(java.util.List<String> roomIds) {
        this.roomIds = roomIds;
        return this;
    }
    public java.util.List<String> getRoomIds() {
        return this.roomIds;
    }

    public UpdateDeviceCustomTemplateRequest setShowCalendarCard(Boolean showCalendarCard) {
        this.showCalendarCard = showCalendarCard;
        return this;
    }
    public Boolean getShowCalendarCard() {
        return this.showCalendarCard;
    }

    public UpdateDeviceCustomTemplateRequest setShowCalendarTitle(Boolean showCalendarTitle) {
        this.showCalendarTitle = showCalendarTitle;
        return this;
    }
    public Boolean getShowCalendarTitle() {
        return this.showCalendarTitle;
    }

    public UpdateDeviceCustomTemplateRequest setShowFunctionCard(Boolean showFunctionCard) {
        this.showFunctionCard = showFunctionCard;
        return this;
    }
    public Boolean getShowFunctionCard() {
        return this.showFunctionCard;
    }

    public UpdateDeviceCustomTemplateRequest setTemplateId(Long templateId) {
        this.templateId = templateId;
        return this;
    }
    public Long getTemplateId() {
        return this.templateId;
    }

    public UpdateDeviceCustomTemplateRequest setTemplateName(String templateName) {
        this.templateName = templateName;
        return this;
    }
    public String getTemplateName() {
        return this.templateName;
    }

}
