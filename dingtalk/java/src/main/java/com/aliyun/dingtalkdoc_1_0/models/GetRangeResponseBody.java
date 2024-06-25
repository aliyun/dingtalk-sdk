// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class GetRangeResponseBody extends TeaModel {
    @NameInMap("backgroundColors")
    public java.util.List<java.util.List<GetRangeResponseBodyBackgroundColors>> backgroundColors;

    @NameInMap("displayValues")
    public java.util.List<java.util.List<String>> displayValues;

    @NameInMap("fontSizes")
    public java.util.List<java.util.List<Integer>> fontSizes;

    @NameInMap("fontWeights")
    public java.util.List<java.util.List<String>> fontWeights;

    @NameInMap("formulas")
    public java.util.List<java.util.List<String>> formulas;

    @NameInMap("horizontalAlignments")
    public java.util.List<java.util.List<String>> horizontalAlignments;

    @NameInMap("values")
    public java.util.List<java.util.List<?>> values;

    @NameInMap("verticalAlignments")
    public java.util.List<java.util.List<String>> verticalAlignments;

    public static GetRangeResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetRangeResponseBody self = new GetRangeResponseBody();
        return TeaModel.build(map, self);
    }

    public GetRangeResponseBody setBackgroundColors(java.util.List<java.util.List<GetRangeResponseBodyBackgroundColors>> backgroundColors) {
        this.backgroundColors = backgroundColors;
        return this;
    }
    public java.util.List<java.util.List<GetRangeResponseBodyBackgroundColors>> getBackgroundColors() {
        return this.backgroundColors;
    }

    public GetRangeResponseBody setDisplayValues(java.util.List<java.util.List<String>> displayValues) {
        this.displayValues = displayValues;
        return this;
    }
    public java.util.List<java.util.List<String>> getDisplayValues() {
        return this.displayValues;
    }

    public GetRangeResponseBody setFontSizes(java.util.List<java.util.List<Integer>> fontSizes) {
        this.fontSizes = fontSizes;
        return this;
    }
    public java.util.List<java.util.List<Integer>> getFontSizes() {
        return this.fontSizes;
    }

    public GetRangeResponseBody setFontWeights(java.util.List<java.util.List<String>> fontWeights) {
        this.fontWeights = fontWeights;
        return this;
    }
    public java.util.List<java.util.List<String>> getFontWeights() {
        return this.fontWeights;
    }

    public GetRangeResponseBody setFormulas(java.util.List<java.util.List<String>> formulas) {
        this.formulas = formulas;
        return this;
    }
    public java.util.List<java.util.List<String>> getFormulas() {
        return this.formulas;
    }

    public GetRangeResponseBody setHorizontalAlignments(java.util.List<java.util.List<String>> horizontalAlignments) {
        this.horizontalAlignments = horizontalAlignments;
        return this;
    }
    public java.util.List<java.util.List<String>> getHorizontalAlignments() {
        return this.horizontalAlignments;
    }

    public GetRangeResponseBody setValues(java.util.List<java.util.List<?>> values) {
        this.values = values;
        return this;
    }
    public java.util.List<java.util.List<?>> getValues() {
        return this.values;
    }

    public GetRangeResponseBody setVerticalAlignments(java.util.List<java.util.List<String>> verticalAlignments) {
        this.verticalAlignments = verticalAlignments;
        return this;
    }
    public java.util.List<java.util.List<String>> getVerticalAlignments() {
        return this.verticalAlignments;
    }

    public static class GetRangeResponseBodyBackgroundColors extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>red_value</p>
         */
        @NameInMap("red")
        public Integer red;

        /**
         * <strong>example:</strong>
         * <p>green_value</p>
         */
        @NameInMap("green")
        public Integer green;

        /**
         * <strong>example:</strong>
         * <p>blue_value</p>
         */
        @NameInMap("blue")
        public Integer blue;

        /**
         * <strong>example:</strong>
         * <p>hex_string_value</p>
         */
        @NameInMap("hexString")
        public String hexString;

        public static GetRangeResponseBodyBackgroundColors build(java.util.Map<String, ?> map) throws Exception {
            GetRangeResponseBodyBackgroundColors self = new GetRangeResponseBodyBackgroundColors();
            return TeaModel.build(map, self);
        }

        public GetRangeResponseBodyBackgroundColors setRed(Integer red) {
            this.red = red;
            return this;
        }
        public Integer getRed() {
            return this.red;
        }

        public GetRangeResponseBodyBackgroundColors setGreen(Integer green) {
            this.green = green;
            return this;
        }
        public Integer getGreen() {
            return this.green;
        }

        public GetRangeResponseBodyBackgroundColors setBlue(Integer blue) {
            this.blue = blue;
            return this;
        }
        public Integer getBlue() {
            return this.blue;
        }

        public GetRangeResponseBodyBackgroundColors setHexString(String hexString) {
            this.hexString = hexString;
            return this;
        }
        public String getHexString() {
            return this.hexString;
        }

    }

}
