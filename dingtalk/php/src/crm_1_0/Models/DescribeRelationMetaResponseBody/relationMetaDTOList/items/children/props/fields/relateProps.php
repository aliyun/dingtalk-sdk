<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\DescribeRelationMetaResponseBody\relationMetaDTOList\items\children\props\fields;

use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\DescribeRelationMetaResponseBody\relationMetaDTOList\items\children\props\fields\relateProps\options;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\DescribeRelationMetaResponseBody\relationMetaDTOList\items\children\props\fields\relateProps\statField;
use AlibabaCloud\Tea\Model;

class relateProps extends Model
{
    /**
     * @var string
     */
    public $align;

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
    public $ratio;

    /**
     * @var bool
     */
    public $required;

    /**
     * @var bool
     */
    public $requiredEditableFreeze;

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
        'align'                  => 'align',
        'bizAlias'               => 'bizAlias',
        'choice'                 => 'choice',
        'content'                => 'content',
        'disabled'               => 'disabled',
        'duration'               => 'duration',
        'durationLabel'          => 'durationLabel',
        'fieldId'                => 'fieldId',
        'format'                 => 'format',
        'formula'                => 'formula',
        'invisible'              => 'invisible',
        'label'                  => 'label',
        'labelEditableFreeze'    => 'labelEditableFreeze',
        'limit'                  => 'limit',
        'link'                   => 'link',
        'mode'                   => 'mode',
        'notUpper'               => 'notUpper',
        'options'                => 'options',
        'payEnable'              => 'payEnable',
        'placeholder'            => 'placeholder',
        'ratio'                  => 'ratio',
        'required'               => 'required',
        'requiredEditableFreeze' => 'requiredEditableFreeze',
        'spread'                 => 'spread',
        'statField'              => 'statField',
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
        if (null !== $this->durationLabel) {
            $res['durationLabel'] = $this->durationLabel;
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
        if (null !== $this->limit) {
            $res['limit'] = $this->limit;
        }
        if (null !== $this->link) {
            $res['link'] = $this->link;
        }
        if (null !== $this->mode) {
            $res['mode'] = $this->mode;
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
        if (null !== $this->ratio) {
            $res['ratio'] = $this->ratio;
        }
        if (null !== $this->required) {
            $res['required'] = $this->required;
        }
        if (null !== $this->requiredEditableFreeze) {
            $res['requiredEditableFreeze'] = $this->requiredEditableFreeze;
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
        if (isset($map['durationLabel'])) {
            $model->durationLabel = $map['durationLabel'];
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
        if (isset($map['limit'])) {
            $model->limit = $map['limit'];
        }
        if (isset($map['link'])) {
            $model->link = $map['link'];
        }
        if (isset($map['mode'])) {
            $model->mode = $map['mode'];
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
        if (isset($map['ratio'])) {
            $model->ratio = $map['ratio'];
        }
        if (isset($map['required'])) {
            $model->required = $map['required'];
        }
        if (isset($map['requiredEditableFreeze'])) {
            $model->requiredEditableFreeze = $map['requiredEditableFreeze'];
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
