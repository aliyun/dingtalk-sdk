// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class SetBorderRequest extends TeaModel {
    @NameInMap("color")
    public String color;

    @NameInMap("style")
    public String style;

    @NameInMap("type")
    public SetBorderRequestType type;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>ppgAQuHfOoNVpJiStDwWCEgiEiE</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    public static SetBorderRequest build(java.util.Map<String, ?> map) throws Exception {
        SetBorderRequest self = new SetBorderRequest();
        return TeaModel.build(map, self);
    }

    public SetBorderRequest setColor(String color) {
        this.color = color;
        return this;
    }
    public String getColor() {
        return this.color;
    }

    public SetBorderRequest setStyle(String style) {
        this.style = style;
        return this;
    }
    public String getStyle() {
        return this.style;
    }

    public SetBorderRequest setType(SetBorderRequestType type) {
        this.type = type;
        return this;
    }
    public SetBorderRequestType getType() {
        return this.type;
    }

    public SetBorderRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public static class SetBorderRequestType extends TeaModel {
        @NameInMap("bottom")
        public Boolean bottom;

        @NameInMap("horizontal")
        public Boolean horizontal;

        @NameInMap("left")
        public Boolean left;

        @NameInMap("right")
        public Boolean right;

        @NameInMap("top")
        public Boolean top;

        @NameInMap("vertical")
        public Boolean vertical;

        public static SetBorderRequestType build(java.util.Map<String, ?> map) throws Exception {
            SetBorderRequestType self = new SetBorderRequestType();
            return TeaModel.build(map, self);
        }

        public SetBorderRequestType setBottom(Boolean bottom) {
            this.bottom = bottom;
            return this;
        }
        public Boolean getBottom() {
            return this.bottom;
        }

        public SetBorderRequestType setHorizontal(Boolean horizontal) {
            this.horizontal = horizontal;
            return this;
        }
        public Boolean getHorizontal() {
            return this.horizontal;
        }

        public SetBorderRequestType setLeft(Boolean left) {
            this.left = left;
            return this;
        }
        public Boolean getLeft() {
            return this.left;
        }

        public SetBorderRequestType setRight(Boolean right) {
            this.right = right;
            return this;
        }
        public Boolean getRight() {
            return this.right;
        }

        public SetBorderRequestType setTop(Boolean top) {
            this.top = top;
            return this;
        }
        public Boolean getTop() {
            return this.top;
        }

        public SetBorderRequestType setVertical(Boolean vertical) {
            this.vertical = vertical;
            return this;
        }
        public Boolean getVertical() {
            return this.vertical;
        }

    }

}
