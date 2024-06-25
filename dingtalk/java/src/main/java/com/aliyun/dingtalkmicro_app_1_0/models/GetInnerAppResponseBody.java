// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class GetInnerAppResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("agentId")
    public Long agentId;

    /**
     * <strong>example:</strong>
     * <p>aooxxx</p>
     */
    @NameInMap("appKey")
    public String appKey;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>aaaxxxxx</p>
     */
    @NameInMap("appSecret")
    public String appSecret;

    /**
     * <strong>example:</strong>
     * <p>desc</p>
     */
    @NameInMap("desc")
    public String desc;

    /**
     * <strong>example:</strong>
     * <p><a href="https://www.dingtalk.com">https://www.dingtalk.com</a></p>
     */
    @NameInMap("homepageLink")
    public String homepageLink;

    /**
     * <strong>example:</strong>
     * <p>icon</p>
     */
    @NameInMap("icon")
    public String icon;

    @NameInMap("ipWhiteList")
    public java.util.List<String> ipWhiteList;

    /**
     * <strong>example:</strong>
     * <p>name</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <strong>example:</strong>
     * <p><a href="https://www.dingtalk.com">https://www.dingtalk.com</a></p>
     */
    @NameInMap("ompLink")
    public String ompLink;

    /**
     * <strong>example:</strong>
     * <p><a href="https://www.dingtalk.com">https://www.dingtalk.com</a></p>
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
