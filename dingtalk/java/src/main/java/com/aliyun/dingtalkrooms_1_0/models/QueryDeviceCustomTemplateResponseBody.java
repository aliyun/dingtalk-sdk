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
         * <p>1</p>
         */
        @NameInMap("confSubType")
        public Integer confSubType;

        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("confType")
        public Integer confType;

        /**
         * <strong>example:</strong>
         * <p>dingc02f685faxxxxc44ac5d6980864d335</p>
         */
        @NameInMap("corpId")
        public String corpId;

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
         * <strong>example:</strong>
         * <p>89</p>
         */
        @NameInMap("templateId")
        public Long templateId;

        /**
         * <strong>example:</strong>
         * <p>测试模板</p>
         */
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
