// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkteam_sphere_1_0.models;

import com.aliyun.tea.*;

public class GetFootprintProjectResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<GetFootprintProjectResponseBodyResult> result;

    public static GetFootprintProjectResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetFootprintProjectResponseBody self = new GetFootprintProjectResponseBody();
        return TeaModel.build(map, self);
    }

    public GetFootprintProjectResponseBody setResult(java.util.List<GetFootprintProjectResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<GetFootprintProjectResponseBodyResult> getResult() {
        return this.result;
    }

    public static class GetFootprintProjectResponseBodyResult extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>2022-07-04T03:29:34.770Z</p>
         */
        @NameInMap("created")
        public String created;

        /**
         * <strong>example:</strong>
         * <p>5f687406f05b283425ea8f6f</p>
         */
        @NameInMap("creatorId")
        public String creatorId;

        /**
         * <strong>example:</strong>
         * <p>xxxx</p>
         */
        @NameInMap("description")
        public String description;

        /**
         * <strong>example:</strong>
         * <p>1234</p>
         */
        @NameInMap("id")
        public String id;

        /**
         * <strong>example:</strong>
         * <p>true</p>
         */
        @NameInMap("isDeleted")
        public Boolean isDeleted;

        /**
         * <strong>example:</strong>
         * <p><a href="https://things.teambition.net?icon_logo=%F0%9F%92%A5">https://things.teambition.net?icon_logo=%F0%9F%92%A5</a></p>
         */
        @NameInMap("logo")
        public String logo;

        /**
         * <strong>example:</strong>
         * <p>x项目</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <strong>example:</strong>
         * <p>6139cd1aba5b128516ec8c86</p>
         */
        @NameInMap("organizationId")
        public String organizationId;

        /**
         * <strong>example:</strong>
         * <p>2022-07-04T03:29:34.770Z</p>
         */
        @NameInMap("updated")
        public String updated;

        /**
         * <strong>example:</strong>
         * <p>project</p>
         */
        @NameInMap("visibility")
        public String visibility;

        public static GetFootprintProjectResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetFootprintProjectResponseBodyResult self = new GetFootprintProjectResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetFootprintProjectResponseBodyResult setCreated(String created) {
            this.created = created;
            return this;
        }
        public String getCreated() {
            return this.created;
        }

        public GetFootprintProjectResponseBodyResult setCreatorId(String creatorId) {
            this.creatorId = creatorId;
            return this;
        }
        public String getCreatorId() {
            return this.creatorId;
        }

        public GetFootprintProjectResponseBodyResult setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public GetFootprintProjectResponseBodyResult setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public GetFootprintProjectResponseBodyResult setIsDeleted(Boolean isDeleted) {
            this.isDeleted = isDeleted;
            return this;
        }
        public Boolean getIsDeleted() {
            return this.isDeleted;
        }

        public GetFootprintProjectResponseBodyResult setLogo(String logo) {
            this.logo = logo;
            return this;
        }
        public String getLogo() {
            return this.logo;
        }

        public GetFootprintProjectResponseBodyResult setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetFootprintProjectResponseBodyResult setOrganizationId(String organizationId) {
            this.organizationId = organizationId;
            return this;
        }
        public String getOrganizationId() {
            return this.organizationId;
        }

        public GetFootprintProjectResponseBodyResult setUpdated(String updated) {
            this.updated = updated;
            return this;
        }
        public String getUpdated() {
            return this.updated;
        }

        public GetFootprintProjectResponseBodyResult setVisibility(String visibility) {
            this.visibility = visibility;
            return this;
        }
        public String getVisibility() {
            return this.visibility;
        }

    }

}
