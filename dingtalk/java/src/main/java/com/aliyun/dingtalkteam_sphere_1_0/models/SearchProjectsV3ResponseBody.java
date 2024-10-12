// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkteam_sphere_1_0.models;

import com.aliyun.tea.*;

public class SearchProjectsV3ResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>f279e812-e431-428d-846d-cxxxxxx</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("requestId")
    public String requestId;

    @NameInMap("result")
    public java.util.List<SearchProjectsV3ResponseBodyResult> result;

    public static SearchProjectsV3ResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SearchProjectsV3ResponseBody self = new SearchProjectsV3ResponseBody();
        return TeaModel.build(map, self);
    }

    public SearchProjectsV3ResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public SearchProjectsV3ResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public SearchProjectsV3ResponseBody setResult(java.util.List<SearchProjectsV3ResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<SearchProjectsV3ResponseBodyResult> getResult() {
        return this.result;
    }

    public static class SearchProjectsV3ResponseBodyResultCustomfieldsValue extends TeaModel {
        @NameInMap("id")
        public String id;

        @NameInMap("metaString")
        public String metaString;

        @NameInMap("title")
        public String title;

        public static SearchProjectsV3ResponseBodyResultCustomfieldsValue build(java.util.Map<String, ?> map) throws Exception {
            SearchProjectsV3ResponseBodyResultCustomfieldsValue self = new SearchProjectsV3ResponseBodyResultCustomfieldsValue();
            return TeaModel.build(map, self);
        }

        public SearchProjectsV3ResponseBodyResultCustomfieldsValue setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public SearchProjectsV3ResponseBodyResultCustomfieldsValue setMetaString(String metaString) {
            this.metaString = metaString;
            return this;
        }
        public String getMetaString() {
            return this.metaString;
        }

        public SearchProjectsV3ResponseBodyResultCustomfieldsValue setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

    public static class SearchProjectsV3ResponseBodyResultCustomfields extends TeaModel {
        @NameInMap("customfieldId")
        public String customfieldId;

        @NameInMap("type")
        public String type;

        @NameInMap("value")
        public java.util.List<SearchProjectsV3ResponseBodyResultCustomfieldsValue> value;

        public static SearchProjectsV3ResponseBodyResultCustomfields build(java.util.Map<String, ?> map) throws Exception {
            SearchProjectsV3ResponseBodyResultCustomfields self = new SearchProjectsV3ResponseBodyResultCustomfields();
            return TeaModel.build(map, self);
        }

        public SearchProjectsV3ResponseBodyResultCustomfields setCustomfieldId(String customfieldId) {
            this.customfieldId = customfieldId;
            return this;
        }
        public String getCustomfieldId() {
            return this.customfieldId;
        }

        public SearchProjectsV3ResponseBodyResultCustomfields setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public SearchProjectsV3ResponseBodyResultCustomfields setValue(java.util.List<SearchProjectsV3ResponseBodyResultCustomfieldsValue> value) {
            this.value = value;
            return this;
        }
        public java.util.List<SearchProjectsV3ResponseBodyResultCustomfieldsValue> getValue() {
            return this.value;
        }

    }

    public static class SearchProjectsV3ResponseBodyResult extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>2022-07-04T03:29:34.770Z</p>
         */
        @NameInMap("created")
        public String created;

        @NameInMap("creatorId")
        public String creatorId;

        @NameInMap("customfields")
        public java.util.List<SearchProjectsV3ResponseBodyResultCustomfields> customfields;

        @NameInMap("description")
        public String description;

        /**
         * <strong>example:</strong>
         * <p>2022-07-04T03:29:34.770Z</p>
         */
        @NameInMap("endDate")
        public String endDate;

        @NameInMap("id")
        public String id;

        @NameInMap("isArchived")
        public Boolean isArchived;

        @NameInMap("isSuspended")
        public Boolean isSuspended;

        @NameInMap("isTemplate")
        public Boolean isTemplate;

        @NameInMap("logo")
        public String logo;

        @NameInMap("name")
        public String name;

        @NameInMap("organizationId")
        public String organizationId;

        @NameInMap("sourceId")
        public String sourceId;

        /**
         * <strong>example:</strong>
         * <p>2022-07-04T03:29:34.770Z</p>
         */
        @NameInMap("startDate")
        public String startDate;

        @NameInMap("uniqueIdPrefix")
        public String uniqueIdPrefix;

        /**
         * <strong>example:</strong>
         * <p>2022-07-04T03:29:34.770Z</p>
         */
        @NameInMap("updated")
        public String updated;

        @NameInMap("visibility")
        public String visibility;

        public static SearchProjectsV3ResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            SearchProjectsV3ResponseBodyResult self = new SearchProjectsV3ResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public SearchProjectsV3ResponseBodyResult setCreated(String created) {
            this.created = created;
            return this;
        }
        public String getCreated() {
            return this.created;
        }

        public SearchProjectsV3ResponseBodyResult setCreatorId(String creatorId) {
            this.creatorId = creatorId;
            return this;
        }
        public String getCreatorId() {
            return this.creatorId;
        }

        public SearchProjectsV3ResponseBodyResult setCustomfields(java.util.List<SearchProjectsV3ResponseBodyResultCustomfields> customfields) {
            this.customfields = customfields;
            return this;
        }
        public java.util.List<SearchProjectsV3ResponseBodyResultCustomfields> getCustomfields() {
            return this.customfields;
        }

        public SearchProjectsV3ResponseBodyResult setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public SearchProjectsV3ResponseBodyResult setEndDate(String endDate) {
            this.endDate = endDate;
            return this;
        }
        public String getEndDate() {
            return this.endDate;
        }

        public SearchProjectsV3ResponseBodyResult setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public SearchProjectsV3ResponseBodyResult setIsArchived(Boolean isArchived) {
            this.isArchived = isArchived;
            return this;
        }
        public Boolean getIsArchived() {
            return this.isArchived;
        }

        public SearchProjectsV3ResponseBodyResult setIsSuspended(Boolean isSuspended) {
            this.isSuspended = isSuspended;
            return this;
        }
        public Boolean getIsSuspended() {
            return this.isSuspended;
        }

        public SearchProjectsV3ResponseBodyResult setIsTemplate(Boolean isTemplate) {
            this.isTemplate = isTemplate;
            return this;
        }
        public Boolean getIsTemplate() {
            return this.isTemplate;
        }

        public SearchProjectsV3ResponseBodyResult setLogo(String logo) {
            this.logo = logo;
            return this;
        }
        public String getLogo() {
            return this.logo;
        }

        public SearchProjectsV3ResponseBodyResult setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public SearchProjectsV3ResponseBodyResult setOrganizationId(String organizationId) {
            this.organizationId = organizationId;
            return this;
        }
        public String getOrganizationId() {
            return this.organizationId;
        }

        public SearchProjectsV3ResponseBodyResult setSourceId(String sourceId) {
            this.sourceId = sourceId;
            return this;
        }
        public String getSourceId() {
            return this.sourceId;
        }

        public SearchProjectsV3ResponseBodyResult setStartDate(String startDate) {
            this.startDate = startDate;
            return this;
        }
        public String getStartDate() {
            return this.startDate;
        }

        public SearchProjectsV3ResponseBodyResult setUniqueIdPrefix(String uniqueIdPrefix) {
            this.uniqueIdPrefix = uniqueIdPrefix;
            return this;
        }
        public String getUniqueIdPrefix() {
            return this.uniqueIdPrefix;
        }

        public SearchProjectsV3ResponseBodyResult setUpdated(String updated) {
            this.updated = updated;
            return this;
        }
        public String getUpdated() {
            return this.updated;
        }

        public SearchProjectsV3ResponseBodyResult setVisibility(String visibility) {
            this.visibility = visibility;
            return this;
        }
        public String getVisibility() {
            return this.visibility;
        }

    }

}
