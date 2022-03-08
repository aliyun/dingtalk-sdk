<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\DescribeRelationMetaResponseBody\relationMetaDTOList\items\props\relateSource\fields;

use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\DescribeRelationMetaResponseBody\relationMetaDTOList\items\props\relateSource\fields\relateProps\options;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\DescribeRelationMetaResponseBody\relationMetaDTOList\items\props\relateSource\fields\relateProps\statField;
use AlibabaCloud\Tea\Model;

class relateProps extends Model
{
    /**
     * @description textnote的样式
     *
     * @var string
     */
    public $align;

    /**
     * @description 字段别名
     *
     * @var string
     */
    public $bizAlias;

    /**
     * @description 内部联系人choice
     *
     * @var int
     */
    public $choice;

    /**
     * @description 说明文字内容
     *
     * @var string
     */
    public $content;

    /**
     * @description 是否可编辑
     *
     * @var bool
     */
    public $disabled;

    /**
     * @description 是否自动计算时长
     *
     * @var string
     */
    public $duration;

    /**
     * @description 字段id
     *
     * @var string
     */
    public $fieldId;

    /**
     * @description 时间格式
     *
     * @var string
     */
    public $format;

    /**
     * @description 公式
     *
     * @var string
     */
    public $formula;

    /**
     * @description 隐藏字段
     *
     * @var bool
     */
    public $invisible;

    /**
     * @description 字段标题
     *
     * @var string
     */
    public $label;

    /**
     * @var bool
     */
    public $labelEditableFreeze;

    /**
     * @description 说明文案的链接地址
     *
     * @var string
     */
    public $link;

    /**
     * @var int
     */
    public $multi;

    /**
     * @description 是否需要大写 默认是需要
     *
     * @var string
     */
    public $notUpper;

    /**
     * @description 选项内容列表
     *
     * @var options[]
     */
    public $options;

    /**
     * @description 是否有支付属性
     *
     * @var bool
     */
    public $payEnable;

    /**
     * @description 界面空值提示占位符 前后端统一用placeholder
     *
     * @var string
     */
    public $placeholder;

    /**
     * @var int
     */
    public $quote;

    /**
     * @description 字段是否必填
     *
     * @var bool
     */
    public $required;

    /**
     * @var bool
     */
    public $requiredEditableFreeze;

    /**
     * @description 需要计算总和的明细组件
     *
     * @var statField[]
     */
    public $statField;

    /**
     * @description 数字组件/日期区间组件单位属性
     *
     * @var string
     */
    public $unit;

