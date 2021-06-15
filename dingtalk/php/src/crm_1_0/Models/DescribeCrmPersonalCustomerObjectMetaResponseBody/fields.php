<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\DescribeCrmPersonalCustomerObjectMetaResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\DescribeCrmPersonalCustomerObjectMetaResponseBody\fields\referenceFields;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\DescribeCrmPersonalCustomerObjectMetaResponseBody\fields\rollUpSummaryFields;
use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\DescribeCrmPersonalCustomerObjectMetaResponseBody\fields\selectOptions;
use AlibabaCloud\Tea\Model;

class fields extends Model
{
    /**
     * @var string
     */
    public $name;

    /**
     * @var bool
     */
    public $customized;

    /**
     * @var string
     */
    public $label;

    /**
     * @var string
     */
    public $type;

    /**
     * @var bool
     */
    public $nillable;

    /**
     * @var string
     */
    public $format;

    /**
     * @var string
     */
    public $unit;

    /**
     * @var selectOptions[]
     */
    public $selectOptions;

    /**
     * @var bool
     */
    public $quote;

    /**
     * @var string
     */
    public $referenceTo;

    /**
     * @var referenceFields[]
     */
    public $referenceFields;

    /**
     * @var rollUpSummaryFields[]
     */
    public $rollUpSummaryFields;
    protected $_name = [
        'name'                => 'name',
        'customized'          => 'customized',
        'label'               => 'label',
        'type'                => 'type',
        'nillable'            => 'nillable',
        'format'              => 'format',
        'unit'                => 'unit',
        'selectOptions'       => 'selectOptions',
        'quote'               => 'quote',
        'referenceTo'         => 'referenceTo',
        'referenceFields'     => 'referenceFields',
        'rollUpSummaryFields' => 'rollUpSummaryFields',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->customized) {
            $res['customized'] = $this->customized;
        }
        if (null !== $this->label) {
            $res['label'] = $this->label;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }
        if (null !== $this->nillable) {
            $res['nillable'] = $this->nillable;
        }
        if (null !== $this->format) {
            $res['format'] = $this->format;
        }
        if (null !== $this->unit) {
            $res['unit'] = $this->unit;
        }
        if (null !== $this->selectOptions) {
            $res['selectOptions'] = [];
            if (null !== $this->selectOptions && \is_array($this->selectOptions)) {
                $n = 0;
                foreach ($this->selectOptions as $item) {
                    $res['selectOptions'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->quote) {
            $res['quote'] = $this->quote;
        }
        if (null !== $this->referenceTo) {
            $res['referenceTo'] = $this->referenceTo;
        }
        if (null !== $this->referenceFields) {
            $res['referenceFields'] = [];
            if (null !== $this->referenceFields && \is_array($this->referenceFields)) {
                $n = 0;
                foreach ($this->referenceFields as $item) {
                    $res['referenceFields'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->rollUpSummaryFields) {
            $res['rollUpSummaryFields'] = [];
            if (null !== $this->rollUpSummaryFields && \is_array($this->rollUpSummaryFields)) {
                $n = 0;
                foreach ($this->rollUpSummaryFields as $item) {
                    $res['rollUpSummaryFields'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return fields
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['customized'])) {
            $model->customized = $map['customized'];
        }
        if (isset($map['label'])) {
            $model->label = $map['label'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }
        if (isset($map['nillable'])) {
            $model->nillable = $map['nillable'];
        }
        if (isset($map['format'])) {
            $model->format = $map['format'];
        }
        if (isset($map['unit'])) {
            $model->unit = $map['unit'];
        }
        if (isset($map['selectOptions'])) {
            if (!empty($map['selectOptions'])) {
                $model->selectOptions = [];
                $n                    = 0;
                foreach ($map['selectOptions'] as $item) {
                    $model->selectOptions[$n++] = null !== $item ? selectOptions::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['quote'])) {
            $model->quote = $map['quote'];
        }
        if (isset($map['referenceTo'])) {
            $model->referenceTo = $map['referenceTo'];
        }
        if (isset($map['referenceFields'])) {
            if (!empty($map['referenceFields'])) {
                $model->referenceFields = [];
                $n                      = 0;
                foreach ($map['referenceFields'] as $item) {
                    $model->referenceFields[$n++] = null !== $item ? referenceFields::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['rollUpSummaryFields'])) {
            if (!empty($map['rollUpSummaryFields'])) {
                $model->rollUpSummaryFields = [];
                $n                          = 0;
                foreach ($map['rollUpSummaryFields'] as $item) {
                    $model->rollUpSummaryFields[$n++] = null !== $item ? rollUpSummaryFields::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
