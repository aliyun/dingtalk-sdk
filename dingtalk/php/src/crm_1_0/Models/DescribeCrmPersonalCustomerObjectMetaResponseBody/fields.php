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
     * @var bool
     */
    public $customized;

    /**
     * @var string
     */
    public $format;

    /**
     * @var string
     */
    public $label;

    /**
     * @var string
     */
    public $name;

    /**
     * @var bool
     */
    public $nillable;

    /**
     * @var bool
     */
    public $quote;

    /**
     * @var referenceFields[]
     */
    public $referenceFields;

    /**
     * @var string
     */
    public $referenceTo;

    /**
     * @var rollUpSummaryFields[]
     */
    public $rollUpSummaryFields;

    /**
     * @var selectOptions[]
     */
    public $selectOptions;

    /**
     * @var string
     */
    public $type;

    /**
     * @var string
     */
    public $unit;
    protected $_name = [
        'customized'          => 'customized',
        'format'              => 'format',
        'label'               => 'label',
        'name'                => 'name',
        'nillable'            => 'nillable',
        'quote'               => 'quote',
        'referenceFields'     => 'referenceFields',
        'referenceTo'         => 'referenceTo',
        'rollUpSummaryFields' => 'rollUpSummaryFields',
        'selectOptions'       => 'selectOptions',
        'type'                => 'type',
        'unit'                => 'unit',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->customized) {
            $res['customized'] = $this->customized;
        }
        if (null !== $this->format) {
            $res['format'] = $this->format;
        }
        if (null !== $this->label) {
            $res['label'] = $this->label;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->nillable) {
            $res['nillable'] = $this->nillable;
        }
        if (null !== $this->quote) {
            $res['quote'] = $this->quote;
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
        if (null !== $this->referenceTo) {
            $res['referenceTo'] = $this->referenceTo;
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
        if (null !== $this->selectOptions) {
            $res['selectOptions'] = [];
            if (null !== $this->selectOptions && \is_array($this->selectOptions)) {
                $n = 0;
                foreach ($this->selectOptions as $item) {
                    $res['selectOptions'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }
        if (null !== $this->unit) {
            $res['unit'] = $this->unit;
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
        if (isset($map['customized'])) {
            $model->customized = $map['customized'];
        }
        if (isset($map['format'])) {
            $model->format = $map['format'];
        }
        if (isset($map['label'])) {
            $model->label = $map['label'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['nillable'])) {
            $model->nillable = $map['nillable'];
        }
        if (isset($map['quote'])) {
            $model->quote = $map['quote'];
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
        if (isset($map['referenceTo'])) {
            $model->referenceTo = $map['referenceTo'];
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
        if (isset($map['selectOptions'])) {
            if (!empty($map['selectOptions'])) {
                $model->selectOptions = [];
                $n                    = 0;
                foreach ($map['selectOptions'] as $item) {
                    $model->selectOptions[$n++] = null !== $item ? selectOptions::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }
        if (isset($map['unit'])) {
            $model->unit = $map['unit'];
        }

        return $model;
    }
}
