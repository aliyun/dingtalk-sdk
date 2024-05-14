// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class GetCustomerTracksByRelationIdResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("hasMore")
    public Boolean hasMore;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

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
        @NameInMap("appName")
        public String appName;

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
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("content")
        public String content;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("creatorName")
        public String creatorName;

        @NameInMap("detail")
        public java.util.Map<String, String> detail;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("format")
        public String format;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("gmtCreate")
        public String gmtCreate;

        @NameInMap("isvInfo")
        public GetCustomerTracksByRelationIdResponseBodyResultListIsvInfo isvInfo;

        @NameInMap("title")
        public String title;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("type")
        public Integer type;

        /**
         * <p>This parameter is required.</p>
         */
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
