<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\DescribeRelationMetaResponseBody\relationMetaDTOList\items\children;

use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\DescribeRelationMetaResponseBody\relationMetaDTOList\items\children\props\availableTemplates;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\DescribeRelationMetaResponseBody\relationMetaDTOList\items\children\props\dataSource;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\DescribeRelationMetaResponseBody\relationMetaDTOList\items\children\props\fields;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\DescribeRelationMetaResponseBody\relationMetaDTOList\items\children\props\options;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\DescribeRelationMetaResponseBody\relationMetaDTOList\items\children\props\relateSource;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\DescribeRelationMetaResponseBody\relationMetaDTOList\items\children\props\rule;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\DescribeRelationMetaResponseBody\relationMetaDTOList\items\children\props\statField;
use AlibabaCloud\Tea\Model;

class props extends Model
{
    /**
     * @var string
     */
    public $actionName;

    /**
     * @var string
     */
    public $align;

    /**
     * @var availableTemplates[]
     */
    public $availableTemplates;

    /**
     * @var string
     */
    public $bizAlias;

    /**
     * @var int
     */
    public $choice;

    /**
     * @var string
     */
    public $content;

    /**
     * @var dataSource
     */
    public $dataSource;

    /**
     * @description 标签字段 颜色属性
     *
     * @var string
     */
    public $defaultColor;

    /**
     * @var bool
     */
    public $disabled;

    /**
     * @var bool
     */
    public $duration;

    /**
     * @var string
     */
    public $durationLabel;

    /**
     * @var string
     */
    public $fieldId;

    /**
     * @var fields[]
     */
    public $fields;

    /**
     * @var string
     */
    public $format;

    /**
     * @var string
     */
    public $formula;

    /**
     * @var bool
     */
    public $invisible;

    /**
     * @var string
     */
    public $label;

    /**
     * @var bool
     */
    public $labelEditableFreeze;

    /**
     * @var int
     */
    public $limit;

    /**
     * @var string
     */
    public $link;

    /**
     * @var string
     */
    public $mode;

    /**
     * @description 支持选择多个部门
     *
     * @var bool
     */
    public $multiple;

    /**
     * @var string
     */
    public $notPrint;

    /**
     * @var string
     */
    public $notUpper;

    /**
     * @var options[]
     */
    public $options;

    /**
     * @var bool
     */
    public $payEnable;

    /**
     * @var string
     */
    public $placeholder;

    /**
     * @var int
     */
    public $quote;

    /**
     * @var int
     */
    public $ratio;

    /**
     * @var relateSource[]
     */
    public $relateSource;

    /**
     * @var bool
     */
    public $required;

    /**
     * @var bool
     */
    public $requiredEditableFreeze;

    /**
     * @var rule[]
     */
    public $rule;

    /**
     * @var bool
     */
    public $sortable;

    /**
     * @var bool
     */
    public $spread;

    /**
     * @var statField[]
     */
    public $statField;

    /**
     * @var string
     */
    public $tableViewMode;

    /**
     * @var string
     */
    public $unit;

    /**
     * @var bool
     */
    public $verticalPrint;

