<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\FormComponentProps\statField;
use AlibabaCloud\Tea\Model;

class FormComponentProps extends Model
{
    /**
     * @example 增加明细
     *
     * @var string
     */
    public $actionName;

    /**
     * @var string
     */
    public $addressModel;

    /**
     * @example top
     *
     * @var string
     */
    public $align;

    /**
     * @example true
     *
     * @var bool
     */
    public $asyncCondition;

    /**
     * @var AvaliableTemplate[]
     */
    public $availableTemplates;

    /**
     * @example finance_name
     *
     * @var string
     */
    public $bizAlias;

    /**
     * @example attendance.leave
     *
     * @var string
     */
    public $bizType;

    /**
     * @example 0
     *
     * @var string
     */
    public $choice;

    /**
     * @example custom_view
     *
     * @var string
     */
    public $commonBizType;

    /**
     * @example TextField-abcd
     *
     * @var string
     */
    public $componentId;

    /**
     * @example 我是说明文字控件
     *
     * @var string
     */
    public $content;

    /**
     * @var FormDataSource
     */
    public $dataSource;

    /**
     * @example true
     *
     * @var bool
     */
    public $disabled;

    /**
     * @example true
     *
     * @var bool
     */
    public $duration;

    /**
     * @example 时长
     *
     * @var string
     */
    public $durationLabel;

    /**
     * @example yyyy-MM-dd
     *
     * @var string
     */
    public $format;

    /**
     * @var string
     */
    public $formula;

    /**
     * @example true
     *
     * @var bool
     */
    public $invisible;

    /**
     * @example 姓名
     *
     * @var string
     */
    public $label;

    /**
     * @example 5
     *
     * @var int
     */
    public $limit;

    /**
     * @example http://www.
     *
     * @var string
     */
    public $link;

    /**
     * @example 20
     *
     * @var int
     */
    public $maxLength;

    /**
     * @example phone_tel
     *
     * @var string
     */
    public $mode;

    /**
     * @example true
     *
     * @var bool
     */
    public $multiple;

    /**
     * @var SelectOption[]
     */
    public $options;

    /**
     * @example 请输入
     *
     * @var string
     */
    public $placeholder;

    /**
     * @example 2
     *
     * @var int
     */
    public $precision;

    /**
     * @example 1
     *
     * @var string
     */
    public $print;

    /**
     * @example true
     *
     * @var bool
     */
    public $required;

    /**
     * @var statField[]
     */
    public $statField;

    /**
     * @example table
     *
     * @var string
     */
    public $tableViewMode;

    /**
     * @example 天
     *
     * @var string
     */
    public $unit;

    /**
     * @example 1
     *
     * @var string
     */
    public $upper;

