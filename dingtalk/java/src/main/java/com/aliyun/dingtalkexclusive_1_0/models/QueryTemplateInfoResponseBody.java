// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class QueryTemplateInfoResponseBody extends TeaModel {
    @NameInMap("abilitySwitch")
    public Long abilitySwitch;

    @NameInMap("appInfo")
    public QueryTemplateInfoResponseBodyAppInfo appInfo;

    @NameInMap("conversationScope")
    public java.util.List<String> conversationScope;

    @NameInMap("createAt")
    public Long createAt;

    @NameInMap("description")
    public String description;

    @NameInMap("grayConversationIds")
    public java.util.List<String> grayConversationIds;

    @NameInMap("grayInfo")
    public QueryTemplateInfoResponseBodyGrayInfo grayInfo;

    @NameInMap("grayTemplateId")
    public String grayTemplateId;

    @NameInMap("groupSettingList")
    public java.util.List<QueryTemplateInfoResponseBodyGroupSettingList> groupSettingList;

    @NameInMap("iconMediaId")
    public String iconMediaId;

    @NameInMap("modifiedAt")
    public Long modifiedAt;

    @NameInMap("modifyOrderId")
    public Long modifyOrderId;

    @NameInMap("modifyStatus")
    public Long modifyStatus;

    @NameInMap("parentTemplateDetailVO")
    public QueryTemplateInfoResponseBodyParentTemplateDetailVO parentTemplateDetailVO;

    @NameInMap("publishSubState")
    public String publishSubState;

    @NameInMap("robotTemplateList")
    public java.util.List<String> robotTemplateList;

    @NameInMap("status")
    public Integer status;

    @NameInMap("templateId")
    public String templateId;

    @NameInMap("templateIntroduction")
    public QueryTemplateInfoResponseBodyTemplateIntroduction templateIntroduction;

    @NameInMap("templateName")
    public String templateName;

    @NameInMap("templateType")
    public Integer templateType;

    @NameInMap("templateVisibility")
    public QueryTemplateInfoResponseBodyTemplateVisibility templateVisibility;

    @NameInMap("toolbarPluginList")
    public java.util.List<String> toolbarPluginList;

    @NameInMap("version")
    public Long version;

    public static QueryTemplateInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryTemplateInfoResponseBody self = new QueryTemplateInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryTemplateInfoResponseBody setAbilitySwitch(Long abilitySwitch) {
        this.abilitySwitch = abilitySwitch;
        return this;
    }
    public Long getAbilitySwitch() {
        return this.abilitySwitch;
    }

    public QueryTemplateInfoResponseBody setAppInfo(QueryTemplateInfoResponseBodyAppInfo appInfo) {
        this.appInfo = appInfo;
        return this;
    }
    public QueryTemplateInfoResponseBodyAppInfo getAppInfo() {
        return this.appInfo;
    }

    public QueryTemplateInfoResponseBody setConversationScope(java.util.List<String> conversationScope) {
        this.conversationScope = conversationScope;
        return this;
    }
    public java.util.List<String> getConversationScope() {
        return this.conversationScope;
    }

    public QueryTemplateInfoResponseBody setCreateAt(Long createAt) {
        this.createAt = createAt;
        return this;
    }
    public Long getCreateAt() {
        return this.createAt;
    }

    public QueryTemplateInfoResponseBody setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public QueryTemplateInfoResponseBody setGrayConversationIds(java.util.List<String> grayConversationIds) {
        this.grayConversationIds = grayConversationIds;
        return this;
    }
    public java.util.List<String> getGrayConversationIds() {
        return this.grayConversationIds;
    }

    public QueryTemplateInfoResponseBody setGrayInfo(QueryTemplateInfoResponseBodyGrayInfo grayInfo) {
        this.grayInfo = grayInfo;
        return this;
    }
    public QueryTemplateInfoResponseBodyGrayInfo getGrayInfo() {
        return this.grayInfo;
    }

    public QueryTemplateInfoResponseBody setGrayTemplateId(String grayTemplateId) {
        this.grayTemplateId = grayTemplateId;
        return this;
    }
    public String getGrayTemplateId() {
        return this.grayTemplateId;
    }

    public QueryTemplateInfoResponseBody setGroupSettingList(java.util.List<QueryTemplateInfoResponseBodyGroupSettingList> groupSettingList) {
        this.groupSettingList = groupSettingList;
        return this;
    }
    public java.util.List<QueryTemplateInfoResponseBodyGroupSettingList> getGroupSettingList() {
        return this.groupSettingList;
    }

    public QueryTemplateInfoResponseBody setIconMediaId(String iconMediaId) {
        this.iconMediaId = iconMediaId;
        return this;
    }
    public String getIconMediaId() {
        return this.iconMediaId;
    }

    public QueryTemplateInfoResponseBody setModifiedAt(Long modifiedAt) {
        this.modifiedAt = modifiedAt;
        return this;
    }
    public Long getModifiedAt() {
        return this.modifiedAt;
    }

    public QueryTemplateInfoResponseBody setModifyOrderId(Long modifyOrderId) {
        this.modifyOrderId = modifyOrderId;
        return this;
    }
    public Long getModifyOrderId() {
        return this.modifyOrderId;
    }

    public QueryTemplateInfoResponseBody setModifyStatus(Long modifyStatus) {
        this.modifyStatus = modifyStatus;
        return this;
    }
    public Long getModifyStatus() {
        return this.modifyStatus;
    }

    public QueryTemplateInfoResponseBody setParentTemplateDetailVO(QueryTemplateInfoResponseBodyParentTemplateDetailVO parentTemplateDetailVO) {
        this.parentTemplateDetailVO = parentTemplateDetailVO;
        return this;
    }
    public QueryTemplateInfoResponseBodyParentTemplateDetailVO getParentTemplateDetailVO() {
        return this.parentTemplateDetailVO;
    }

    public QueryTemplateInfoResponseBody setPublishSubState(String publishSubState) {
        this.publishSubState = publishSubState;
        return this;
    }
    public String getPublishSubState() {
        return this.publishSubState;
    }

    public QueryTemplateInfoResponseBody setRobotTemplateList(java.util.List<String> robotTemplateList) {
        this.robotTemplateList = robotTemplateList;
        return this;
    }
    public java.util.List<String> getRobotTemplateList() {
        return this.robotTemplateList;
    }

    public QueryTemplateInfoResponseBody setStatus(Integer status) {
        this.status = status;
        return this;
    }
    public Integer getStatus() {
        return this.status;
    }

    public QueryTemplateInfoResponseBody setTemplateId(String templateId) {
        this.templateId = templateId;
        return this;
    }
    public String getTemplateId() {
        return this.templateId;
    }

    public QueryTemplateInfoResponseBody setTemplateIntroduction(QueryTemplateInfoResponseBodyTemplateIntroduction templateIntroduction) {
        this.templateIntroduction = templateIntroduction;
        return this;
    }
    public QueryTemplateInfoResponseBodyTemplateIntroduction getTemplateIntroduction() {
        return this.templateIntroduction;
    }

    public QueryTemplateInfoResponseBody setTemplateName(String templateName) {
        this.templateName = templateName;
        return this;
    }
    public String getTemplateName() {
        return this.templateName;
    }

    public QueryTemplateInfoResponseBody setTemplateType(Integer templateType) {
        this.templateType = templateType;
        return this;
    }
    public Integer getTemplateType() {
        return this.templateType;
    }

    public QueryTemplateInfoResponseBody setTemplateVisibility(QueryTemplateInfoResponseBodyTemplateVisibility templateVisibility) {
        this.templateVisibility = templateVisibility;
        return this;
    }
    public QueryTemplateInfoResponseBodyTemplateVisibility getTemplateVisibility() {
        return this.templateVisibility;
    }

    public QueryTemplateInfoResponseBody setToolbarPluginList(java.util.List<String> toolbarPluginList) {
        this.toolbarPluginList = toolbarPluginList;
        return this;
    }
    public java.util.List<String> getToolbarPluginList() {
        return this.toolbarPluginList;
    }

    public QueryTemplateInfoResponseBody setVersion(Long version) {
        this.version = version;
        return this;
    }
    public Long getVersion() {
        return this.version;
    }

    public static class QueryTemplateInfoResponseBodyAppInfo extends TeaModel {
        @NameInMap("appIcon")
        public String appIcon;

        @NameInMap("appId")
        public String appId;

        @NameInMap("appName")
        public String appName;

        @NameInMap("corpId")
        public String corpId;

        public static QueryTemplateInfoResponseBodyAppInfo build(java.util.Map<String, ?> map) throws Exception {
            QueryTemplateInfoResponseBodyAppInfo self = new QueryTemplateInfoResponseBodyAppInfo();
            return TeaModel.build(map, self);
        }

        public QueryTemplateInfoResponseBodyAppInfo setAppIcon(String appIcon) {
            this.appIcon = appIcon;
            return this;
        }
        public String getAppIcon() {
            return this.appIcon;
        }

        public QueryTemplateInfoResponseBodyAppInfo setAppId(String appId) {
            this.appId = appId;
            return this;
        }
        public String getAppId() {
            return this.appId;
        }

        public QueryTemplateInfoResponseBodyAppInfo setAppName(String appName) {
            this.appName = appName;
            return this;
        }
        public String getAppName() {
            return this.appName;
        }

        public QueryTemplateInfoResponseBodyAppInfo setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

    }

    public static class QueryTemplateInfoResponseBodyGrayInfo extends TeaModel {
        @NameInMap("tenThousandPercent")
        public Integer tenThousandPercent;

        @NameInMap("whiteSet")
        public java.util.List<String> whiteSet;

        public static QueryTemplateInfoResponseBodyGrayInfo build(java.util.Map<String, ?> map) throws Exception {
            QueryTemplateInfoResponseBodyGrayInfo self = new QueryTemplateInfoResponseBodyGrayInfo();
            return TeaModel.build(map, self);
        }

        public QueryTemplateInfoResponseBodyGrayInfo setTenThousandPercent(Integer tenThousandPercent) {
            this.tenThousandPercent = tenThousandPercent;
            return this;
        }
        public Integer getTenThousandPercent() {
            return this.tenThousandPercent;
        }

        public QueryTemplateInfoResponseBodyGrayInfo setWhiteSet(java.util.List<String> whiteSet) {
            this.whiteSet = whiteSet;
            return this;
        }
        public java.util.List<String> getWhiteSet() {
            return this.whiteSet;
        }

    }

    public static class QueryTemplateInfoResponseBodyGroupSettingList extends TeaModel {
        @NameInMap("desc")
        public String desc;

        @NameInMap("name")
        public String name;

        @NameInMap("state")
        public Boolean state;

        public static QueryTemplateInfoResponseBodyGroupSettingList build(java.util.Map<String, ?> map) throws Exception {
            QueryTemplateInfoResponseBodyGroupSettingList self = new QueryTemplateInfoResponseBodyGroupSettingList();
            return TeaModel.build(map, self);
        }

        public QueryTemplateInfoResponseBodyGroupSettingList setDesc(String desc) {
            this.desc = desc;
            return this;
        }
        public String getDesc() {
            return this.desc;
        }

        public QueryTemplateInfoResponseBodyGroupSettingList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public QueryTemplateInfoResponseBodyGroupSettingList setState(Boolean state) {
            this.state = state;
            return this;
        }
        public Boolean getState() {
            return this.state;
        }

    }

    public static class QueryTemplateInfoResponseBodyParentTemplateDetailVORobotTemplateList extends TeaModel {
        @NameInMap("brief")
        public String brief;

        @NameInMap("code")
        public String code;

        @NameInMap("corpId")
        public String corpId;

        @NameInMap("createAt")
        public Long createAt;

        @NameInMap("description")
        public String description;

        @NameInMap("dev")
        public String dev;

        @NameInMap("groupTemplateId")
        public String groupTemplateId;

        @NameInMap("icon")
        public String icon;

        @NameInMap("modifiedAt")
        public Long modifiedAt;

        @NameInMap("name")
        public String name;

        @NameInMap("outgoingToken")
        public String outgoingToken;

        @NameInMap("outgoingUrl")
        public String outgoingUrl;

        @NameInMap("previewMediaId")
        public String previewMediaId;

        @NameInMap("sourceUrl")
        public String sourceUrl;

        @NameInMap("status")
        public Integer status;

        public static QueryTemplateInfoResponseBodyParentTemplateDetailVORobotTemplateList build(java.util.Map<String, ?> map) throws Exception {
            QueryTemplateInfoResponseBodyParentTemplateDetailVORobotTemplateList self = new QueryTemplateInfoResponseBodyParentTemplateDetailVORobotTemplateList();
            return TeaModel.build(map, self);
        }

        public QueryTemplateInfoResponseBodyParentTemplateDetailVORobotTemplateList setBrief(String brief) {
            this.brief = brief;
            return this;
        }
        public String getBrief() {
            return this.brief;
        }

        public QueryTemplateInfoResponseBodyParentTemplateDetailVORobotTemplateList setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public QueryTemplateInfoResponseBodyParentTemplateDetailVORobotTemplateList setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public QueryTemplateInfoResponseBodyParentTemplateDetailVORobotTemplateList setCreateAt(Long createAt) {
            this.createAt = createAt;
            return this;
        }
        public Long getCreateAt() {
            return this.createAt;
        }

        public QueryTemplateInfoResponseBodyParentTemplateDetailVORobotTemplateList setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public QueryTemplateInfoResponseBodyParentTemplateDetailVORobotTemplateList setDev(String dev) {
            this.dev = dev;
            return this;
        }
        public String getDev() {
            return this.dev;
        }

        public QueryTemplateInfoResponseBodyParentTemplateDetailVORobotTemplateList setGroupTemplateId(String groupTemplateId) {
            this.groupTemplateId = groupTemplateId;
            return this;
        }
        public String getGroupTemplateId() {
            return this.groupTemplateId;
        }

        public QueryTemplateInfoResponseBodyParentTemplateDetailVORobotTemplateList setIcon(String icon) {
            this.icon = icon;
            return this;
        }
        public String getIcon() {
            return this.icon;
        }

        public QueryTemplateInfoResponseBodyParentTemplateDetailVORobotTemplateList setModifiedAt(Long modifiedAt) {
            this.modifiedAt = modifiedAt;
            return this;
        }
        public Long getModifiedAt() {
            return this.modifiedAt;
        }

        public QueryTemplateInfoResponseBodyParentTemplateDetailVORobotTemplateList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public QueryTemplateInfoResponseBodyParentTemplateDetailVORobotTemplateList setOutgoingToken(String outgoingToken) {
            this.outgoingToken = outgoingToken;
            return this;
        }
        public String getOutgoingToken() {
            return this.outgoingToken;
        }

        public QueryTemplateInfoResponseBodyParentTemplateDetailVORobotTemplateList setOutgoingUrl(String outgoingUrl) {
            this.outgoingUrl = outgoingUrl;
            return this;
        }
        public String getOutgoingUrl() {
            return this.outgoingUrl;
        }

        public QueryTemplateInfoResponseBodyParentTemplateDetailVORobotTemplateList setPreviewMediaId(String previewMediaId) {
            this.previewMediaId = previewMediaId;
            return this;
        }
        public String getPreviewMediaId() {
            return this.previewMediaId;
        }

        public QueryTemplateInfoResponseBodyParentTemplateDetailVORobotTemplateList setSourceUrl(String sourceUrl) {
            this.sourceUrl = sourceUrl;
            return this;
        }
        public String getSourceUrl() {
            return this.sourceUrl;
        }

        public QueryTemplateInfoResponseBodyParentTemplateDetailVORobotTemplateList setStatus(Integer status) {
            this.status = status;
            return this;
        }
        public Integer getStatus() {
            return this.status;
        }

    }

    public static class QueryTemplateInfoResponseBodyParentTemplateDetailVOToolbarPluginList extends TeaModel {
        @NameInMap("appId")
        public String appId;

        @NameInMap("createAt")
        public Long createAt;

        @NameInMap("desc")
        public String desc;

        @NameInMap("icons")
        public String icons;

        @NameInMap("modifiedAt")
        public Long modifiedAt;

        @NameInMap("name")
        public String name;

        @NameInMap("pcUrl")
        public String pcUrl;

        @NameInMap("pluginId")
        public String pluginId;

        @NameInMap("status")
        public Integer status;

        @NameInMap("url")
        public String url;

        public static QueryTemplateInfoResponseBodyParentTemplateDetailVOToolbarPluginList build(java.util.Map<String, ?> map) throws Exception {
            QueryTemplateInfoResponseBodyParentTemplateDetailVOToolbarPluginList self = new QueryTemplateInfoResponseBodyParentTemplateDetailVOToolbarPluginList();
            return TeaModel.build(map, self);
        }

        public QueryTemplateInfoResponseBodyParentTemplateDetailVOToolbarPluginList setAppId(String appId) {
            this.appId = appId;
            return this;
        }
        public String getAppId() {
            return this.appId;
        }

        public QueryTemplateInfoResponseBodyParentTemplateDetailVOToolbarPluginList setCreateAt(Long createAt) {
            this.createAt = createAt;
            return this;
        }
        public Long getCreateAt() {
            return this.createAt;
        }

        public QueryTemplateInfoResponseBodyParentTemplateDetailVOToolbarPluginList setDesc(String desc) {
            this.desc = desc;
            return this;
        }
        public String getDesc() {
            return this.desc;
        }

        public QueryTemplateInfoResponseBodyParentTemplateDetailVOToolbarPluginList setIcons(String icons) {
            this.icons = icons;
            return this;
        }
        public String getIcons() {
            return this.icons;
        }

        public QueryTemplateInfoResponseBodyParentTemplateDetailVOToolbarPluginList setModifiedAt(Long modifiedAt) {
            this.modifiedAt = modifiedAt;
            return this;
        }
        public Long getModifiedAt() {
            return this.modifiedAt;
        }

        public QueryTemplateInfoResponseBodyParentTemplateDetailVOToolbarPluginList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public QueryTemplateInfoResponseBodyParentTemplateDetailVOToolbarPluginList setPcUrl(String pcUrl) {
            this.pcUrl = pcUrl;
            return this;
        }
        public String getPcUrl() {
            return this.pcUrl;
        }

        public QueryTemplateInfoResponseBodyParentTemplateDetailVOToolbarPluginList setPluginId(String pluginId) {
            this.pluginId = pluginId;
            return this;
        }
        public String getPluginId() {
            return this.pluginId;
        }

        public QueryTemplateInfoResponseBodyParentTemplateDetailVOToolbarPluginList setStatus(Integer status) {
            this.status = status;
            return this;
        }
        public Integer getStatus() {
            return this.status;
        }

        public QueryTemplateInfoResponseBodyParentTemplateDetailVOToolbarPluginList setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

    }

    public static class QueryTemplateInfoResponseBodyParentTemplateDetailVO extends TeaModel {
        @NameInMap("robotTemplateList")
        public java.util.List<QueryTemplateInfoResponseBodyParentTemplateDetailVORobotTemplateList> robotTemplateList;

        @NameInMap("templateId")
        public String templateId;

        @NameInMap("toolbarPluginList")
        public java.util.List<QueryTemplateInfoResponseBodyParentTemplateDetailVOToolbarPluginList> toolbarPluginList;

        public static QueryTemplateInfoResponseBodyParentTemplateDetailVO build(java.util.Map<String, ?> map) throws Exception {
            QueryTemplateInfoResponseBodyParentTemplateDetailVO self = new QueryTemplateInfoResponseBodyParentTemplateDetailVO();
            return TeaModel.build(map, self);
        }

        public QueryTemplateInfoResponseBodyParentTemplateDetailVO setRobotTemplateList(java.util.List<QueryTemplateInfoResponseBodyParentTemplateDetailVORobotTemplateList> robotTemplateList) {
            this.robotTemplateList = robotTemplateList;
            return this;
        }
        public java.util.List<QueryTemplateInfoResponseBodyParentTemplateDetailVORobotTemplateList> getRobotTemplateList() {
            return this.robotTemplateList;
        }

        public QueryTemplateInfoResponseBodyParentTemplateDetailVO setTemplateId(String templateId) {
            this.templateId = templateId;
            return this;
        }
        public String getTemplateId() {
            return this.templateId;
        }

        public QueryTemplateInfoResponseBodyParentTemplateDetailVO setToolbarPluginList(java.util.List<QueryTemplateInfoResponseBodyParentTemplateDetailVOToolbarPluginList> toolbarPluginList) {
            this.toolbarPluginList = toolbarPluginList;
            return this;
        }
        public java.util.List<QueryTemplateInfoResponseBodyParentTemplateDetailVOToolbarPluginList> getToolbarPluginList() {
            return this.toolbarPluginList;
        }

    }

    public static class QueryTemplateInfoResponseBodyTemplateIntroduction extends TeaModel {
        @NameInMap("banner")
        public String banner;

        @NameInMap("detail")
        public String detail;

        @NameInMap("title")
        public String title;

        public static QueryTemplateInfoResponseBodyTemplateIntroduction build(java.util.Map<String, ?> map) throws Exception {
            QueryTemplateInfoResponseBodyTemplateIntroduction self = new QueryTemplateInfoResponseBodyTemplateIntroduction();
            return TeaModel.build(map, self);
        }

        public QueryTemplateInfoResponseBodyTemplateIntroduction setBanner(String banner) {
            this.banner = banner;
            return this;
        }
        public String getBanner() {
            return this.banner;
        }

        public QueryTemplateInfoResponseBodyTemplateIntroduction setDetail(String detail) {
            this.detail = detail;
            return this;
        }
        public String getDetail() {
            return this.detail;
        }

        public QueryTemplateInfoResponseBodyTemplateIntroduction setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

    public static class QueryTemplateInfoResponseBodyTemplateVisibilityDeptIds extends TeaModel {
        @NameInMap("deptId")
        public String deptId;

        @NameInMap("deptName")
        public String deptName;

        public static QueryTemplateInfoResponseBodyTemplateVisibilityDeptIds build(java.util.Map<String, ?> map) throws Exception {
            QueryTemplateInfoResponseBodyTemplateVisibilityDeptIds self = new QueryTemplateInfoResponseBodyTemplateVisibilityDeptIds();
            return TeaModel.build(map, self);
        }

        public QueryTemplateInfoResponseBodyTemplateVisibilityDeptIds setDeptId(String deptId) {
            this.deptId = deptId;
            return this;
        }
        public String getDeptId() {
            return this.deptId;
        }

        public QueryTemplateInfoResponseBodyTemplateVisibilityDeptIds setDeptName(String deptName) {
            this.deptName = deptName;
            return this;
        }
        public String getDeptName() {
            return this.deptName;
        }

    }

    public static class QueryTemplateInfoResponseBodyTemplateVisibilityUserIds extends TeaModel {
        @NameInMap("avatar")
        public String avatar;

        @NameInMap("nick")
        public String nick;

        @NameInMap("userId")
        public String userId;

        public static QueryTemplateInfoResponseBodyTemplateVisibilityUserIds build(java.util.Map<String, ?> map) throws Exception {
            QueryTemplateInfoResponseBodyTemplateVisibilityUserIds self = new QueryTemplateInfoResponseBodyTemplateVisibilityUserIds();
            return TeaModel.build(map, self);
        }

        public QueryTemplateInfoResponseBodyTemplateVisibilityUserIds setAvatar(String avatar) {
            this.avatar = avatar;
            return this;
        }
        public String getAvatar() {
            return this.avatar;
        }

        public QueryTemplateInfoResponseBodyTemplateVisibilityUserIds setNick(String nick) {
            this.nick = nick;
            return this;
        }
        public String getNick() {
            return this.nick;
        }

        public QueryTemplateInfoResponseBodyTemplateVisibilityUserIds setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class QueryTemplateInfoResponseBodyTemplateVisibility extends TeaModel {
        @NameInMap("corpId")
        public String corpId;

        @NameInMap("deptIds")
        public java.util.List<QueryTemplateInfoResponseBodyTemplateVisibilityDeptIds> deptIds;

        @NameInMap("roleIds")
        public java.util.List<String> roleIds;

        @NameInMap("userIds")
        public java.util.List<QueryTemplateInfoResponseBodyTemplateVisibilityUserIds> userIds;

        public static QueryTemplateInfoResponseBodyTemplateVisibility build(java.util.Map<String, ?> map) throws Exception {
            QueryTemplateInfoResponseBodyTemplateVisibility self = new QueryTemplateInfoResponseBodyTemplateVisibility();
            return TeaModel.build(map, self);
        }

        public QueryTemplateInfoResponseBodyTemplateVisibility setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public QueryTemplateInfoResponseBodyTemplateVisibility setDeptIds(java.util.List<QueryTemplateInfoResponseBodyTemplateVisibilityDeptIds> deptIds) {
            this.deptIds = deptIds;
            return this;
        }
        public java.util.List<QueryTemplateInfoResponseBodyTemplateVisibilityDeptIds> getDeptIds() {
            return this.deptIds;
        }

        public QueryTemplateInfoResponseBodyTemplateVisibility setRoleIds(java.util.List<String> roleIds) {
            this.roleIds = roleIds;
            return this;
        }
        public java.util.List<String> getRoleIds() {
            return this.roleIds;
        }

        public QueryTemplateInfoResponseBodyTemplateVisibility setUserIds(java.util.List<QueryTemplateInfoResponseBodyTemplateVisibilityUserIds> userIds) {
            this.userIds = userIds;
            return this;
        }
        public java.util.List<QueryTemplateInfoResponseBodyTemplateVisibilityUserIds> getUserIds() {
            return this.userIds;
        }

    }

}
