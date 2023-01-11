// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetNotifyMeRequest extends TeaModel {
    /**
     * <p>应用标识列表</p>
     */
    @NameInMap("appTypes")
    public String appTypes;

    /**
     * <p>企业ID</p>
     */
    @NameInMap("corpId")
    public String corpId;

    /**
     * <p>抄送到达时间开始</p>
     */
    @NameInMap("createFromTimeGMT")
    public Long createFromTimeGMT;

    /**
     * <p>抄送到达时间结束</p>
     */
    @NameInMap("createToTimeGMT")
    public Long createToTimeGMT;

    /**
     * <p>数据提交时间开始</p>
     */
    @NameInMap("instanceCreateFromTimeGMT")
    public Long instanceCreateFromTimeGMT;

    /**
     * <p>数据提交时间结束</p>
     */
    @NameInMap("instanceCreateToTimeGMT")
    public Long instanceCreateToTimeGMT;

    /**
     * <p>表单中组件数据模糊搜</p>
     */
    @NameInMap("keyword")
    public String keyword;

    /**
     * <p>语言环境</p>
     */
    @NameInMap("language")
    public String language;

    /**
     * <p>当前页</p>
     */
    @NameInMap("pageNumber")
    public Integer pageNumber;

    /**
     * <p>每页记录数</p>
     */
    @NameInMap("pageSize")
    public Integer pageSize;

    /**
     * <p>流程code列表</p>
     */
    @NameInMap("processCodes")
    public String processCodes;

    /**
     * <p>验权token</p>
     */
    @NameInMap("token")
    public String token;

    public static GetNotifyMeRequest build(java.util.Map<String, ?> map) throws Exception {
        GetNotifyMeRequest self = new GetNotifyMeRequest();
        return TeaModel.build(map, self);
    }

    public GetNotifyMeRequest setAppTypes(String appTypes) {
        this.appTypes = appTypes;
        return this;
    }
    public String getAppTypes() {
        return this.appTypes;
    }

    public GetNotifyMeRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public GetNotifyMeRequest setCreateFromTimeGMT(Long createFromTimeGMT) {
        this.createFromTimeGMT = createFromTimeGMT;
        return this;
    }
    public Long getCreateFromTimeGMT() {
        return this.createFromTimeGMT;
    }

    public GetNotifyMeRequest setCreateToTimeGMT(Long createToTimeGMT) {
        this.createToTimeGMT = createToTimeGMT;
        return this;
    }
    public Long getCreateToTimeGMT() {
        return this.createToTimeGMT;
    }

    public GetNotifyMeRequest setInstanceCreateFromTimeGMT(Long instanceCreateFromTimeGMT) {
        this.instanceCreateFromTimeGMT = instanceCreateFromTimeGMT;
        return this;
    }
    public Long getInstanceCreateFromTimeGMT() {
        return this.instanceCreateFromTimeGMT;
    }

    public GetNotifyMeRequest setInstanceCreateToTimeGMT(Long instanceCreateToTimeGMT) {
        this.instanceCreateToTimeGMT = instanceCreateToTimeGMT;
        return this;
    }
    public Long getInstanceCreateToTimeGMT() {
        return this.instanceCreateToTimeGMT;
    }

    public GetNotifyMeRequest setKeyword(String keyword) {
        this.keyword = keyword;
        return this;
    }
    public String getKeyword() {
        return this.keyword;
    }

    public GetNotifyMeRequest setLanguage(String language) {
        this.language = language;
        return this;
    }
    public String getLanguage() {
        return this.language;
    }

    public GetNotifyMeRequest setPageNumber(Integer pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Integer getPageNumber() {
        return this.pageNumber;
    }

    public GetNotifyMeRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public GetNotifyMeRequest setProcessCodes(String processCodes) {
        this.processCodes = processCodes;
        return this;
    }
    public String getProcessCodes() {
        return this.processCodes;
    }

    public GetNotifyMeRequest setToken(String token) {
        this.token = token;
        return this;
    }
    public String getToken() {
        return this.token;
    }

}
