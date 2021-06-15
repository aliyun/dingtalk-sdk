<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\DescribeCrmPersonalCustomerObjectMetaResponseBody\fields;

use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\DescribeCrmPersonalCustomerObjectMetaResponseBody\fields\referenceFields\selectOptions;
use AlibabaCloud\Tea\Model;

class referenceFields extends Model
{
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
    public $unit;

    /**
     * @var string
     */
    public $format;

    /**
     * @var selectOptions[]
     */
    public $selectOptions;

    /**
     * @var string
     */
    public $name;
    protected $_name = [
        'label'         => 'label',
        'type'          => 'type',
        'nillable'      => 'nillable',
        'unit'          => 'unit',
        'format'        => 'format',
        'selectOptions' => 'selectOptions',
        'name'          => 'name',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->label) {
            $res['label'] = $this->label;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }
        if (null !== $this->nillable) {
            $res['nillable'] = $this->nillable;
        }
        if (null !== $this->unit) {
            $res['unit'] = $this->unit;
        }
        if (null !== $this->format) {
            $res['format'] = $this->format;
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
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return referenceFields
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['label'])) {
            $model->label = $map['label'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }
        if (isset($map['nillable'])) {
            $model->nillable = $map['nillable'];
        }
        if (isset($map['unit'])) {
            $model->unit = $map['unit'];
        }
        if (isset($map['format'])) {
            $model->format = $map['format'];
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
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }

        return $model;
    }
}
