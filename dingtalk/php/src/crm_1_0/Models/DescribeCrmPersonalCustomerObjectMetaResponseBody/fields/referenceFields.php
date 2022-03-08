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
        'format'        => 'format',
        'label'         => 'label',
        'name'          => 'name',
        'nillable'      => 'nillable',
        'selectOptions' => 'selectOptions',
        'type'          => 'type',
        'unit'          => 'unit',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
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
     * @return referenceFields
     */
    public static function fromMap($map = [])
    {
        $model = new self();
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
