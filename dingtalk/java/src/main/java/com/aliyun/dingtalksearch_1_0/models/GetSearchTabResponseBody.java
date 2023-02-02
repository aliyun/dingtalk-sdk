// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksearch_1_0.models;

import com.aliyun.tea.*;

public class GetSearchTabResponseBody extends TeaModel {
    /**
     * <p>暗黑模式下，数据源图标，非必填，不填则使用默认图标</p>
     */
    @NameInMap("darkIcon")
    public String darkIcon;

    /**
     * <p>创建时间</p>
     */
    @NameInMap("gmtCreate")
    public String gmtCreate;

    /**
     * <p>修改时间</p>
     */
    @NameInMap("gmtModified")
    public String gmtModified;

    /**
     * <p>数据源图标，非必填，不填则使用默认图标</p>
     */
    @NameInMap("icon")
    public String icon;

    /**
     * <p>数据源名称</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <p>数据源优先级，数值越小优先级越高</p>
     */
    @NameInMap("priority")
    public Integer priority;

    /**
     * <p>数据来源,非必填,默认来源为钉钉搜索内部引擎</p>
     */
    @NameInMap("source")
    public String source;

    /**
     * <p>数据源状态，1表示上线，0表示下线</p>
     */
    @NameInMap("status")
    public Integer status;

    /**
     * <p>数据源的id,范围为3000-4000</p>
     */
    @NameInMap("tabId")
    public Integer tabId;

    public static GetSearchTabResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetSearchTabResponseBody self = new GetSearchTabResponseBody();
        return TeaModel.build(map, self);
    }

    public GetSearchTabResponseBody setDarkIcon(String darkIcon) {
        this.darkIcon = darkIcon;
        return this;
    }
    public String getDarkIcon() {
        return this.darkIcon;
    }

    public GetSearchTabResponseBody setGmtCreate(String gmtCreate) {
        this.gmtCreate = gmtCreate;
        return this;
    }
    public String getGmtCreate() {
        return this.gmtCreate;
    }

    public GetSearchTabResponseBody setGmtModified(String gmtModified) {
        this.gmtModified = gmtModified;
        return this;
    }
    public String getGmtModified() {
        return this.gmtModified;
    }

    public GetSearchTabResponseBody setIcon(String icon) {
        this.icon = icon;
        return this;
    }
    public String getIcon() {
        return this.icon;
    }

    public GetSearchTabResponseBody setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public GetSearchTabResponseBody setPriority(Integer priority) {
        this.priority = priority;
        return this;
    }
    public Integer getPriority() {
        return this.priority;
    }

    public GetSearchTabResponseBody setSource(String source) {
        this.source = source;
        return this;
    }
    public String getSource() {
        return this.source;
    }

    public GetSearchTabResponseBody setStatus(Integer status) {
        this.status = status;
        return this;
    }
    public Integer getStatus() {
        return this.status;
    }

    public GetSearchTabResponseBody setTabId(Integer tabId) {
        this.tabId = tabId;
        return this;
    }
    public Integer getTabId() {
        return this.tabId;
    }

}
