// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_e_e_1_0.models;

import com.aliyun.tea.*;

public class GetTemplateListResponseBody extends TeaModel {
    @NameInMap("data")
    public java.util.List<GetTemplateListResponseBodyData> data;

    @NameInMap("pageNumber")
    public Integer pageNumber;

    @NameInMap("pageSize")
    public Integer pageSize;

    @NameInMap("totalCount")
    public Integer totalCount;

    public static GetTemplateListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetTemplateListResponseBody self = new GetTemplateListResponseBody();
        return TeaModel.build(map, self);
    }

    public GetTemplateListResponseBody setData(java.util.List<GetTemplateListResponseBodyData> data) {
        this.data = data;
        return this;
    }
    public java.util.List<GetTemplateListResponseBodyData> getData() {
        return this.data;
    }

    public GetTemplateListResponseBody setPageNumber(Integer pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Integer getPageNumber() {
        return this.pageNumber;
    }

    public GetTemplateListResponseBody setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public GetTemplateListResponseBody setTotalCount(Integer totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Integer getTotalCount() {
        return this.totalCount;
    }

    public static class GetTemplateListResponseBodyDataActions extends TeaModel {
        @NameInMap("actionKey")
        public String actionKey;

        @NameInMap("description")
        public String description;

        @NameInMap("name")
        public String name;

        @NameInMap("needReason")
        public Boolean needReason;

        @NameInMap("needReasonRequired")
        public Boolean needReasonRequired;

        @NameInMap("order")
        public Long order;

        @NameInMap("styleType")
        public Long styleType;

        public static GetTemplateListResponseBodyDataActions build(java.util.Map<String, ?> map) throws Exception {
            GetTemplateListResponseBodyDataActions self = new GetTemplateListResponseBodyDataActions();
            return TeaModel.build(map, self);
        }

        public GetTemplateListResponseBodyDataActions setActionKey(String actionKey) {
            this.actionKey = actionKey;
            return this;
        }
        public String getActionKey() {
            return this.actionKey;
        }

        public GetTemplateListResponseBodyDataActions setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public GetTemplateListResponseBodyDataActions setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetTemplateListResponseBodyDataActions setNeedReason(Boolean needReason) {
            this.needReason = needReason;
            return this;
        }
        public Boolean getNeedReason() {
            return this.needReason;
        }

        public GetTemplateListResponseBodyDataActions setNeedReasonRequired(Boolean needReasonRequired) {
            this.needReasonRequired = needReasonRequired;
            return this;
        }
        public Boolean getNeedReasonRequired() {
            return this.needReasonRequired;
        }

        public GetTemplateListResponseBodyDataActions setOrder(Long order) {
            this.order = order;
            return this;
        }
        public Long getOrder() {
            return this.order;
        }

        public GetTemplateListResponseBodyDataActions setStyleType(Long styleType) {
            this.styleType = styleType;
            return this;
        }
        public Long getStyleType() {
            return this.styleType;
        }

    }

    public static class GetTemplateListResponseBodyData extends TeaModel {
        @NameInMap("actions")
        public java.util.List<GetTemplateListResponseBodyDataActions> actions;

        @NameInMap("createTime")
        public Long createTime;

        @NameInMap("creatorId")
        public String creatorId;

        @NameInMap("description")
        public String description;

        @NameInMap("modifiedTime")
        public Long modifiedTime;

        @NameInMap("modifierId")
        public String modifierId;

        @NameInMap("name")
        public String name;

        @NameInMap("templateKey")
        public String templateKey;

        public static GetTemplateListResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            GetTemplateListResponseBodyData self = new GetTemplateListResponseBodyData();
            return TeaModel.build(map, self);
        }

        public GetTemplateListResponseBodyData setActions(java.util.List<GetTemplateListResponseBodyDataActions> actions) {
            this.actions = actions;
            return this;
        }
        public java.util.List<GetTemplateListResponseBodyDataActions> getActions() {
            return this.actions;
        }

        public GetTemplateListResponseBodyData setCreateTime(Long createTime) {
            this.createTime = createTime;
            return this;
        }
        public Long getCreateTime() {
            return this.createTime;
        }

        public GetTemplateListResponseBodyData setCreatorId(String creatorId) {
            this.creatorId = creatorId;
            return this;
        }
        public String getCreatorId() {
            return this.creatorId;
        }

        public GetTemplateListResponseBodyData setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public GetTemplateListResponseBodyData setModifiedTime(Long modifiedTime) {
            this.modifiedTime = modifiedTime;
            return this;
        }
        public Long getModifiedTime() {
            return this.modifiedTime;
        }

        public GetTemplateListResponseBodyData setModifierId(String modifierId) {
            this.modifierId = modifierId;
            return this;
        }
        public String getModifierId() {
            return this.modifierId;
        }

        public GetTemplateListResponseBodyData setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetTemplateListResponseBodyData setTemplateKey(String templateKey) {
            this.templateKey = templateKey;
            return this;
        }
        public String getTemplateKey() {
            return this.templateKey;
        }

    }

}
