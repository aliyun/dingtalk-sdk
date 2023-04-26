// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdingmi_1_0.models;

import com.aliyun.tea.*;

public class GetOfficialAccountRobotInfoResponseBody extends TeaModel {
    @NameInMap("appId")
    public Long appId;

    @NameInMap("brief")
    public String brief;

    @NameInMap("description")
    public String description;

    @NameInMap("icon")
    public String icon;

    @NameInMap("name")
    public String name;

    @NameInMap("previewMediaUrl")
    public String previewMediaUrl;

    public static GetOfficialAccountRobotInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetOfficialAccountRobotInfoResponseBody self = new GetOfficialAccountRobotInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public GetOfficialAccountRobotInfoResponseBody setAppId(Long appId) {
        this.appId = appId;
        return this;
    }
    public Long getAppId() {
        return this.appId;
    }

    public GetOfficialAccountRobotInfoResponseBody setBrief(String brief) {
        this.brief = brief;
        return this;
    }
    public String getBrief() {
        return this.brief;
    }

    public GetOfficialAccountRobotInfoResponseBody setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public GetOfficialAccountRobotInfoResponseBody setIcon(String icon) {
        this.icon = icon;
        return this;
    }
    public String getIcon() {
        return this.icon;
    }

    public GetOfficialAccountRobotInfoResponseBody setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public GetOfficialAccountRobotInfoResponseBody setPreviewMediaUrl(String previewMediaUrl) {
        this.previewMediaUrl = previewMediaUrl;
        return this;
    }
    public String getPreviewMediaUrl() {
        return this.previewMediaUrl;
    }

}
