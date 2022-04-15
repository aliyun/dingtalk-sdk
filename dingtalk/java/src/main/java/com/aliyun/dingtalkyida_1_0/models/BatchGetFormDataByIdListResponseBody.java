// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class BatchGetFormDataByIdListResponseBody extends TeaModel {
    // 表单实例数据
    @NameInMap("result")
    public java.util.List<BatchGetFormDataByIdListResponseBodyResult> result;

    public static BatchGetFormDataByIdListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        BatchGetFormDataByIdListResponseBody self = new BatchGetFormDataByIdListResponseBody();
        return TeaModel.build(map, self);
    }

    public BatchGetFormDataByIdListResponseBody setResult(java.util.List<BatchGetFormDataByIdListResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<BatchGetFormDataByIdListResponseBodyResult> getResult() {
        return this.result;
    }

    public static class BatchGetFormDataByIdListResponseBodyResultModifyUserName extends TeaModel {
        // 中文名称
        @NameInMap("nameInChinese")
        public String nameInChinese;

        // 英文名称
        @NameInMap("nameInEnglish")
        public String nameInEnglish;

        public static BatchGetFormDataByIdListResponseBodyResultModifyUserName build(java.util.Map<String, ?> map) throws Exception {
            BatchGetFormDataByIdListResponseBodyResultModifyUserName self = new BatchGetFormDataByIdListResponseBodyResultModifyUserName();
            return TeaModel.build(map, self);
        }

        public BatchGetFormDataByIdListResponseBodyResultModifyUserName setNameInChinese(String nameInChinese) {
            this.nameInChinese = nameInChinese;
            return this;
        }
        public String getNameInChinese() {
            return this.nameInChinese;
        }

        public BatchGetFormDataByIdListResponseBodyResultModifyUserName setNameInEnglish(String nameInEnglish) {
            this.nameInEnglish = nameInEnglish;
            return this;
        }
        public String getNameInEnglish() {
            return this.nameInEnglish;
        }

    }

    public static class BatchGetFormDataByIdListResponseBodyResultModifyUser extends TeaModel {
        // 名称
        @NameInMap("name")
        public BatchGetFormDataByIdListResponseBodyResultModifyUserName name;

        // 钉钉userId
        @NameInMap("userId")
        public String userId;

        public static BatchGetFormDataByIdListResponseBodyResultModifyUser build(java.util.Map<String, ?> map) throws Exception {
            BatchGetFormDataByIdListResponseBodyResultModifyUser self = new BatchGetFormDataByIdListResponseBodyResultModifyUser();
            return TeaModel.build(map, self);
        }

        public BatchGetFormDataByIdListResponseBodyResultModifyUser setName(BatchGetFormDataByIdListResponseBodyResultModifyUserName name) {
            this.name = name;
            return this;
        }
        public BatchGetFormDataByIdListResponseBodyResultModifyUserName getName() {
            return this.name;
        }

        public BatchGetFormDataByIdListResponseBodyResultModifyUser setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class BatchGetFormDataByIdListResponseBodyResultOriginatorName extends TeaModel {
        // 中文名称
        @NameInMap("nameInChinese")
        public String nameInChinese;

        // 英文名称
        @NameInMap("nameInEnglish")
        public String nameInEnglish;

        public static BatchGetFormDataByIdListResponseBodyResultOriginatorName build(java.util.Map<String, ?> map) throws Exception {
            BatchGetFormDataByIdListResponseBodyResultOriginatorName self = new BatchGetFormDataByIdListResponseBodyResultOriginatorName();
            return TeaModel.build(map, self);
        }

        public BatchGetFormDataByIdListResponseBodyResultOriginatorName setNameInChinese(String nameInChinese) {
            this.nameInChinese = nameInChinese;
            return this;
        }
        public String getNameInChinese() {
            return this.nameInChinese;
        }

        public BatchGetFormDataByIdListResponseBodyResultOriginatorName setNameInEnglish(String nameInEnglish) {
            this.nameInEnglish = nameInEnglish;
            return this;
        }
        public String getNameInEnglish() {
            return this.nameInEnglish;
        }

    }

    public static class BatchGetFormDataByIdListResponseBodyResultOriginator extends TeaModel {
        // 名称
        @NameInMap("name")
        public BatchGetFormDataByIdListResponseBodyResultOriginatorName name;

        // 钉钉userId
        @NameInMap("userId")
        public String userId;

        public static BatchGetFormDataByIdListResponseBodyResultOriginator build(java.util.Map<String, ?> map) throws Exception {
            BatchGetFormDataByIdListResponseBodyResultOriginator self = new BatchGetFormDataByIdListResponseBodyResultOriginator();
            return TeaModel.build(map, self);
        }

        public BatchGetFormDataByIdListResponseBodyResultOriginator setName(BatchGetFormDataByIdListResponseBodyResultOriginatorName name) {
            this.name = name;
            return this;
        }
        public BatchGetFormDataByIdListResponseBodyResultOriginatorName getName() {
            return this.name;
        }

        public BatchGetFormDataByIdListResponseBodyResultOriginator setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class BatchGetFormDataByIdListResponseBodyResult extends TeaModel {
        // 创建时间
        @NameInMap("createTimeGMT")
        public String createTimeGMT;

        // 创建者的userId
        @NameInMap("creatorUserId")
        public String creatorUserId;

        // 表单实例数据
        @NameInMap("formData")
        public java.util.Map<String, ?> formData;

        // 表单实例id
        @NameInMap("formInstanceId")
        public String formInstanceId;

        // 表单编码
        @NameInMap("formUuid")
        public String formUuid;

        // 数据库表记录主键id
        @NameInMap("id")
        public Long id;

        // 实例数据
        @NameInMap("instanceValue")
        public String instanceValue;

        // 修改时间
        @NameInMap("modifiedTimeGMT")
        public String modifiedTimeGMT;

        // 修改者的钉钉userId
        @NameInMap("modifier")
        public String modifier;

        // 修改者
        @NameInMap("modifyUser")
        public BatchGetFormDataByIdListResponseBodyResultModifyUser modifyUser;

        // 表单提交人
        @NameInMap("originator")
        public BatchGetFormDataByIdListResponseBodyResultOriginator originator;

        // 该表单实例对应的批量导入的批次号(如果是通过批量导入创建的)
        @NameInMap("sequence")
        public String sequence;

        // 流水号
        @NameInMap("serialNumber")
        public String serialNumber;

        // 标题
        @NameInMap("title")
        public String title;

        // 该表单实例对应的表单schema版本
        @NameInMap("version")
        public Long version;

        public static BatchGetFormDataByIdListResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            BatchGetFormDataByIdListResponseBodyResult self = new BatchGetFormDataByIdListResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public BatchGetFormDataByIdListResponseBodyResult setCreateTimeGMT(String createTimeGMT) {
            this.createTimeGMT = createTimeGMT;
            return this;
        }
        public String getCreateTimeGMT() {
            return this.createTimeGMT;
        }

        public BatchGetFormDataByIdListResponseBodyResult setCreatorUserId(String creatorUserId) {
            this.creatorUserId = creatorUserId;
            return this;
        }
        public String getCreatorUserId() {
            return this.creatorUserId;
        }

        public BatchGetFormDataByIdListResponseBodyResult setFormData(java.util.Map<String, ?> formData) {
            this.formData = formData;
            return this;
        }
        public java.util.Map<String, ?> getFormData() {
            return this.formData;
        }

        public BatchGetFormDataByIdListResponseBodyResult setFormInstanceId(String formInstanceId) {
            this.formInstanceId = formInstanceId;
            return this;
        }
        public String getFormInstanceId() {
            return this.formInstanceId;
        }

        public BatchGetFormDataByIdListResponseBodyResult setFormUuid(String formUuid) {
            this.formUuid = formUuid;
            return this;
        }
        public String getFormUuid() {
            return this.formUuid;
        }

        public BatchGetFormDataByIdListResponseBodyResult setId(Long id) {
            this.id = id;
            return this;
        }
        public Long getId() {
            return this.id;
        }

        public BatchGetFormDataByIdListResponseBodyResult setInstanceValue(String instanceValue) {
            this.instanceValue = instanceValue;
            return this;
        }
        public String getInstanceValue() {
            return this.instanceValue;
        }

        public BatchGetFormDataByIdListResponseBodyResult setModifiedTimeGMT(String modifiedTimeGMT) {
            this.modifiedTimeGMT = modifiedTimeGMT;
            return this;
        }
        public String getModifiedTimeGMT() {
            return this.modifiedTimeGMT;
        }

        public BatchGetFormDataByIdListResponseBodyResult setModifier(String modifier) {
            this.modifier = modifier;
            return this;
        }
        public String getModifier() {
            return this.modifier;
        }

        public BatchGetFormDataByIdListResponseBodyResult setModifyUser(BatchGetFormDataByIdListResponseBodyResultModifyUser modifyUser) {
            this.modifyUser = modifyUser;
            return this;
        }
        public BatchGetFormDataByIdListResponseBodyResultModifyUser getModifyUser() {
            return this.modifyUser;
        }

        public BatchGetFormDataByIdListResponseBodyResult setOriginator(BatchGetFormDataByIdListResponseBodyResultOriginator originator) {
            this.originator = originator;
            return this;
        }
        public BatchGetFormDataByIdListResponseBodyResultOriginator getOriginator() {
            return this.originator;
        }

        public BatchGetFormDataByIdListResponseBodyResult setSequence(String sequence) {
            this.sequence = sequence;
            return this;
        }
        public String getSequence() {
            return this.sequence;
        }

        public BatchGetFormDataByIdListResponseBodyResult setSerialNumber(String serialNumber) {
            this.serialNumber = serialNumber;
            return this;
        }
        public String getSerialNumber() {
            return this.serialNumber;
        }

        public BatchGetFormDataByIdListResponseBodyResult setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public BatchGetFormDataByIdListResponseBodyResult setVersion(Long version) {
            this.version = version;
            return this;
        }
        public Long getVersion() {
            return this.version;
        }

    }

}
