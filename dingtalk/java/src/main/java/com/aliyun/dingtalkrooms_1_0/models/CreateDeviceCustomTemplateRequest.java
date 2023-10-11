// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrooms_1_0.models;

import com.aliyun.tea.*;

public class CreateDeviceCustomTemplateRequest extends TeaModel {
    @NameInMap("body")
    public CreateDeviceCustomTemplateRequestBody body;

    public static CreateDeviceCustomTemplateRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateDeviceCustomTemplateRequest self = new CreateDeviceCustomTemplateRequest();
        return TeaModel.build(map, self);
    }

    public CreateDeviceCustomTemplateRequest setBody(CreateDeviceCustomTemplateRequestBody body) {
        this.body = body;
        return this;
    }
    public CreateDeviceCustomTemplateRequestBody getBody() {
        return this.body;
    }

    public static class CreateDeviceCustomTemplateRequestBody extends TeaModel {
        @NameInMap("bgImgList")
        public java.util.List<String> bgImgList;

        @NameInMap("bgType")
        public Integer bgType;

        @NameInMap("bgUrl")
        public String bgUrl;

        @NameInMap("customDoc")
        public String customDoc;

        @NameInMap("desensitizeUserName")
        public Boolean desensitizeUserName;

        @NameInMap("deviceUnionIds")
        public java.util.List<String> deviceUnionIds;

        @NameInMap("groupIds")
        public java.util.List<Long> groupIds;

        @NameInMap("hideServerCodeWhenProjecting")
        public Boolean hideServerCodeWhenProjecting;

        @NameInMap("instruction")
        public Boolean instruction;

        @NameInMap("isPicTop")
        public Integer isPicTop;

        @NameInMap("logo")
        public String logo;

        @NameInMap("orgName")
        public String orgName;

        @NameInMap("picturePlayInterval")
        public Integer picturePlayInterval;

        @NameInMap("roomIds")
        public java.util.List<String> roomIds;

        @NameInMap("showCalendarCard")
        public Boolean showCalendarCard;

        @NameInMap("showCalendarTitle")
        public Boolean showCalendarTitle;

        @NameInMap("showFunctionCard")
        public Boolean showFunctionCard;

        @NameInMap("templateName")
        public String templateName;

        public static CreateDeviceCustomTemplateRequestBody build(java.util.Map<String, ?> map) throws Exception {
            CreateDeviceCustomTemplateRequestBody self = new CreateDeviceCustomTemplateRequestBody();
            return TeaModel.build(map, self);
        }

        public CreateDeviceCustomTemplateRequestBody setBgImgList(java.util.List<String> bgImgList) {
            this.bgImgList = bgImgList;
            return this;
        }
        public java.util.List<String> getBgImgList() {
            return this.bgImgList;
        }

        public CreateDeviceCustomTemplateRequestBody setBgType(Integer bgType) {
            this.bgType = bgType;
            return this;
        }
        public Integer getBgType() {
            return this.bgType;
        }

        public CreateDeviceCustomTemplateRequestBody setBgUrl(String bgUrl) {
            this.bgUrl = bgUrl;
            return this;
        }
        public String getBgUrl() {
            return this.bgUrl;
        }

        public CreateDeviceCustomTemplateRequestBody setCustomDoc(String customDoc) {
            this.customDoc = customDoc;
            return this;
        }
        public String getCustomDoc() {
            return this.customDoc;
        }

        public CreateDeviceCustomTemplateRequestBody setDesensitizeUserName(Boolean desensitizeUserName) {
            this.desensitizeUserName = desensitizeUserName;
            return this;
        }
        public Boolean getDesensitizeUserName() {
            return this.desensitizeUserName;
        }

        public CreateDeviceCustomTemplateRequestBody setDeviceUnionIds(java.util.List<String> deviceUnionIds) {
            this.deviceUnionIds = deviceUnionIds;
            return this;
        }
        public java.util.List<String> getDeviceUnionIds() {
            return this.deviceUnionIds;
        }

        public CreateDeviceCustomTemplateRequestBody setGroupIds(java.util.List<Long> groupIds) {
            this.groupIds = groupIds;
            return this;
        }
        public java.util.List<Long> getGroupIds() {
            return this.groupIds;
        }

        public CreateDeviceCustomTemplateRequestBody setHideServerCodeWhenProjecting(Boolean hideServerCodeWhenProjecting) {
            this.hideServerCodeWhenProjecting = hideServerCodeWhenProjecting;
            return this;
        }
        public Boolean getHideServerCodeWhenProjecting() {
            return this.hideServerCodeWhenProjecting;
        }

        public CreateDeviceCustomTemplateRequestBody setInstruction(Boolean instruction) {
            this.instruction = instruction;
            return this;
        }
        public Boolean getInstruction() {
            return this.instruction;
        }

        public CreateDeviceCustomTemplateRequestBody setIsPicTop(Integer isPicTop) {
            this.isPicTop = isPicTop;
            return this;
        }
        public Integer getIsPicTop() {
            return this.isPicTop;
        }

        public CreateDeviceCustomTemplateRequestBody setLogo(String logo) {
            this.logo = logo;
            return this;
        }
        public String getLogo() {
            return this.logo;
        }

        public CreateDeviceCustomTemplateRequestBody setOrgName(String orgName) {
            this.orgName = orgName;
            return this;
        }
        public String getOrgName() {
            return this.orgName;
        }

        public CreateDeviceCustomTemplateRequestBody setPicturePlayInterval(Integer picturePlayInterval) {
            this.picturePlayInterval = picturePlayInterval;
            return this;
        }
        public Integer getPicturePlayInterval() {
            return this.picturePlayInterval;
        }

        public CreateDeviceCustomTemplateRequestBody setRoomIds(java.util.List<String> roomIds) {
            this.roomIds = roomIds;
            return this;
        }
        public java.util.List<String> getRoomIds() {
            return this.roomIds;
        }

        public CreateDeviceCustomTemplateRequestBody setShowCalendarCard(Boolean showCalendarCard) {
            this.showCalendarCard = showCalendarCard;
            return this;
        }
        public Boolean getShowCalendarCard() {
            return this.showCalendarCard;
        }

        public CreateDeviceCustomTemplateRequestBody setShowCalendarTitle(Boolean showCalendarTitle) {
            this.showCalendarTitle = showCalendarTitle;
            return this;
        }
        public Boolean getShowCalendarTitle() {
            return this.showCalendarTitle;
        }

        public CreateDeviceCustomTemplateRequestBody setShowFunctionCard(Boolean showFunctionCard) {
            this.showFunctionCard = showFunctionCard;
            return this;
        }
        public Boolean getShowFunctionCard() {
            return this.showFunctionCard;
        }

        public CreateDeviceCustomTemplateRequestBody setTemplateName(String templateName) {
            this.templateName = templateName;
            return this;
        }
        public String getTemplateName() {
            return this.templateName;
        }

    }

}
