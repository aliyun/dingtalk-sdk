<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\FormCreateRequest\formComponents\children\children;

use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\FormCreateRequest\formComponents\children\children\props\dataSource;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\FormCreateRequest\formComponents\children\children\props\fields;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\FormCreateRequest\formComponents\children\children\props\options;
use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\FormCreateRequest\formComponents\children\children\props\statField;
use AlibabaCloud\Tea\Model;

class props extends Model
{
    /**
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
     * @description 套件中控件是否可设置为分条件字段
     *
     * @var bool
     */
    public $asyncCondition;

    /**
     * @description 必填
     *
     * @var bool
     */
    public $required;

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
     * @description 是否需要大写，1需要大写，0不需要大写
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
     * @description 文字提示控件显示方式:top|middle|bottom
     *
     * @var string
     */
    public $align;

    /**
     * @description 是否隐藏字段
     *
     * @var bool
     */
    public $invisible;

    /**
     * @description 说明文字控件链接地址
     *
     * @var string
     */
    public $link;

    /**
     * @description 明细排版方式false横向，true纵向
     *
     * @var bool
     */
    public $verticalPrint;

    /**
     * @description 公式
     *
     * @var string
     */
    public $formula;

    /**
     * @description 自定义控件渲染标识
     *
     * @var string
     */
    public $commonBizType;

    /**
     * @var options[]
     */
    public $options;

    /**
     * @var string
     */
    public $print;

    /**
     * @var statField[]
     */
    public $statField;

    /**
     * @var dataSource
     */
    public $dataSource;

    /**
     * @var fields[]
     */
    public $fields;
    protected $_name = [
        'componentId'    => 'componentId',
        'label'          => 'label',
        'asyncCondition' => 'asyncCondition',
        'required'       => 'required',
        'content'        => 'content',
        'format'         => 'format',
        'upper'          => 'upper',
        'unit'           => 'unit',
        'placeholder'    => 'placeholder',
        'bizAlias'       => 'bizAlias',
        'bizType'        => 'bizType',
        'duration'       => 'duration',
        'choice'         => 'choice',
        'disabled'       => 'disabled',
        'align'          => 'align',
        'invisible'      => 'invisible',
        'link'           => 'link',
        'verticalPrint'  => 'verticalPrint',
        'formula'        => 'formula',
        'commonBizType'  => 'commonBizType',
        'options'        => 'options',
        'print'          => 'print',
        'statField'      => 'statField',
        'dataSource'     => 'dataSource',
        'fields'         => 'fields',
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
        if (null !== $this->asyncCondition) {
            $res['asyncCondition'] = $this->asyncCondition;
        }
        if (null !== $this->required) {
            $res['required'] = $this->required;
        }
        if (null !== $this->content) {
            $res['content'] = $this->content;
        }
        if (null !== $this->format) {
            $res['format'] = $this->format;
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
        if (null !== $this->invisible) {
            $res['invisible'] = $this->invisible;
        }
        if (null !== $this->link) {
            $res['link'] = $this->link;
        }
        if (null !== $this->verticalPrint) {
            $res['verticalPrint'] = $this->verticalPrint;
        }
        if (null !== $this->formula) {
            $res['formula'] = $this->formula;
        }
        if (null !== $this->commonBizType) {
            $res['commonBizType'] = $this->commonBizType;
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
        if (null !== $this->print) {
            $res['print'] = $this->print;
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
        if (null !== $this->dataSource) {
            $res['dataSource'] = null !== $this->dataSource ? $this->dataSource->toMap() : null;
        }
        if (null !== $this->fields) {
            $res['fields'] = [];
            if (null !== $this->fields && \is_array($this->fields)) {
                $n = 0;
                foreach ($this->fields as $item) {
                    $res['fields'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
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
        if (isset($map['asyncCondition'])) {
            $model->asyncCondition = $map['asyncCondition'];
        }
        if (isset($map['required'])) {
            $model->required = $map['required'];
        }
        if (isset($map['content'])) {
            $model->content = $map['content'];
        }
        if (isset($map['format'])) {
            $model->format = $map['format'];
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
        if (isset($map['invisible'])) {
            $model->invisible = $map['invisible'];
        }
        if (isset($map['link'])) {
            $model->link = $map['link'];
        }
        if (isset($map['verticalPrint'])) {
            $model->verticalPrint = $map['verticalPrint'];
        }
        if (isset($map['formula'])) {
            $model->formula = $map['formula'];
        }
        if (isset($map['commonBizType'])) {
            $model->commonBizType = $map['commonBizType'];
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
        if (isset($map['print'])) {
            $model->print = $map['print'];
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
        if (isset($map['dataSource'])) {
            $model->dataSource = dataSource::fromMap($map['dataSource']);
        }
        if (isset($map['fields'])) {
            if (!empty($map['fields'])) {
                $model->fields = [];
                $n             = 0;
                foreach ($map['fields'] as $item) {
                    $model->fields[$n++] = null !== $item ? fields::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
