// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class GetInstancesByIdsResponseBody extends TeaModel {
    @NameInMap("customFormInstanceResponseList")
    public java.util.List<GetInstancesByIdsResponseBodyCustomFormInstanceResponseList> customFormInstanceResponseList;

    public static GetInstancesByIdsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetInstancesByIdsResponseBody self = new GetInstancesByIdsResponseBody();
        return TeaModel.build(map, self);
    }

    public GetInstancesByIdsResponseBody setCustomFormInstanceResponseList(java.util.List<GetInstancesByIdsResponseBodyCustomFormInstanceResponseList> customFormInstanceResponseList) {
        this.customFormInstanceResponseList = customFormInstanceResponseList;
        return this;
    }
    public java.util.List<GetInstancesByIdsResponseBodyCustomFormInstanceResponseList> getCustomFormInstanceResponseList() {
        return this.customFormInstanceResponseList;
    }

    public static class GetInstancesByIdsResponseBodyCustomFormInstanceResponseList extends TeaModel {
        @NameInMap("creatorUnionId")
        public String creatorUnionId;

        @NameInMap("fields")
        public String fields;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("formCode")
        public String formCode;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("gmtCreate")
        public String gmtCreate;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("gmtModified")
        public String gmtModified;

        @NameInMap("modifiedUnionId")
        public String modifiedUnionId;

        @NameInMap("openDataInstanceId")
        public String openDataInstanceId;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("openTeamId")
        public String openTeamId;

        @NameInMap("ownerUnionId")
        public String ownerUnionId;

        public static GetInstancesByIdsResponseBodyCustomFormInstanceResponseList build(java.util.Map<String, ?> map) throws Exception {
            GetInstancesByIdsResponseBodyCustomFormInstanceResponseList self = new GetInstancesByIdsResponseBodyCustomFormInstanceResponseList();
            return TeaModel.build(map, self);
        }

        public GetInstancesByIdsResponseBodyCustomFormInstanceResponseList setCreatorUnionId(String creatorUnionId) {
            this.creatorUnionId = creatorUnionId;
            return this;
        }
        public String getCreatorUnionId() {
            return this.creatorUnionId;
        }

        public GetInstancesByIdsResponseBodyCustomFormInstanceResponseList setFields(String fields) {
            this.fields = fields;
            return this;
        }
        public String getFields() {
            return this.fields;
        }

        public GetInstancesByIdsResponseBodyCustomFormInstanceResponseList setFormCode(String formCode) {
            this.formCode = formCode;
            return this;
        }
        public String getFormCode() {
            return this.formCode;
        }

        public GetInstancesByIdsResponseBodyCustomFormInstanceResponseList setGmtCreate(String gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public String getGmtCreate() {
            return this.gmtCreate;
        }

        public GetInstancesByIdsResponseBodyCustomFormInstanceResponseList setGmtModified(String gmtModified) {
            this.gmtModified = gmtModified;
            return this;
        }
        public String getGmtModified() {
            return this.gmtModified;
        }

        public GetInstancesByIdsResponseBodyCustomFormInstanceResponseList setModifiedUnionId(String modifiedUnionId) {
            this.modifiedUnionId = modifiedUnionId;
            return this;
        }
        public String getModifiedUnionId() {
            return this.modifiedUnionId;
        }

        public GetInstancesByIdsResponseBodyCustomFormInstanceResponseList setOpenDataInstanceId(String openDataInstanceId) {
            this.openDataInstanceId = openDataInstanceId;
            return this;
        }
        public String getOpenDataInstanceId() {
            return this.openDataInstanceId;
        }

        public GetInstancesByIdsResponseBodyCustomFormInstanceResponseList setOpenTeamId(String openTeamId) {
            this.openTeamId = openTeamId;
            return this;
        }
        public String getOpenTeamId() {
            return this.openTeamId;
        }

        public GetInstancesByIdsResponseBodyCustomFormInstanceResponseList setOwnerUnionId(String ownerUnionId) {
            this.ownerUnionId = ownerUnionId;
            return this;
        }
        public String getOwnerUnionId() {
            return this.ownerUnionId;
        }

    }

}
