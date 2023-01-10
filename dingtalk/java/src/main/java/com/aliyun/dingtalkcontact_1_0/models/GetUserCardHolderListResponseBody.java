// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class GetUserCardHolderListResponseBody extends TeaModel {
    // 是否还有数据
    @NameInMap("hasMore")
    public Boolean hasMore;

    // 名片夹列表
    @NameInMap("list")
    public java.util.List<GetUserCardHolderListResponseBodyList> list;

    // 表示当前调用返回读取到的位置，空代表数据已经读取完毕
    @NameInMap("nextToken")
    public Long nextToken;

    // TotalCount本次请求条件下的数据总量，此参数为可选参数，默认可不返回
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
        // 头像
        @NameInMap("avatarUrl")
        public String avatarUrl;

        // 名片收下状态
        @NameInMap("cardAcceptStatus")
        public Integer cardAcceptStatus;

        @NameInMap("cardAcceptTime")
        public Object cardAcceptTime;

        // 名片ID
        @NameInMap("cardId")
        public String cardId;

        // 扩展信息
        @NameInMap("extension")
        public java.util.Map<String, ?> extension;

        // 行业名称
        @NameInMap("industryName")
        public String industryName;

        // 个人介绍
        @NameInMap("introduce")
        public String introduce;

        // 名字
        @NameInMap("name")
        public String name;

        // 组织名称
        @NameInMap("orgName")
        public String orgName;

        // 模板ID
        @NameInMap("templateId")
        public String templateId;

        // 职位
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

        public GetUserCardHolderListResponseBodyList setCardAcceptTime(Object cardAcceptTime) {
            this.cardAcceptTime = cardAcceptTime;
            return this;
        }
        public Object getCardAcceptTime() {
            return this.cardAcceptTime;
        }

        public GetUserCardHolderListResponseBodyList setCardId(String cardId) {
            this.cardId = cardId;
            return this;
        }
        public String getCardId() {
            return this.cardId;
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
