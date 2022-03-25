// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class GetCustomerTracksByRelationIdResponseBody extends TeaModel {
    // 是否还有下一页。
    @NameInMap("hasMore")
    public Boolean hasMore;

    // 下一页的游标。
    @NameInMap("nextToken")
    public String nextToken;

    // 数据列表。
    @NameInMap("resultList")
    public java.util.List<GetCustomerTracksByRelationIdResponseBodyResultList> resultList;

    public static GetCustomerTracksByRelationIdResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetCustomerTracksByRelationIdResponseBody self = new GetCustomerTracksByRelationIdResponseBody();
        return TeaModel.build(map, self);
    }

    public GetCustomerTracksByRelationIdResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public GetCustomerTracksByRelationIdResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public GetCustomerTracksByRelationIdResponseBody setResultList(java.util.List<GetCustomerTracksByRelationIdResponseBodyResultList> resultList) {
        this.resultList = resultList;
        return this;
    }
    public java.util.List<GetCustomerTracksByRelationIdResponseBodyResultList> getResultList() {
        return this.resultList;
    }

    public static class GetCustomerTracksByRelationIdResponseBodyResultListIsvInfo extends TeaModel {
        // 写入动态的三方应用所属应用名。
        @NameInMap("appName")
        public String appName;

        // 写入动态的三方应用所属组织名。
        @NameInMap("orgName")
        public String orgName;

        public static GetCustomerTracksByRelationIdResponseBodyResultListIsvInfo build(java.util.Map<String, ?> map) throws Exception {
            GetCustomerTracksByRelationIdResponseBodyResultListIsvInfo self = new GetCustomerTracksByRelationIdResponseBodyResultListIsvInfo();
            return TeaModel.build(map, self);
        }

        public GetCustomerTracksByRelationIdResponseBodyResultListIsvInfo setAppName(String appName) {
            this.appName = appName;
            return this;
        }
        public String getAppName() {
            return this.appName;
        }

        public GetCustomerTracksByRelationIdResponseBodyResultListIsvInfo setOrgName(String orgName) {
            this.orgName = orgName;
            return this;
        }
        public String getOrgName() {
            return this.orgName;
        }

    }

    public static class GetCustomerTracksByRelationIdResponseBodyResultList extends TeaModel {
        // 动态内容。
        @NameInMap("content")
        public String content;

        // 操作人姓名。
        @NameInMap("creatorName")
        public String creatorName;

        // 动态详情。
        @NameInMap("detail")
        public java.util.Map<String, String> detail;

        // 动态格式：markdown表示markdown格式，为空表示老格式
        @NameInMap("format")
        public String format;

        // 创建时间。
        @NameInMap("gmtCreate")
        public String gmtCreate;

        // 写入动态的三方应用身份信息。
        @NameInMap("isvInfo")
        public GetCustomerTracksByRelationIdResponseBodyResultListIsvInfo isvInfo;

        // 动态标题。
        @NameInMap("title")
        public String title;

        // 动态类型。
        @NameInMap("type")
        public Integer type;

        // 动态类型分组。
        @NameInMap("typeGroup")
        public Integer typeGroup;

        public static GetCustomerTracksByRelationIdResponseBodyResultList build(java.util.Map<String, ?> map) throws Exception {
            GetCustomerTracksByRelationIdResponseBodyResultList self = new GetCustomerTracksByRelationIdResponseBodyResultList();
            return TeaModel.build(map, self);
        }

        public GetCustomerTracksByRelationIdResponseBodyResultList setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

        public GetCustomerTracksByRelationIdResponseBodyResultList setCreatorName(String creatorName) {
            this.creatorName = creatorName;
            return this;
        }
        public String getCreatorName() {
            return this.creatorName;
        }

        public GetCustomerTracksByRelationIdResponseBodyResultList setDetail(java.util.Map<String, String> detail) {
            this.detail = detail;
            return this;
        }
        public java.util.Map<String, String> getDetail() {
            return this.detail;
        }

        public GetCustomerTracksByRelationIdResponseBodyResultList setFormat(String format) {
            this.format = format;
            return this;
        }
        public String getFormat() {
            return this.format;
        }

        public GetCustomerTracksByRelationIdResponseBodyResultList setGmtCreate(String gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public String getGmtCreate() {
            return this.gmtCreate;
        }

        public GetCustomerTracksByRelationIdResponseBodyResultList setIsvInfo(GetCustomerTracksByRelationIdResponseBodyResultListIsvInfo isvInfo) {
            this.isvInfo = isvInfo;
            return this;
        }
        public GetCustomerTracksByRelationIdResponseBodyResultListIsvInfo getIsvInfo() {
            return this.isvInfo;
        }

        public GetCustomerTracksByRelationIdResponseBodyResultList setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public GetCustomerTracksByRelationIdResponseBodyResultList setType(Integer type) {
            this.type = type;
            return this;
        }
        public Integer getType() {
            return this.type;
        }

        public GetCustomerTracksByRelationIdResponseBodyResultList setTypeGroup(Integer typeGroup) {
            this.typeGroup = typeGroup;
            return this;
        }
        public Integer getTypeGroup() {
            return this.typeGroup;
        }

    }

}
