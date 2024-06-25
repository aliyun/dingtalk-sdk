// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrooms_1_0.models;

import com.aliyun.tea.*;

public class QueryDeviceCustomTemplateListResponseBody extends TeaModel {
    @NameInMap("result")
    public QueryDeviceCustomTemplateListResponseBodyResult result;

    public static QueryDeviceCustomTemplateListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryDeviceCustomTemplateListResponseBody self = new QueryDeviceCustomTemplateListResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryDeviceCustomTemplateListResponseBody setResult(QueryDeviceCustomTemplateListResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public QueryDeviceCustomTemplateListResponseBodyResult getResult() {
        return this.result;
    }

    public static class QueryDeviceCustomTemplateListResponseBodyResultDeviceCustomTemplates extends TeaModel {
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
         * <p>dingc02f685fxxxx81c44ac5d6980864d335</p>
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

        public static QueryDeviceCustomTemplateListResponseBodyResultDeviceCustomTemplates build(java.util.Map<String, ?> map) throws Exception {
            QueryDeviceCustomTemplateListResponseBodyResultDeviceCustomTemplates self = new QueryDeviceCustomTemplateListResponseBodyResultDeviceCustomTemplates();
            return TeaModel.build(map, self);
        }

        public QueryDeviceCustomTemplateListResponseBodyResultDeviceCustomTemplates setBgImageList(java.util.List<String> bgImageList) {
            this.bgImageList = bgImageList;
            return this;
        }
        public java.util.List<String> getBgImageList() {
            return this.bgImageList;
        }

        public QueryDeviceCustomTemplateListResponseBodyResultDeviceCustomTemplates setBgType(Integer bgType) {
            this.bgType = bgType;
            return this;
        }
        public Integer getBgType() {
            return this.bgType;
        }

        public QueryDeviceCustomTemplateListResponseBodyResultDeviceCustomTemplates setBgUrl(String bgUrl) {
            this.bgUrl = bgUrl;
            return this;
        }
        public String getBgUrl() {
            return this.bgUrl;
        }

        public QueryDeviceCustomTemplateListResponseBodyResultDeviceCustomTemplates setConfSubType(Integer confSubType) {
            this.confSubType = confSubType;
            return this;
        }
        public Integer getConfSubType() {
            return this.confSubType;
        }

        public QueryDeviceCustomTemplateListResponseBodyResultDeviceCustomTemplates setConfType(Integer confType) {
            this.confType = confType;
            return this;
        }
        public Integer getConfType() {
            return this.confType;
        }

        public QueryDeviceCustomTemplateListResponseBodyResultDeviceCustomTemplates setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public QueryDeviceCustomTemplateListResponseBodyResultDeviceCustomTemplates setCustomDoc(String customDoc) {
            this.customDoc = customDoc;
            return this;
        }
        public String getCustomDoc() {
            return this.customDoc;
        }

        public QueryDeviceCustomTemplateListResponseBodyResultDeviceCustomTemplates setDesensitizeUserName(Boolean desensitizeUserName) {
            this.desensitizeUserName = desensitizeUserName;
            return this;
        }
        public Boolean getDesensitizeUserName() {
            return this.desensitizeUserName;
        }

        public QueryDeviceCustomTemplateListResponseBodyResultDeviceCustomTemplates setHideServerCodeWhenProjecting(Boolean hideServerCodeWhenProjecting) {
            this.hideServerCodeWhenProjecting = hideServerCodeWhenProjecting;
            return this;
        }
        public Boolean getHideServerCodeWhenProjecting() {
            return this.hideServerCodeWhenProjecting;
        }

        public QueryDeviceCustomTemplateListResponseBodyResultDeviceCustomTemplates setInstruction(Boolean instruction) {
            this.instruction = instruction;
            return this;
        }
        public Boolean getInstruction() {
            return this.instruction;
        }

        public QueryDeviceCustomTemplateListResponseBodyResultDeviceCustomTemplates setIsPicTop(Integer isPicTop) {
            this.isPicTop = isPicTop;
            return this;
        }
        public Integer getIsPicTop() {
            return this.isPicTop;
        }

        public QueryDeviceCustomTemplateListResponseBodyResultDeviceCustomTemplates setLogo(String logo) {
            this.logo = logo;
            return this;
        }
        public String getLogo() {
            return this.logo;
        }

        public QueryDeviceCustomTemplateListResponseBodyResultDeviceCustomTemplates setOrgName(String orgName) {
            this.orgName = orgName;
            return this;
        }
        public String getOrgName() {
            return this.orgName;
        }

        public QueryDeviceCustomTemplateListResponseBodyResultDeviceCustomTemplates setPicturePlayInterval(Integer picturePlayInterval) {
            this.picturePlayInterval = picturePlayInterval;
            return this;
        }
        public Integer getPicturePlayInterval() {
            return this.picturePlayInterval;
        }

        public QueryDeviceCustomTemplateListResponseBodyResultDeviceCustomTemplates setShowCalendarCard(Boolean showCalendarCard) {
            this.showCalendarCard = showCalendarCard;
            return this;
        }
        public Boolean getShowCalendarCard() {
            return this.showCalendarCard;
        }

        public QueryDeviceCustomTemplateListResponseBodyResultDeviceCustomTemplates setShowCalendarTitle(Boolean showCalendarTitle) {
            this.showCalendarTitle = showCalendarTitle;
            return this;
        }
        public Boolean getShowCalendarTitle() {
            return this.showCalendarTitle;
        }

        public QueryDeviceCustomTemplateListResponseBodyResultDeviceCustomTemplates setShowFunctionCard(Boolean showFunctionCard) {
            this.showFunctionCard = showFunctionCard;
            return this;
        }
        public Boolean getShowFunctionCard() {
            return this.showFunctionCard;
        }

        public QueryDeviceCustomTemplateListResponseBodyResultDeviceCustomTemplates setTemplateId(Long templateId) {
            this.templateId = templateId;
            return this;
        }
        public Long getTemplateId() {
            return this.templateId;
        }

        public QueryDeviceCustomTemplateListResponseBodyResultDeviceCustomTemplates setTemplateName(String templateName) {
            this.templateName = templateName;
            return this;
        }
        public String getTemplateName() {
            return this.templateName;
        }

    }

    public static class QueryDeviceCustomTemplateListResponseBodyResult extends TeaModel {
        @NameInMap("deviceCustomTemplates")
        public java.util.List<QueryDeviceCustomTemplateListResponseBodyResultDeviceCustomTemplates> deviceCustomTemplates;

        @NameInMap("deviceTemplateMap")
        public java.util.Map<String, java.util.List<String>> deviceTemplateMap;

        @NameInMap("groupIdTemplateMap")
        public java.util.Map<String, java.util.List<Long>> groupIdTemplateMap;

        @NameInMap("roomIdTemplateMap")
        public java.util.Map<String, java.util.List<String>> roomIdTemplateMap;

        public static QueryDeviceCustomTemplateListResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryDeviceCustomTemplateListResponseBodyResult self = new QueryDeviceCustomTemplateListResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryDeviceCustomTemplateListResponseBodyResult setDeviceCustomTemplates(java.util.List<QueryDeviceCustomTemplateListResponseBodyResultDeviceCustomTemplates> deviceCustomTemplates) {
            this.deviceCustomTemplates = deviceCustomTemplates;
            return this;
        }
        public java.util.List<QueryDeviceCustomTemplateListResponseBodyResultDeviceCustomTemplates> getDeviceCustomTemplates() {
            return this.deviceCustomTemplates;
        }

        public QueryDeviceCustomTemplateListResponseBodyResult setDeviceTemplateMap(java.util.Map<String, java.util.List<String>> deviceTemplateMap) {
            this.deviceTemplateMap = deviceTemplateMap;
            return this;
        }
        public java.util.Map<String, java.util.List<String>> getDeviceTemplateMap() {
            return this.deviceTemplateMap;
        }

        public QueryDeviceCustomTemplateListResponseBodyResult setGroupIdTemplateMap(java.util.Map<String, java.util.List<Long>> groupIdTemplateMap) {
            this.groupIdTemplateMap = groupIdTemplateMap;
            return this;
        }
        public java.util.Map<String, java.util.List<Long>> getGroupIdTemplateMap() {
            return this.groupIdTemplateMap;
        }

        public QueryDeviceCustomTemplateListResponseBodyResult setRoomIdTemplateMap(java.util.Map<String, java.util.List<String>> roomIdTemplateMap) {
            this.roomIdTemplateMap = roomIdTemplateMap;
            return this;
        }
        public java.util.Map<String, java.util.List<String>> getRoomIdTemplateMap() {
            return this.roomIdTemplateMap;
        }

    }

}
