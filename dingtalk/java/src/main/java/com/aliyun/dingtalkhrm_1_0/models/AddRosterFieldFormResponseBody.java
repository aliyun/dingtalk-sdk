// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class AddRosterFieldFormResponseBody extends TeaModel {
    @NameInMap("dingOpenErrcode")
    public Integer dingOpenErrcode;

    @NameInMap("errorMsg")
    public String errorMsg;

    @NameInMap("result")
    public AddRosterFieldFormResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static AddRosterFieldFormResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AddRosterFieldFormResponseBody self = new AddRosterFieldFormResponseBody();
        return TeaModel.build(map, self);
    }

    public AddRosterFieldFormResponseBody setDingOpenErrcode(Integer dingOpenErrcode) {
        this.dingOpenErrcode = dingOpenErrcode;
        return this;
    }
    public Integer getDingOpenErrcode() {
        return this.dingOpenErrcode;
    }

    public AddRosterFieldFormResponseBody setErrorMsg(String errorMsg) {
        this.errorMsg = errorMsg;
        return this;
    }
    public String getErrorMsg() {
        return this.errorMsg;
    }

    public AddRosterFieldFormResponseBody setResult(AddRosterFieldFormResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public AddRosterFieldFormResponseBodyResult getResult() {
        return this.result;
    }

    public AddRosterFieldFormResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class AddRosterFieldFormResponseBodyResult extends TeaModel {
        @NameInMap("bizGroupId")
        public Long bizGroupId;

        @NameInMap("content")
        public String content;

        @NameInMap("corpId")
        public String corpId;

        @NameInMap("deleteFlag")
        public String deleteFlag;

        @NameInMap("detail")
        public Boolean detail;

        @NameInMap("formId")
        public String formId;

        @NameInMap("gmtCreate")
        public Object gmtCreate;

        @NameInMap("gmtModified")
        public Object gmtModified;

        @NameInMap("icon")
        public String icon;

        @NameInMap("id")
        public Long id;

        @NameInMap("memo")
        public String memo;

        @NameInMap("name")
        public String name;

        @NameInMap("sortOrder")
        public Integer sortOrder;

        @NameInMap("versionId")
        public Integer versionId;

        public static AddRosterFieldFormResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            AddRosterFieldFormResponseBodyResult self = new AddRosterFieldFormResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public AddRosterFieldFormResponseBodyResult setBizGroupId(Long bizGroupId) {
            this.bizGroupId = bizGroupId;
            return this;
        }
        public Long getBizGroupId() {
            return this.bizGroupId;
        }

        public AddRosterFieldFormResponseBodyResult setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

        public AddRosterFieldFormResponseBodyResult setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public AddRosterFieldFormResponseBodyResult setDeleteFlag(String deleteFlag) {
            this.deleteFlag = deleteFlag;
            return this;
        }
        public String getDeleteFlag() {
            return this.deleteFlag;
        }

        public AddRosterFieldFormResponseBodyResult setDetail(Boolean detail) {
            this.detail = detail;
            return this;
        }
        public Boolean getDetail() {
            return this.detail;
        }

        public AddRosterFieldFormResponseBodyResult setFormId(String formId) {
            this.formId = formId;
            return this;
        }
        public String getFormId() {
            return this.formId;
        }

        public AddRosterFieldFormResponseBodyResult setGmtCreate(Object gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public Object getGmtCreate() {
            return this.gmtCreate;
        }

        public AddRosterFieldFormResponseBodyResult setGmtModified(Object gmtModified) {
            this.gmtModified = gmtModified;
            return this;
        }
        public Object getGmtModified() {
            return this.gmtModified;
        }

        public AddRosterFieldFormResponseBodyResult setIcon(String icon) {
            this.icon = icon;
            return this;
        }
        public String getIcon() {
            return this.icon;
        }

        public AddRosterFieldFormResponseBodyResult setId(Long id) {
            this.id = id;
            return this;
        }
        public Long getId() {
            return this.id;
        }

        public AddRosterFieldFormResponseBodyResult setMemo(String memo) {
            this.memo = memo;
            return this;
        }
        public String getMemo() {
            return this.memo;
        }

        public AddRosterFieldFormResponseBodyResult setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public AddRosterFieldFormResponseBodyResult setSortOrder(Integer sortOrder) {
            this.sortOrder = sortOrder;
            return this;
        }
        public Integer getSortOrder() {
            return this.sortOrder;
        }

        public AddRosterFieldFormResponseBodyResult setVersionId(Integer versionId) {
            this.versionId = versionId;
            return this;
        }
        public Integer getVersionId() {
            return this.versionId;
        }

    }

}
