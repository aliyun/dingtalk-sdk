// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrooms_1_0.models;

import com.aliyun.tea.*;

public class QueryDeviceCustomTemplateResponseBody extends TeaModel {
    @NameInMap("result")
    public QueryDeviceCustomTemplateResponseBodyResult result;

    public static QueryDeviceCustomTemplateResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryDeviceCustomTemplateResponseBody self = new QueryDeviceCustomTemplateResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryDeviceCustomTemplateResponseBody setResult(QueryDeviceCustomTemplateResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public QueryDeviceCustomTemplateResponseBodyResult getResult() {
        return this.result;
    }

    public static class QueryDeviceCustomTemplateResponseBodyResultDeviceCustomTemplate extends TeaModel {
        @NameInMap("bgImageList")
        public java.util.List<String> bgImageList;

        @NameInMap("bgType")
        public Integer bgType;

        @NameInMap("bgUrl")
        public String bgUrl;

        @NameInMap("confSubType")
        public Integer confSubType;

        @NameInMap("confType")
        public Integer confType;

        @NameInMap("corpId")
        public String corpId;

        @NameInMap("customDoc")
        public String customDoc;

        @NameInMap("desensitizeUserName")
        public Boolean desensitizeUserName;

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

        @NameInMap("showCalendarCard")
        public Boolean showCalendarCard;

        @NameInMap("showCalendarTitle")
        public Boolean showCalendarTitle;

        @NameInMap("showFunctionCard")
        public Boolean showFunctionCard;

        @NameInMap("templateId")
        public Long templateId;

        @NameInMap("templateName")
        public String templateName;

        public static QueryDeviceCustomTemplateResponseBodyResultDeviceCustomTemplate build(java.util.Map<String, ?> map) throws Exception {
            QueryDeviceCustomTemplateResponseBodyResultDeviceCustomTemplate self = new QueryDeviceCustomTemplateResponseBodyResultDeviceCustomTemplate();
            return TeaModel.build(map, self);
        }

        public QueryDeviceCustomTemplateResponseBodyResultDeviceCustomTemplate setBgImageList(java.util.List<String> bgImageList) {
            this.bgImageList = bgImageList;
            return this;
        }
        public java.util.List<String> getBgImageList() {
            return this.bgImageList;
        }

        public QueryDeviceCustomTemplateResponseBodyResultDeviceCustomTemplate setBgType(Integer bgType) {
            this.bgType = bgType;
            return this;
        }
        public Integer getBgType() {
            return this.bgType;
        }

        public QueryDeviceCustomTemplateResponseBodyResultDeviceCustomTemplate setBgUrl(String bgUrl) {
            this.bgUrl = bgUrl;
            return this;
        }
        public String getBgUrl() {
            return this.bgUrl;
        }

        public QueryDeviceCustomTemplateResponseBodyResultDeviceCustomTemplate setConfSubType(Integer confSubType) {
            this.confSubType = confSubType;
            return this;
        }
        public Integer getConfSubType() {
            return this.confSubType;
        }

        public QueryDeviceCustomTemplateResponseBodyResultDeviceCustomTemplate setConfType(Integer confType) {
            this.confType = confType;
            return this;
        }
        public Integer getConfType() {
            return this.confType;
        }

        public QueryDeviceCustomTemplateResponseBodyResultDeviceCustomTemplate setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public QueryDeviceCustomTemplateResponseBodyResultDeviceCustomTemplate setCustomDoc(String customDoc) {
            this.customDoc = customDoc;
            return this;
        }
        public String getCustomDoc() {
            return this.customDoc;
        }

        public QueryDeviceCustomTemplateResponseBodyResultDeviceCustomTemplate setDesensitizeUserName(Boolean desensitizeUserName) {
            this.desensitizeUserName = desensitizeUserName;
            return this;
        }
        public Boolean getDesensitizeUserName() {
            return this.desensitizeUserName;
        }

        public QueryDeviceCustomTemplateResponseBodyResultDeviceCustomTemplate setHideServerCodeWhenProjecting(Boolean hideServerCodeWhenProjecting) {
            this.hideServerCodeWhenProjecting = hideServerCodeWhenProjecting;
            return this;
        }
        public Boolean getHideServerCodeWhenProjecting() {
            return this.hideServerCodeWhenProjecting;
        }

        public QueryDeviceCustomTemplateResponseBodyResultDeviceCustomTemplate setInstruction(Boolean instruction) {
            this.instruction = instruction;
            return this;
        }
        public Boolean getInstruction() {
            return this.instruction;
        }

        public QueryDeviceCustomTemplateResponseBodyResultDeviceCustomTemplate setIsPicTop(Integer isPicTop) {
            this.isPicTop = isPicTop;
            return this;
        }
        public Integer getIsPicTop() {
            return this.isPicTop;
        }

        public QueryDeviceCustomTemplateResponseBodyResultDeviceCustomTemplate setLogo(String logo) {
            this.logo = logo;
            return this;
        }
        public String getLogo() {
            return this.logo;
        }

        public QueryDeviceCustomTemplateResponseBodyResultDeviceCustomTemplate setOrgName(String orgName) {
            this.orgName = orgName;
            return this;
        }
        public String getOrgName() {
            return this.orgName;
        }

        public QueryDeviceCustomTemplateResponseBodyResultDeviceCustomTemplate setPicturePlayInterval(Integer picturePlayInterval) {
            this.picturePlayInterval = picturePlayInterval;
            return this;
        }
        public Integer getPicturePlayInterval() {
            return this.picturePlayInterval;
        }

        public QueryDeviceCustomTemplateResponseBodyResultDeviceCustomTemplate setShowCalendarCard(Boolean showCalendarCard) {
            this.showCalendarCard = showCalendarCard;
            return this;
        }
        public Boolean getShowCalendarCard() {
            return this.showCalendarCard;
        }

        public QueryDeviceCustomTemplateResponseBodyResultDeviceCustomTemplate setShowCalendarTitle(Boolean showCalendarTitle) {
            this.showCalendarTitle = showCalendarTitle;
            return this;
        }
        public Boolean getShowCalendarTitle() {
            return this.showCalendarTitle;
        }

        public QueryDeviceCustomTemplateResponseBodyResultDeviceCustomTemplate setShowFunctionCard(Boolean showFunctionCard) {
            this.showFunctionCard = showFunctionCard;
            return this;
        }
        public Boolean getShowFunctionCard() {
            return this.showFunctionCard;
        }

        public QueryDeviceCustomTemplateResponseBodyResultDeviceCustomTemplate setTemplateId(Long templateId) {
            this.templateId = templateId;
            return this;
        }
        public Long getTemplateId() {
            return this.templateId;
        }

        public QueryDeviceCustomTemplateResponseBodyResultDeviceCustomTemplate setTemplateName(String templateName) {
            this.templateName = templateName;
            return this;
        }
        public String getTemplateName() {
            return this.templateName;
        }

    }

    public static class QueryDeviceCustomTemplateResponseBodyResult extends TeaModel {
        @NameInMap("deviceCustomTemplate")
        public QueryDeviceCustomTemplateResponseBodyResultDeviceCustomTemplate deviceCustomTemplate;

        @NameInMap("deviceUnionIds")
        public java.util.List<String> deviceUnionIds;

        @NameInMap("groupIds")
        public java.util.List<Long> groupIds;

        @NameInMap("roomIds")
        public java.util.List<String> roomIds;

        public static QueryDeviceCustomTemplateResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryDeviceCustomTemplateResponseBodyResult self = new QueryDeviceCustomTemplateResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryDeviceCustomTemplateResponseBodyResult setDeviceCustomTemplate(QueryDeviceCustomTemplateResponseBodyResultDeviceCustomTemplate deviceCustomTemplate) {
            this.deviceCustomTemplate = deviceCustomTemplate;
            return this;
        }
        public QueryDeviceCustomTemplateResponseBodyResultDeviceCustomTemplate getDeviceCustomTemplate() {
            return this.deviceCustomTemplate;
        }

        public QueryDeviceCustomTemplateResponseBodyResult setDeviceUnionIds(java.util.List<String> deviceUnionIds) {
            this.deviceUnionIds = deviceUnionIds;
            return this;
        }
        public java.util.List<String> getDeviceUnionIds() {
            return this.deviceUnionIds;
        }

        public QueryDeviceCustomTemplateResponseBodyResult setGroupIds(java.util.List<Long> groupIds) {
            this.groupIds = groupIds;
            return this;
        }
        public java.util.List<Long> getGroupIds() {
            return this.groupIds;
        }

        public QueryDeviceCustomTemplateResponseBodyResult setRoomIds(java.util.List<String> roomIds) {
            this.roomIds = roomIds;
            return this;
        }
        public java.util.List<String> getRoomIds() {
            return this.roomIds;
        }

    }

}