    /**
     * @description 明细打印排版方式
     *
     * @var bool
     */
    public $verticalPrint;
    protected $_name = [
        'align'                  => 'align',
        'bizAlias'               => 'bizAlias',
        'choice'                 => 'choice',
        'content'                => 'content',
        'disabled'               => 'disabled',
        'duration'               => 'duration',
        'fieldId'                => 'fieldId',
        'format'                 => 'format',
        'formula'                => 'formula',
        'invisible'              => 'invisible',
        'label'                  => 'label',
        'labelEditableFreeze'    => 'labelEditableFreeze',
        'link'                   => 'link',
        'multi'                  => 'multi',
        'notUpper'               => 'notUpper',
        'options'                => 'options',
        'payEnable'              => 'payEnable',
        'placeholder'            => 'placeholder',
        'quote'                  => 'quote',
        'required'               => 'required',
        'requiredEditableFreeze' => 'requiredEditableFreeze',
        'statField'              => 'statField',
        'unit'                   => 'unit',
        'verticalPrint'          => 'verticalPrint',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->align) {
            $res['align'] = $this->align;
        }
        if (null !== $this->bizAlias) {
            $res['bizAlias'] = $this->bizAlias;
        }
        if (null !== $this->choice) {
            $res['choice'] = $this->choice;
        }
        if (null !== $this->content) {
            $res['content'] = $this->content;
        }
        if (null !== $this->disabled) {
            $res['disabled'] = $this->disabled;
        }
        if (null !== $this->duration) {
            $res['duration'] = $this->duration;
        }
        if (null !== $this->fieldId) {
            $res['fieldId'] = $this->fieldId;
        }
        if (null !== $this->format) {
            $res['format'] = $this->format;
        }
        if (null !== $this->formula) {
            $res['formula'] = $this->formula;
        }
        if (null !== $this->invisible) {
            $res['invisible'] = $this->invisible;
        }
        if (null !== $this->label) {
            $res['label'] = $this->label;
        }
        if (null !== $this->labelEditableFreeze) {
            $res['labelEditableFreeze'] = $this->labelEditableFreeze;
        }
        if (null !== $this->link) {
            $res['link'] = $this->link;
        }
        if (null !== $this->multi) {
            $res['multi'] = $this->multi;
        }
        if (null !== $this->notUpper) {
            $res['notUpper'] = $this->notUpper;
        }
        if (null !== $this->options) {
            $res['options'] = [];
            if (null !== $this->options && \is_array($this->options)) {
                $n = 0;
                foreach ($this->options as $item) {
                    $res['options'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->payEnable) {
            $res['payEnable'] = $this->payEnable;
        }
        if (null !== $this->placeholder) {
            $res['placeholder'] = $this->placeholder;
        }
        if (null !== $this->quote) {
            $res['quote'] = $this->quote;
        }
        if (null !== $this->required) {
            $res['required'] = $this->required;
        }
        if (null !== $this->requiredEditableFreeze) {
            $res['requiredEditableFreeze'] = $this->requiredEditableFreeze;
        }
        if (null !== $this->statField) {
            $res['statField'] = [];
            if (null !== $this->statField && \is_array($this->statField)) {
                $n = 0;
                foreach ($this->statField as $item) {
                    $res['statField'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->unit) {
            $res['unit'] = $this->unit;
        }
        if (null !== $this->verticalPrint) {
            $res['verticalPrint'] = $this->verticalPrint;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return relateProps
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['align'])) {
            $model->align = $map['align'];
        }
        if (isset($map['bizAlias'])) {
            $model->bizAlias = $map['bizAlias'];
        }
        if (isset($map['choice'])) {
            $model->choice = $map['choice'];
        }
        if (isset($map['content'])) {
            $model->content = $map['content'];
        }
        if (isset($map['disabled'])) {
            $model->disabled = $map['disabled'];
        }
        if (isset($map['duration'])) {
            $model->duration = $map['duration'];
        }
        if (isset($map['fieldId'])) {
            $model->fieldId = $map['fieldId'];
        }
        if (isset($map['format'])) {
            $model->format = $map['format'];
        }
        if (isset($map['formula'])) {
            $model->formula = $map['formula'];
        }
        if (isset($map['invisible'])) {
            $model->invisible = $map['invisible'];
        }
        if (isset($map['label'])) {
            $model->label = $map['label'];
        }
        if (isset($map['labelEditableFreeze'])) {
            $model->labelEditableFreeze = $map['labelEditableFreeze'];
        }
        if (isset($map['link'])) {
            $model->link = $map['link'];
        }
        if (isset($map['multi'])) {
            $model->multi = $map['multi'];
        }
        if (isset($map['notUpper'])) {
            $model->notUpper = $map['notUpper'];
        }
        if (isset($map['options'])) {
            if (!empty($map['options'])) {
                $model->options = [];
                $n              = 0;
                foreach ($map['options'] as $item) {
                    $model->options[$n++] = null !== $item ? options::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['payEnable'])) {
            $model->payEnable = $map['payEnable'];
        }
        if (isset($map['placeholder'])) {
            $model->placeholder = $map['placeholder'];
        }
        if (isset($map['quote'])) {
            $model->quote = $map['quote'];
        }
        if (isset($map['required'])) {
            $model->required = $map['required'];
        }
        if (isset($map['requiredEditableFreeze'])) {
            $model->requiredEditableFreeze = $map['requiredEditableFreeze'];
        }
        if (isset($map['statField'])) {
            if (!empty($map['statField'])) {
                $model->statField = [];
                $n                = 0;
                foreach ($map['statField'] as $item) {
                    $model->statField[$n++] = null !== $item ? statField::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['unit'])) {
            $model->unit = $map['unit'];
        }
        if (isset($map['verticalPrint'])) {
            $model->verticalPrint = $map['verticalPrint'];
        }

        return $model;
    }
}
