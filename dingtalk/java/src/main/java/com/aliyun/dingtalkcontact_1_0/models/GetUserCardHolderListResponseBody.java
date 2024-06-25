// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class GetUserCardHolderListResponseBody extends TeaModel {
    @NameInMap("hasMore")
    public Boolean hasMore;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("list")
    public java.util.List<GetUserCardHolderListResponseBodyList> list;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("nextToken")
    public Long nextToken;

    @NameInMap("totalCount")
    public Integer totalCount;

    public static GetUserCardHolderListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetUserCardHolderListResponseBody self = new GetUserCardHolderListResponseBody();
        return TeaModel.build(map, self);
    }

    public GetUserCardHolderListResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public GetUserCardHolderListResponseBody setList(java.util.List<GetUserCardHolderListResponseBodyList> list) {
        this.list = list;
        return this;
    }
    public java.util.List<GetUserCardHolderListResponseBodyList> getList() {
        return this.list;
    }

    public GetUserCardHolderListResponseBody setNextToken(Long nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Long getNextToken() {
        return this.nextToken;
    }

    public GetUserCardHolderListResponseBody setTotalCount(Integer totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Integer getTotalCount() {
        return this.totalCount;
    }

    public static class GetUserCardHolderListResponseBodyList extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("avatarUrl")
        public String avatarUrl;

        @NameInMap("cardAcceptStatus")
        public Integer cardAcceptStatus;

        @NameInMap("cardAcceptTimeLong")
        public Long cardAcceptTimeLong;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("cardId")
        public String cardId;

        /**
         * <strong>example:</strong>
         * <p>0</p>
         */
        @NameInMap("cardSource")
        public Integer cardSource;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("extension")
        public java.util.Map<String, ?> extension;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("industryName")
        public String industryName;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("introduce")
        public String introduce;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("orgName")
        public String orgName;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("templateId")
        public String templateId;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("title")
        public String title;

        public static GetUserCardHolderListResponseBodyList build(java.util.Map<String, ?> map) throws Exception {
            GetUserCardHolderListResponseBodyList self = new GetUserCardHolderListResponseBodyList();
            return TeaModel.build(map, self);
        }

        public GetUserCardHolderListResponseBodyList setAvatarUrl(String avatarUrl) {
            this.avatarUrl = avatarUrl;
            return this;
        }
        public String getAvatarUrl() {
            return this.avatarUrl;
        }

        public GetUserCardHolderListResponseBodyList setCardAcceptStatus(Integer cardAcceptStatus) {
            this.cardAcceptStatus = cardAcceptStatus;
            return this;
        }
        public Integer getCardAcceptStatus() {
            return this.cardAcceptStatus;
        }

        public GetUserCardHolderListResponseBodyList setCardAcceptTimeLong(Long cardAcceptTimeLong) {
            this.cardAcceptTimeLong = cardAcceptTimeLong;
            return this;
        }
        public Long getCardAcceptTimeLong() {
            return this.cardAcceptTimeLong;
        }

        public GetUserCardHolderListResponseBodyList setCardId(String cardId) {
            this.cardId = cardId;
            return this;
        }
        public String getCardId() {
            return this.cardId;
        }

        public GetUserCardHolderListResponseBodyList setCardSource(Integer cardSource) {
            this.cardSource = cardSource;
            return this;
        }
        public Integer getCardSource() {
            return this.cardSource;
        }

        public GetUserCardHolderListResponseBodyList setExtension(java.util.Map<String, ?> extension) {
            this.extension = extension;
            return this;
        }
        public java.util.Map<String, ?> getExtension() {
            return this.extension;
        }

        public GetUserCardHolderListResponseBodyList setIndustryName(String industryName) {
            this.industryName = industryName;
            return this;
        }
        public String getIndustryName() {
            return this.industryName;
        }

        public GetUserCardHolderListResponseBodyList setIntroduce(String introduce) {
            this.introduce = introduce;
            return this;
        }
        public String getIntroduce() {
            return this.introduce;
        }

        public GetUserCardHolderListResponseBodyList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetUserCardHolderListResponseBodyList setOrgName(String orgName) {
            this.orgName = orgName;
            return this;
        }
        public String getOrgName() {
            return this.orgName;
        }

        public GetUserCardHolderListResponseBodyList setTemplateId(String templateId) {
            this.templateId = templateId;
            return this;
        }
        public String getTemplateId() {
            return this.templateId;
        }

        public GetUserCardHolderListResponseBodyList setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

}
