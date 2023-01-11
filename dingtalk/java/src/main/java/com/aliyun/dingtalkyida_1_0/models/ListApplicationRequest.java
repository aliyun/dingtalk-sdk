// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class ListApplicationRequest extends TeaModel {
    /**
     * <p>应用过滤条件, 不填则获取发布到了宜搭应用中心的宜搭应用, 填createdByMe获取我创建的宜搭应用, 填managedByMe获取我管理的宜搭应用</p>
     */
    @NameInMap("appFilter")
    public String appFilter;

    /**
     * <p>应用名称检索关键词</p>
     */
    @NameInMap("appNameSearchKeyword")
    public String appNameSearchKeyword;

    /**
     * <p>钉钉组织id</p>
     */
    @NameInMap("corpId")
    public String corpId;

    /**
     * <p>第几页</p>
     */
    @NameInMap("pageNumber")
    public Integer pageNumber;

    /**
     * <p>分页大小</p>
     */
    @NameInMap("pageSize")
    public Integer pageSize;

    /**
     * <p>corpId+userId+CorpToken做md5加密计算生成的字符串(每个企业有自己的唯一corpToken), 获取具体计算详情请联系宜搭 dingtalk://dingtalkclient/action/sendmsg?dingtalk_id=somjffs</p>
     */
    @NameInMap("token")
    public String token;

    /**
     * <p>钉钉userId</p>
     */
    @NameInMap("userId")
    public String userId;

    public static ListApplicationRequest build(java.util.Map<String, ?> map) throws Exception {
        ListApplicationRequest self = new ListApplicationRequest();
        return TeaModel.build(map, self);
    }

    public ListApplicationRequest setAppFilter(String appFilter) {
        this.appFilter = appFilter;
        return this;
    }
    public String getAppFilter() {
        return this.appFilter;
    }

    public ListApplicationRequest setAppNameSearchKeyword(String appNameSearchKeyword) {
        this.appNameSearchKeyword = appNameSearchKeyword;
        return this;
    }
    public String getAppNameSearchKeyword() {
        return this.appNameSearchKeyword;
    }

    public ListApplicationRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public ListApplicationRequest setPageNumber(Integer pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Integer getPageNumber() {
        return this.pageNumber;
    }

    public ListApplicationRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public ListApplicationRequest setToken(String token) {
        this.token = token;
        return this;
    }
    public String getToken() {
        return this.token;
    }

    public ListApplicationRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
