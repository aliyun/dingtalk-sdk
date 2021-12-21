<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\CreateRelationMetaRequest\relationMetaDTO\items;

use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\CreateRelationMetaRequest\relationMetaDTO\items\props\options;
use AlibabaCloud\Tea\Model;

class props extends Model
{
    /**
     * @var string
     */
    public $fieldId;

    /**
     * @var string
     */
    public $label;

    /**
     * @var bool
     */
    public $sortable;

    /**
     * @var string
     */
    public $needDetail;

    /**
     * @var bool
     */
    public $labelEditableFreeze;

    /**
     * @var bool
     */
    public $required;

    /**
     * @var bool
     */
    public $requiredEditableFreeze;

    /**
     * @var string
     */
    public $notPrint;

    /**
     * @var string
     */
    public $content;

    /**
     * @var string
     */
    public $format;

    /**
     * @var options[]
     */
    public $options;

    /**
     * @var string
     */
    public $notUpper;

    /**
     * @var string
     */
    public $unit;

    /**
     * @var string
     */
    public $placeholder;

    /**
     * @var string
     */
    public $bizAlias;

    /**
     * @var bool
     */
    public $duration;

    /**
     * @var int
     */
    public $choice;

    /**
     * @var bool
     */
    public $disabled;

    /**
     * @var string
     */
    public $align;

    /**
     * @var bool
     */
    public $invisible;

    /**
     * @var bool
     */
    public $payEnable;

    /**
     * @var string
     */
    public $link;
    protected $_name = [
        'fieldId'                => 'fieldId',
        'label'                  => 'label',
        'sortable'               => 'sortable',
        'needDetail'             => 'needDetail',
        'labelEditableFreeze'    => 'labelEditableFreeze',
        'required'               => 'required',
        'requiredEditableFreeze' => 'requiredEditableFreeze',
        'notPrint'               => 'notPrint',
        'content'                => 'content',
        'format'                 => 'format',
        'options'                => 'options',
        'notUpper'               => 'notUpper',
        'unit'                   => 'unit',
        'placeholder'            => 'placeholder',
        'bizAlias'               => 'bizAlias',
        'duration'               => 'duration',
        'choice'                 => 'choice',
        'disabled'               => 'disabled',
        'align'                  => 'align',
        'invisible'              => 'invisible',
        'payEnable'              => 'payEnable',
        'link'                   => 'link',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->fieldId) {
            $res['fieldId'] = $this->fieldId;
        }
        if (null !== $this->label) {
            $res['label'] = $this->label;
        }
        if (null !== $this->sortable) {
            $res['sortable'] = $this->sortable;
        }
        if (null !== $this->needDetail) {
            $res['needDetail'] = $this->needDetail;
        }
        if (null !== $this->labelEditableFreeze) {
            $res['labelEditableFreeze'] = $this->labelEditableFreeze;
        }
        if (null !== $this->required) {
            $res['required'] = $this->required;
        }
        if (null !== $this->requiredEditableFreeze) {
            $res['requiredEditableFreeze'] = $this->requiredEditableFreeze;
        }
        if (null !== $this->notPrint) {
            $res['notPrint'] = $this->notPrint;
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
        if (null !== $this->notUpper) {
            $res['notUpper'] = $this->notUpper;
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
        if (null !== $this->payEnable) {
            $res['payEnable'] = $this->payEnable;
        }
        if (null !== $this->link) {
            $res['link'] = $this->link;
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
        if (isset($map['fieldId'])) {
            $model->fieldId = $map['fieldId'];
        }
        if (isset($map['label'])) {
            $model->label = $map['label'];
        }
        if (isset($map['sortable'])) {
            $model->sortable = $map['sortable'];
        }
        if (isset($map['needDetail'])) {
            $model->needDetail = $map['needDetail'];
        }
        if (isset($map['labelEditableFreeze'])) {
            $model->labelEditableFreeze = $map['labelEditableFreeze'];
        }
        if (isset($map['required'])) {
            $model->required = $map['required'];
        }
        if (isset($map['requiredEditableFreeze'])) {
            $model->requiredEditableFreeze = $map['requiredEditableFreeze'];
        }
        if (isset($map['notPrint'])) {
            $model->notPrint = $map['notPrint'];
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
        if (isset($map['notUpper'])) {
            $model->notUpper = $map['notUpper'];
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
        if (isset($map['payEnable'])) {
            $model->payEnable = $map['payEnable'];
        }
        if (isset($map['link'])) {
            $model->link = $map['link'];
        }

        return $model;
    }
}
