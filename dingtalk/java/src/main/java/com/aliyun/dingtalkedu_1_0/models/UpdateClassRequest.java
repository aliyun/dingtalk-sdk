// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class UpdateClassRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>23424324324</p>
     */
    @NameInMap("deptId")
    public Long deptId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("gradeLevel")
    public Integer gradeLevel;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("openClass")
    public UpdateClassRequestOpenClass openClass;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>manager234234</p>
     */
    @NameInMap("operator")
    public String operator;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>23423423</p>
     */
    @NameInMap("superId")
    public Long superId;

    public static UpdateClassRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateClassRequest self = new UpdateClassRequest();
        return TeaModel.build(map, self);
    }

    public UpdateClassRequest setDeptId(Long deptId) {
        this.deptId = deptId;
        return this;
    }
    public Long getDeptId() {
        return this.deptId;
    }

    public UpdateClassRequest setGradeLevel(Integer gradeLevel) {
        this.gradeLevel = gradeLevel;
        return this;
    }
    public Integer getGradeLevel() {
        return this.gradeLevel;
    }

    public UpdateClassRequest setOpenClass(UpdateClassRequestOpenClass openClass) {
        this.openClass = openClass;
        return this;
    }
    public UpdateClassRequestOpenClass getOpenClass() {
        return this.openClass;
    }

    public UpdateClassRequest setOperator(String operator) {
        this.operator = operator;
        return this;
    }
    public String getOperator() {
        return this.operator;
    }

    public UpdateClassRequest setSuperId(Long superId) {
        this.superId = superId;
        return this;
    }
    public Long getSuperId() {
        return this.superId;
    }

    public static class UpdateClassRequestOpenClass extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("classLevel")
        public Integer classLevel;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>熊猫班</p>
         */
        @NameInMap("nick")
        public String nick;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>true</p>
         */
        @NameInMap("onlyUseNick")
        public String onlyUseNick;

        public static UpdateClassRequestOpenClass build(java.util.Map<String, ?> map) throws Exception {
            UpdateClassRequestOpenClass self = new UpdateClassRequestOpenClass();
            return TeaModel.build(map, self);
        }

        public UpdateClassRequestOpenClass setClassLevel(Integer classLevel) {
            this.classLevel = classLevel;
            return this;
        }
        public Integer getClassLevel() {
            return this.classLevel;
        }

        public UpdateClassRequestOpenClass setNick(String nick) {
            this.nick = nick;
            return this;
        }
        public String getNick() {
            return this.nick;
        }

        public UpdateClassRequestOpenClass setOnlyUseNick(String onlyUseNick) {
            this.onlyUseNick = onlyUseNick;
            return this;
        }
        public String getOnlyUseNick() {
            return this.onlyUseNick;
        }

    }

}
