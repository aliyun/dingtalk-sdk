// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class GetInnerAppResponseBody extends TeaModel {
    /**
     * <p>应用id</p>
     */
    @NameInMap("agentId")
    public Long agentId;

    /**
     * <p>应用的appkey</p>
     */
    @NameInMap("appKey")
    public String appKey;

    /**
     * <p>应用的secret</p>
     */
    @NameInMap("appSecret")
    public String appSecret;

    /**
     * <p>应用描述</p>
     */
    @NameInMap("desc")
    public String desc;

    /**
     * <p>应用移动端首页地址</p>
     */
    @NameInMap("homepageLink")
    public String homepageLink;

    /**
     * <p>应用图标</p>
     */
    @NameInMap("icon")
    public String icon;

    /**
     * <p>服务器出口ip</p>
     */
    @NameInMap("ipWhiteList")
    public java.util.List<String> ipWhiteList;

    /**
     * <p>应用名称</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <p>应用管理后台地址</p>
     */
    @NameInMap("ompLink")
    public String ompLink;

    /**
     * <p>应用PC端首页地址</p>
     */
    @NameInMap("pcHomepageLink")
    public String pcHomepageLink;

    public static GetInnerAppResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetInnerAppResponseBody self = new GetInnerAppResponseBody();
        return TeaModel.build(map, self);
    }

    public GetInnerAppResponseBody setAgentId(Long agentId) {
        this.agentId = agentId;
        return this;
    }
    public Long getAgentId() {
        return this.agentId;
    }

    public GetInnerAppResponseBody setAppKey(String appKey) {
        this.appKey = appKey;
        return this;
    }
    public String getAppKey() {
        return this.appKey;
    }

    public GetInnerAppResponseBody setAppSecret(String appSecret) {
        this.appSecret = appSecret;
        return this;
    }
    public String getAppSecret() {
        return this.appSecret;
    }

    public GetInnerAppResponseBody setDesc(String desc) {
        this.desc = desc;
        return this;
    }
    public String getDesc() {
        return this.desc;
    }

    public GetInnerAppResponseBody setHomepageLink(String homepageLink) {
        this.homepageLink = homepageLink;
        return this;
    }
    public String getHomepageLink() {
        return this.homepageLink;
    }

    public GetInnerAppResponseBody setIcon(String icon) {
        this.icon = icon;
        return this;
    }
    public String getIcon() {
        return this.icon;
    }

    public GetInnerAppResponseBody setIpWhiteList(java.util.List<String> ipWhiteList) {
        this.ipWhiteList = ipWhiteList;
        return this;
    }
    public java.util.List<String> getIpWhiteList() {
        return this.ipWhiteList;
    }

    public GetInnerAppResponseBody setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public GetInnerAppResponseBody setOmpLink(String ompLink) {
        this.ompLink = ompLink;
        return this;
    }
    public String getOmpLink() {
        return this.ompLink;
    }

    public GetInnerAppResponseBody setPcHomepageLink(String pcHomepageLink) {
        this.pcHomepageLink = pcHomepageLink;
        return this;
    }
    public String getPcHomepageLink() {
        return this.pcHomepageLink;
    }

}
