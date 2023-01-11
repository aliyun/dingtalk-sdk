// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetFormDataByIDResponseBody extends TeaModel {
    /**
     * <p>表单数据详情</p>
     */
    @NameInMap("formData")
    public java.util.Map<String, ?> formData;

    /**
     * <p>表单实例ID</p>
     */
    @NameInMap("formInstId")
    public String formInstId;

    /**
     * <p>表单ID</p>
     */
    @NameInMap("formUuid")
    public String formUuid;

    /**
     * <p>最后修改时间</p>
     */
    @NameInMap("modifiedTimeGMT")
    public String modifiedTimeGMT;

    /**
     * <p>发起人详情</p>
     */
    @NameInMap("originator")
    public GetFormDataByIDResponseBodyOriginator originator;

    public static GetFormDataByIDResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetFormDataByIDResponseBody self = new GetFormDataByIDResponseBody();
        return TeaModel.build(map, self);
    }

    public GetFormDataByIDResponseBody setFormData(java.util.Map<String, ?> formData) {
        this.formData = formData;
        return this;
    }
    public java.util.Map<String, ?> getFormData() {
        return this.formData;
    }

    public GetFormDataByIDResponseBody setFormInstId(String formInstId) {
        this.formInstId = formInstId;
        return this;
    }
    public String getFormInstId() {
        return this.formInstId;
    }

    public GetFormDataByIDResponseBody setFormUuid(String formUuid) {
        this.formUuid = formUuid;
        return this;
    }
    public String getFormUuid() {
        return this.formUuid;
    }

    public GetFormDataByIDResponseBody setModifiedTimeGMT(String modifiedTimeGMT) {
        this.modifiedTimeGMT = modifiedTimeGMT;
        return this;
    }
    public String getModifiedTimeGMT() {
        return this.modifiedTimeGMT;
    }

    public GetFormDataByIDResponseBody setOriginator(GetFormDataByIDResponseBodyOriginator originator) {
        this.originator = originator;
        return this;
    }
    public GetFormDataByIDResponseBodyOriginator getOriginator() {
        return this.originator;
    }

    public static class GetFormDataByIDResponseBodyOriginatorName extends TeaModel {
        /**
         * <p>中文名称</p>
         */
        @NameInMap("nameInChinese")
        public String nameInChinese;

        /**
         * <p>英文名称</p>
         */
        @NameInMap("nameInEnglish")
        public String nameInEnglish;

        /**
         * <p>国际化</p>
         */
        @NameInMap("type")
        public String type;

        public static GetFormDataByIDResponseBodyOriginatorName build(java.util.Map<String, ?> map) throws Exception {
            GetFormDataByIDResponseBodyOriginatorName self = new GetFormDataByIDResponseBodyOriginatorName();
            return TeaModel.build(map, self);
        }

        public GetFormDataByIDResponseBodyOriginatorName setNameInChinese(String nameInChinese) {
            this.nameInChinese = nameInChinese;
            return this;
        }
        public String getNameInChinese() {
            return this.nameInChinese;
        }

        public GetFormDataByIDResponseBodyOriginatorName setNameInEnglish(String nameInEnglish) {
            this.nameInEnglish = nameInEnglish;
            return this;
        }
        public String getNameInEnglish() {
            return this.nameInEnglish;
        }

        public GetFormDataByIDResponseBodyOriginatorName setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class GetFormDataByIDResponseBodyOriginator extends TeaModel {
        /**
         * <p>部门名称</p>
         */
        @NameInMap("departmentName")
        public String departmentName;

        /**
         * <p>邮箱</p>
         */
        @NameInMap("email")
        public String email;

        /**
         * <p>用户名</p>
         */
        @NameInMap("name")
        public GetFormDataByIDResponseBodyOriginatorName name;

        /**
         * <p>用户工号</p>
         */
        @NameInMap("userId")
        public String userId;

        public static GetFormDataByIDResponseBodyOriginator build(java.util.Map<String, ?> map) throws Exception {
            GetFormDataByIDResponseBodyOriginator self = new GetFormDataByIDResponseBodyOriginator();
            return TeaModel.build(map, self);
        }

        public GetFormDataByIDResponseBodyOriginator setDepartmentName(String departmentName) {
            this.departmentName = departmentName;
            return this;
        }
        public String getDepartmentName() {
            return this.departmentName;
        }

        public GetFormDataByIDResponseBodyOriginator setEmail(String email) {
            this.email = email;
            return this;
        }
        public String getEmail() {
            return this.email;
        }

        public GetFormDataByIDResponseBodyOriginator setName(GetFormDataByIDResponseBodyOriginatorName name) {
            this.name = name;
            return this;
        }
        public GetFormDataByIDResponseBodyOriginatorName getName() {
            return this.name;
        }

        public GetFormDataByIDResponseBodyOriginator setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