    /**
     * @var bool
     */
    public $watermark;
    protected $_name = [
        'actionName'             => 'actionName',
        'align'                  => 'align',
        'availableTemplates'     => 'availableTemplates',
        'bizAlias'               => 'bizAlias',
        'choice'                 => 'choice',
        'content'                => 'content',
        'dataSource'             => 'dataSource',
        'defaultColor'           => 'defaultColor',
        'disabled'               => 'disabled',
        'duration'               => 'duration',
        'durationLabel'          => 'durationLabel',
        'fieldId'                => 'fieldId',
        'fields'                 => 'fields',
        'format'                 => 'format',
        'formula'                => 'formula',
        'invisible'              => 'invisible',
        'label'                  => 'label',
        'labelEditableFreeze'    => 'labelEditableFreeze',
        'limit'                  => 'limit',
        'link'                   => 'link',
        'mode'                   => 'mode',
        'multiple'               => 'multiple',
        'notPrint'               => 'notPrint',
        'notUpper'               => 'notUpper',
        'options'                => 'options',
        'payEnable'              => 'payEnable',
        'placeholder'            => 'placeholder',
        'quote'                  => 'quote',
        'ratio'                  => 'ratio',
        'relateSource'           => 'relateSource',
        'required'               => 'required',
        'requiredEditableFreeze' => 'requiredEditableFreeze',
        'rule'                   => 'rule',
        'sortable'               => 'sortable',
        'spread'                 => 'spread',
        'statField'              => 'statField',
        'tableViewMode'          => 'tableViewMode',
        'unit'                   => 'unit',
        'verticalPrint'          => 'verticalPrint',
        'watermark'              => 'watermark',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->actionName) {
            $res['actionName'] = $this->actionName;
        }
        if (null !== $this->align) {
            $res['align'] = $this->align;
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
        if (null !== $this->choice) {
            $res['choice'] = $this->choice;
        }
        if (null !== $this->content) {
            $res['content'] = $this->content;
        }
        if (null !== $this->dataSource) {
            $res['dataSource'] = null !== $this->dataSource ? $this->dataSource->toMap() : null;
        }
        if (null !== $this->defaultColor) {
            $res['defaultColor'] = $this->defaultColor;
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
        if (null !== $this->fieldId) {
            $res['fieldId'] = $this->fieldId;
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
        if (null !== $this->limit) {
            $res['limit'] = $this->limit;
        }
        if (null !== $this->link) {
            $res['link'] = $this->link;
        }
        if (null !== $this->mode) {
            $res['mode'] = $this->mode;
        }
        if (null !== $this->multiple) {
            $res['multiple'] = $this->multiple;
        }
        if (null !== $this->notPrint) {
            $res['notPrint'] = $this->notPrint;
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
        if (null !== $this->ratio) {
            $res['ratio'] = $this->ratio;
        }
        if (null !== $this->relateSource) {
            $res['relateSource'] = [];
            if (null !== $this->relateSource && \is_array($this->relateSource)) {
                $n = 0;
                foreach ($this->relateSource as $item) {
                    $res['relateSource'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->required) {
            $res['required'] = $this->required;
        }
        if (null !== $this->requiredEditableFreeze) {
            $res['requiredEditableFreeze'] = $this->requiredEditableFreeze;
        }
        if (null !== $this->rule) {
            $res['rule'] = [];
            if (null !== $this->rule && \is_array($this->rule)) {
                $n = 0;
                foreach ($this->rule as $item) {
                    $res['rule'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->sortable) {
            $res['sortable'] = $this->sortable;
        }
        if (null !== $this->spread) {
            $res['spread'] = $this->spread;
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
        if (null !== $this->verticalPrint) {
            $res['verticalPrint'] = $this->verticalPrint;
        }
        if (null !== $this->watermark) {
            $res['watermark'] = $this->watermark;
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
        if (isset($map['actionName'])) {
            $model->actionName = $map['actionName'];
        }
        if (isset($map['align'])) {
            $model->align = $map['align'];
        }
        if (isset($map['availableTemplates'])) {
            if (!empty($map['availableTemplates'])) {
                $model->availableTemplates = [];
                $n                         = 0;
                foreach ($map['availableTemplates'] as $item) {
                    $model->availableTemplates[$n++] = null !== $item ? availableTemplates::fromMap($item) : $item;
                }
            }
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
        if (isset($map['dataSource'])) {
            $model->dataSource = dataSource::fromMap($map['dataSource']);
        }
        if (isset($map['defaultColor'])) {
            $model->defaultColor = $map['defaultColor'];
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
        if (isset($map['fieldId'])) {
            $model->fieldId = $map['fieldId'];
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
        if (isset($map['limit'])) {
            $model->limit = $map['limit'];
        }
        if (isset($map['link'])) {
            $model->link = $map['link'];
        }
        if (isset($map['mode'])) {
            $model->mode = $map['mode'];
        }
        if (isset($map['multiple'])) {
            $model->multiple = $map['multiple'];
        }
        if (isset($map['notPrint'])) {
            $model->notPrint = $map['notPrint'];
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
        if (isset($map['ratio'])) {
            $model->ratio = $map['ratio'];
        }
        if (isset($map['relateSource'])) {
            if (!empty($map['relateSource'])) {
                $model->relateSource = [];
                $n                   = 0;
                foreach ($map['relateSource'] as $item) {
                    $model->relateSource[$n++] = null !== $item ? relateSource::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['required'])) {
            $model->required = $map['required'];
        }
        if (isset($map['requiredEditableFreeze'])) {
            $model->requiredEditableFreeze = $map['requiredEditableFreeze'];
        }
        if (isset($map['rule'])) {
            if (!empty($map['rule'])) {
                $model->rule = [];
                $n           = 0;
                foreach ($map['rule'] as $item) {
                    $model->rule[$n++] = null !== $item ? rule::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['sortable'])) {
            $model->sortable = $map['sortable'];
        }
        if (isset($map['spread'])) {
            $model->spread = $map['spread'];
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
        if (isset($map['tableViewMode'])) {
            $model->tableViewMode = $map['tableViewMode'];
        }
        if (isset($map['unit'])) {
            $model->unit = $map['unit'];
        }
        if (isset($map['verticalPrint'])) {
            $model->verticalPrint = $map['verticalPrint'];
        }
        if (isset($map['watermark'])) {
            $model->watermark = $map['watermark'];
        }

        return $model;
    }
}
