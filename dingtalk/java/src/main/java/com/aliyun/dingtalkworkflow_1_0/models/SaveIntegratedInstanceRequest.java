// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class SaveIntegratedInstanceRequest extends TeaModel {
    @NameInMap("formComponentValueList")
    public java.util.List<SaveIntegratedInstanceRequestFormComponentValueList> formComponentValueList;

    @NameInMap("notifiers")
    public java.util.List<SaveIntegratedInstanceRequestNotifiers> notifiers;

    /**
     * <p>审批实例接收人的userId。</p>
     */
    @NameInMap("originatorUserId")
    public String originatorUserId;

    /**
     * <p>审批模板唯一码</p>
     */
    @NameInMap("processCode")
    public String processCode;

    /**
     * <p>实例标题</p>
     */
    @NameInMap("title")
    public String title;

    /**
     * <p>三方审批系统中审批单的详情页地址</p>
     */
    @NameInMap("url")
    public String url;

    public static SaveIntegratedInstanceRequest build(java.util.Map<String, ?> map) throws Exception {
        SaveIntegratedInstanceRequest self = new SaveIntegratedInstanceRequest();
        return TeaModel.build(map, self);
    }

    public SaveIntegratedInstanceRequest setFormComponentValueList(java.util.List<SaveIntegratedInstanceRequestFormComponentValueList> formComponentValueList) {
        this.formComponentValueList = formComponentValueList;
        return this;
    }
    public java.util.List<SaveIntegratedInstanceRequestFormComponentValueList> getFormComponentValueList() {
        return this.formComponentValueList;
    }

    public SaveIntegratedInstanceRequest setNotifiers(java.util.List<SaveIntegratedInstanceRequestNotifiers> notifiers) {
        this.notifiers = notifiers;
        return this;
    }
    public java.util.List<SaveIntegratedInstanceRequestNotifiers> getNotifiers() {
        return this.notifiers;
    }

    public SaveIntegratedInstanceRequest setOriginatorUserId(String originatorUserId) {
        this.originatorUserId = originatorUserId;
        return this;
    }
    public String getOriginatorUserId() {
        return this.originatorUserId;
    }

    public SaveIntegratedInstanceRequest setProcessCode(String processCode) {
        this.processCode = processCode;
        return this;
    }
    public String getProcessCode() {
        return this.processCode;
    }

    public SaveIntegratedInstanceRequest setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public SaveIntegratedInstanceRequest setUrl(String url) {
        this.url = url;
        return this;
    }
    public String getUrl() {
        return this.url;
    }

    public static class SaveIntegratedInstanceRequestFormComponentValueList extends TeaModel {
        /**
         * <p>控件别名</p>
         */
        @NameInMap("bizAlias")
        public String bizAlias;

        /**
         * <p>控件类型，取值：</p>
         * <br>
         * <p>TextField：单行输入框</p>
         * <br>
         * <p>TextareaField：多行输入框</p>
         * <br>
         * <p>NumberField：数字输入框</p>
         * <br>
         * <p>DDSelectField：单选框</p>
         * <br>
         * <p>DDMultiSelectField：多选框</p>
         * <br>
         * <p>DDDateField：日期控件</p>
         * <br>
         * <p>DDDateRangeField：时间区间控件</p>
         * <br>
         * <p>TextNote：文字说明控件</p>
         * <br>
         * <p>PhoneField：电话控件</p>
         * <br>
         * <p>DDPhotoField：图片控件</p>
         * <br>
         * <p>MoneyField：金额控件</p>
         * <br>
         * <p>TableField：明细控件</p>
         * <br>
         * <p>DDAttachment：附件</p>
         * <br>
         * <p>InnerContactField：联系人控件</p>
         * <br>
         * <p>RelateField：关联审批单</p>
         * <br>
         * <p>FormRelateField：关联控件</p>
         * <br>
         * <p>AddressField：省市区控件</p>
         * <br>
         * <p>StarRatingField：评分控件</p>
         * <br>
         * <p>DepartmentField：部门控件</p>
         */
        @NameInMap("componentType")
        public String componentType;

        /**
         * <p>表单扩展值</p>
         */
        @NameInMap("extValue")
        public String extValue;

        /**
         * <p>控件id</p>
         */
        @NameInMap("id")
        public String id;

        /**
         * <p>表单名称</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>表单值</p>
         */
        @NameInMap("value")
        public String value;

        public static SaveIntegratedInstanceRequestFormComponentValueList build(java.util.Map<String, ?> map) throws Exception {
            SaveIntegratedInstanceRequestFormComponentValueList self = new SaveIntegratedInstanceRequestFormComponentValueList();
            return TeaModel.build(map, self);
        }

        public SaveIntegratedInstanceRequestFormComponentValueList setBizAlias(String bizAlias) {
            this.bizAlias = bizAlias;
            return this;
        }
        public String getBizAlias() {
            return this.bizAlias;
        }

        public SaveIntegratedInstanceRequestFormComponentValueList setComponentType(String componentType) {
            this.componentType = componentType;
            return this;
        }
        public String getComponentType() {
            return this.componentType;
        }

        public SaveIntegratedInstanceRequestFormComponentValueList setExtValue(String extValue) {
            this.extValue = extValue;
            return this;
        }
        public String getExtValue() {
            return this.extValue;
        }

        public SaveIntegratedInstanceRequestFormComponentValueList setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public SaveIntegratedInstanceRequestFormComponentValueList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public SaveIntegratedInstanceRequestFormComponentValueList setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class SaveIntegratedInstanceRequestNotifiers extends TeaModel {
        /**
         * <p>抄送位置，可以值有：</p>
         * <p>start - 审批发起时，通知抄送人</p>
         * <p>finish - 审批通过后，通知抄送人</p>
         * <p>start_finish - 审批发起时和审批通过后，都通知抄送人</p>
         */
        @NameInMap("position")
        public String position;

        /**
         * <p>抄送接收人用户ID</p>
         */
        @NameInMap("userid")
        public String userid;

        public static SaveIntegratedInstanceRequestNotifiers build(java.util.Map<String, ?> map) throws Exception {
            SaveIntegratedInstanceRequestNotifiers self = new SaveIntegratedInstanceRequestNotifiers();
            return TeaModel.build(map, self);
        }

        public SaveIntegratedInstanceRequestNotifiers setPosition(String position) {
            this.position = position;
            return this;
        }
        public String getPosition() {
            return this.position;
        }

        public SaveIntegratedInstanceRequestNotifiers setUserid(String userid) {
            this.userid = userid;
            return this;
        }
        public String getUserid() {
            return this.userid;
        }

    }

}
