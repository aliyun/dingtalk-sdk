// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class UpdateHrmLegalEntityNameResponseBody extends TeaModel {
    @NameInMap("result")
    public UpdateHrmLegalEntityNameResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static UpdateHrmLegalEntityNameResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateHrmLegalEntityNameResponseBody self = new UpdateHrmLegalEntityNameResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateHrmLegalEntityNameResponseBody setResult(UpdateHrmLegalEntityNameResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public UpdateHrmLegalEntityNameResponseBodyResult getResult() {
        return this.result;
    }

    public UpdateHrmLegalEntityNameResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class UpdateHrmLegalEntityNameResponseBodyResult extends TeaModel {
        @NameInMap("corpId")
        public String corpId;

        @NameInMap("gmtCreate")
        public Long gmtCreate;

        @NameInMap("gmtModified")
        public Long gmtModified;

        @NameInMap("legalEntityId")
        public String legalEntityId;

        @NameInMap("legalEntityName")
        public String legalEntityName;

        @NameInMap("legalEntityShortName")
        public String legalEntityShortName;

        @NameInMap("legalEntityStatus")
        public Integer legalEntityStatus;

        @NameInMap("legalPersonName")
        public String legalPersonName;

        public static UpdateHrmLegalEntityNameResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            UpdateHrmLegalEntityNameResponseBodyResult self = new UpdateHrmLegalEntityNameResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public UpdateHrmLegalEntityNameResponseBodyResult setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public UpdateHrmLegalEntityNameResponseBodyResult setGmtCreate(Long gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public Long getGmtCreate() {
            return this.gmtCreate;
        }

        public UpdateHrmLegalEntityNameResponseBodyResult setGmtModified(Long gmtModified) {
            this.gmtModified = gmtModified;
            return this;
        }
        public Long getGmtModified() {
            return this.gmtModified;
        }

        public UpdateHrmLegalEntityNameResponseBodyResult setLegalEntityId(String legalEntityId) {
            this.legalEntityId = legalEntityId;
            return this;
        }
        public String getLegalEntityId() {
            return this.legalEntityId;
        }

        public UpdateHrmLegalEntityNameResponseBodyResult setLegalEntityName(String legalEntityName) {
            this.legalEntityName = legalEntityName;
            return this;
        }
        public String getLegalEntityName() {
            return this.legalEntityName;
        }

        public UpdateHrmLegalEntityNameResponseBodyResult setLegalEntityShortName(String legalEntityShortName) {
            this.legalEntityShortName = legalEntityShortName;
            return this;
        }
        public String getLegalEntityShortName() {
            return this.legalEntityShortName;
        }

        public UpdateHrmLegalEntityNameResponseBodyResult setLegalEntityStatus(Integer legalEntityStatus) {
            this.legalEntityStatus = legalEntityStatus;
            return this;
        }
        public Integer getLegalEntityStatus() {
            return this.legalEntityStatus;
        }

        public UpdateHrmLegalEntityNameResponseBodyResult setLegalPersonName(String legalPersonName) {
            this.legalPersonName = legalPersonName;
            return this;
        }
        public String getLegalPersonName() {
            return this.legalPersonName;
        }

    }

}