    /**
     * @example true
     *
     * @var bool
     */
    public $verticalPrint;
    protected $_name = [
        'actionName' => 'actionName',
        'addressModel' => 'addressModel',
        'align' => 'align',
        'asyncCondition' => 'asyncCondition',
        'availableTemplates' => 'availableTemplates',
        'bizAlias' => 'bizAlias',
        'bizType' => 'bizType',
        'choice' => 'choice',
        'commonBizType' => 'commonBizType',
        'componentId' => 'componentId',
        'content' => 'content',
        'dataSource' => 'dataSource',
        'disabled' => 'disabled',
        'duration' => 'duration',
        'durationLabel' => 'durationLabel',
        'format' => 'format',
        'formula' => 'formula',
        'invisible' => 'invisible',
        'label' => 'label',
        'limit' => 'limit',
        'link' => 'link',
        'maxLength' => 'maxLength',
        'mode' => 'mode',
        'multiple' => 'multiple',
        'options' => 'options',
        'placeholder' => 'placeholder',
        'precision' => 'precision',
        'print' => 'print',
        'required' => 'required',
        'statField' => 'statField',
        'tableViewMode' => 'tableViewMode',
        'unit' => 'unit',
        'upper' => 'upper',
        'verticalPrint' => 'verticalPrint',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->actionName) {
            $res['actionName'] = $this->actionName;
        }
        if (null !== $this->addressModel) {
            $res['addressModel'] = $this->addressModel;
        }
        if (null !== $this->align) {
            $res['align'] = $this->align;
        }
        if (null !== $this->asyncCondition) {
            $res['asyncCondition'] = $this->asyncCondition;
        }
        if (null !== $this->availableTemplates) {
            $res['availableTemplates'] = [];
            if (null !== $this->availableTemplates && \is_array($this->availableTemplates)) {
                $n = 0;
                foreach ($this->availableTemplates as $item) {
                    $res['availableTemplates'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->bizAlias) {
            $res['bizAlias'] = $this->bizAlias;
        }
        if (null !== $this->bizType) {
            $res['bizType'] = $this->bizType;
        }
        if (null !== $this->choice) {
            $res['choice'] = $this->choice;
        }
        if (null !== $this->commonBizType) {
            $res['commonBizType'] = $this->commonBizType;
        }
        if (null !== $this->componentId) {
            $res['componentId'] = $this->componentId;
        }
        if (null !== $this->content) {
            $res['content'] = $this->content;
        }
        if (null !== $this->dataSource) {
            $res['dataSource'] = null !== $this->dataSource ? $this->dataSource->toMap() : null;
        }
        if (null !== $this->disabled) {
            $res['disabled'] = $this->disabled;
        }
        if (null !== $this->duration) {
            $res['duration'] = $this->duration;
        }
        if (null !== $this->durationLabel) {
            $res['durationLabel'] = $this->durationLabel;
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
        if (null !== $this->limit) {
            $res['limit'] = $this->limit;
        }
        if (null !== $this->link) {
            $res['link'] = $this->link;
        }
        if (null !== $this->maxLength) {
            $res['maxLength'] = $this->maxLength;
        }
        if (null !== $this->mode) {
            $res['mode'] = $this->mode;
        }
        if (null !== $this->multiple) {
            $res['multiple'] = $this->multiple;
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
        if (null !== $this->placeholder) {
            $res['placeholder'] = $this->placeholder;
        }
        if (null !== $this->precision) {
            $res['precision'] = $this->precision;
        }
        if (null !== $this->print) {
            $res['print'] = $this->print;
        }
        if (null !== $this->required) {
            $res['required'] = $this->required;
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
        if (null !== $this->tableViewMode) {
            $res['tableViewMode'] = $this->tableViewMode;
        }
        if (null !== $this->unit) {
            $res['unit'] = $this->unit;
        }
        if (null !== $this->upper) {
            $res['upper'] = $this->upper;
        }
        if (null !== $this->verticalPrint) {
            $res['verticalPrint'] = $this->verticalPrint;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return FormComponentProps
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['actionName'])) {
            $model->actionName = $map['actionName'];
        }
        if (isset($map['addressModel'])) {
            $model->addressModel = $map['addressModel'];
        }
        if (isset($map['align'])) {
            $model->align = $map['align'];
        }
        if (isset($map['asyncCondition'])) {
            $model->asyncCondition = $map['asyncCondition'];
        }
        if (isset($map['availableTemplates'])) {
            if (!empty($map['availableTemplates'])) {
                $model->availableTemplates = [];
                $n = 0;
                foreach ($map['availableTemplates'] as $item) {
                    $model->availableTemplates[$n++] = null !== $item ? AvaliableTemplate::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['bizAlias'])) {
            $model->bizAlias = $map['bizAlias'];
        }
        if (isset($map['bizType'])) {
            $model->bizType = $map['bizType'];
        }
        if (isset($map['choice'])) {
            $model->choice = $map['choice'];
        }
        if (isset($map['commonBizType'])) {
            $model->commonBizType = $map['commonBizType'];
        }
        if (isset($map['componentId'])) {
            $model->componentId = $map['componentId'];
        }
        if (isset($map['content'])) {
            $model->content = $map['content'];
        }
        if (isset($map['dataSource'])) {
            $model->dataSource = FormDataSource::fromMap($map['dataSource']);
        }
        if (isset($map['disabled'])) {
            $model->disabled = $map['disabled'];
        }
        if (isset($map['duration'])) {
            $model->duration = $map['duration'];
        }
        if (isset($map['durationLabel'])) {
            $model->durationLabel = $map['durationLabel'];
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
        if (isset($map['limit'])) {
            $model->limit = $map['limit'];
        }
        if (isset($map['link'])) {
            $model->link = $map['link'];
        }
        if (isset($map['maxLength'])) {
            $model->maxLength = $map['maxLength'];
        }
        if (isset($map['mode'])) {
            $model->mode = $map['mode'];
        }
        if (isset($map['multiple'])) {
            $model->multiple = $map['multiple'];
        }
        if (isset($map['options'])) {
            if (!empty($map['options'])) {
                $model->options = [];
                $n = 0;
                foreach ($map['options'] as $item) {
                    $model->options[$n++] = null !== $item ? SelectOption::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['placeholder'])) {
            $model->placeholder = $map['placeholder'];
        }
        if (isset($map['precision'])) {
            $model->precision = $map['precision'];
        }
        if (isset($map['print'])) {
            $model->print = $map['print'];
        }
        if (isset($map['required'])) {
            $model->required = $map['required'];
        }
        if (isset($map['statField'])) {
            if (!empty($map['statField'])) {
                $model->statField = [];
                $n = 0;
                foreach ($map['statField'] as $item) {
                    $model->statField[$n++] = null !== $item ? statField::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['tableViewMode'])) {
            $model->tableViewMode = $map['tableViewMode'];
        }
        if (isset($map['unit'])) {
            $model->unit = $map['unit'];
        }
        if (isset($map['upper'])) {
            $model->upper = $map['upper'];
        }
        if (isset($map['verticalPrint'])) {
            $model->verticalPrint = $map['verticalPrint'];
        }

        return $model;
    }
}
