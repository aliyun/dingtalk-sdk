<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\FormCreateRequest\formComponents\children\children\props\fields;

use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\FormCreateRequest\formComponents\children\children\props\fields\props\options;
use AlibabaCloud\Tea\Model;

class props extends Model
{
    /**
     * @description 表单中控件的唯一id
     *
     * @var string
     */
    public $componentId;

    /**
     * @description 控件标题
     *
     * @var string
     */
    public $label;

    /**
     * @description 必填
     *
     * @var bool
     */
    public $required;

    /**
     * @description 字段是否可被打印，1表示打印, 0表示打印，默认打印
     *
     * @var string
     */
    public $print;

    /**
     * @description 说明文字控件内容
     *
     * @var string
     */
    public $content;

    /**
     * @description 时间格式
     *
     * @var string
     */
    public $format;

    /**
     * @description 选项内容
     *
     * @var options[]
     */
    public $options;

    /**
     * @description 是否需要大写，1需要大写，0不需要，默认1
     *
     * @var string
     */
    public $upper;

    /**
     * @description 时间单位（天、小时）
     *
     * @var string
     */
    public $unit;

    /**
     * @description 输入提示
     *
     * @var string
     */
    public $placeholder;

    /**
     * @description 业务别名
     *
     * @var string
     */
    public $bizAlias;

    /**
     * @description 套件的业务标识
     *
     * @var string
     */
    public $bizType;

    /**
     * @description 是否自动计算时长
     *
     * @var bool
     */
    public $duration;

    /**
     * @description 联系人控件是否支持多选，1多选，0单选
     *
     * @var string
     */
    public $choice;

    /**
     * @description 是否不可编辑
     *
     * @var bool
     */
    public $disabled;

    /**
     * @description 文字提示控件显示方式（top|middle|bottom）
     *
     * @var string
     */
    public $align;
    protected $_name = [
        'componentId' => 'componentId',
        'label'       => 'label',
        'required'    => 'required',
        'print'       => 'print',
        'content'     => 'content',
        'format'      => 'format',
        'options'     => 'options',
        'upper'       => 'upper',
        'unit'        => 'unit',
        'placeholder' => 'placeholder',
        'bizAlias'    => 'bizAlias',
        'bizType'     => 'bizType',
        'duration'    => 'duration',
        'choice'      => 'choice',
        'disabled'    => 'disabled',
        'align'       => 'align',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->componentId) {
            $res['componentId'] = $this->componentId;
        }
        if (null !== $this->label) {
            $res['label'] = $this->label;
        }
        if (null !== $this->required) {
            $res['required'] = $this->required;
        }
        if (null !== $this->print) {
            $res['print'] = $this->print;
        }
        if (null !== $this->content) {
            $res['content'] = $this->content;
        }
        if (null !== $this->format) {
            $res['format'] = $this->format;
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
        if (null !== $this->upper) {
            $res['upper'] = $this->upper;
        }
        if (null !== $this->unit) {
            $res['unit'] = $this->unit;
        }
        if (null !== $this->placeholder) {
            $res['placeholder'] = $this->placeholder;
        }
        if (null !== $this->bizAlias) {
            $res['bizAlias'] = $this->bizAlias;
        }
        if (null !== $this->bizType) {
            $res['bizType'] = $this->bizType;
        }
        if (null !== $this->duration) {
            $res['duration'] = $this->duration;
        }
        if (null !== $this->choice) {
            $res['choice'] = $this->choice;
        }
        if (null !== $this->disabled) {
            $res['disabled'] = $this->disabled;
        }
        if (null !== $this->align) {
            $res['align'] = $this->align;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return props
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['componentId'])) {
            $model->componentId = $map['componentId'];
        }
        if (isset($map['label'])) {
            $model->label = $map['label'];
        }
        if (isset($map['required'])) {
            $model->required = $map['required'];
        }
        if (isset($map['print'])) {
            $model->print = $map['print'];
        }
        if (isset($map['content'])) {
            $model->content = $map['content'];
        }
        if (isset($map['format'])) {
            $model->format = $map['format'];
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
        if (isset($map['upper'])) {
            $model->upper = $map['upper'];
        }
        if (isset($map['unit'])) {
            $model->unit = $map['unit'];
        }
        if (isset($map['placeholder'])) {
            $model->placeholder = $map['placeholder'];
        }
        if (isset($map['bizAlias'])) {
            $model->bizAlias = $map['bizAlias'];
        }
        if (isset($map['bizType'])) {
            $model->bizType = $map['bizType'];
        }
        if (isset($map['duration'])) {
            $model->duration = $map['duration'];
        }
        if (isset($map['choice'])) {
            $model->choice = $map['choice'];
        }
        if (isset($map['disabled'])) {
            $model->disabled = $map['disabled'];
        }
        if (isset($map['align'])) {
            $model->align = $map['align'];
        }

        return $model;
    }
}
