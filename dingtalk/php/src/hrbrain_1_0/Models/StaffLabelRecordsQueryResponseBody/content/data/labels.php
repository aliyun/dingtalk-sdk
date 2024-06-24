<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\StaffLabelRecordsQueryResponseBody\content\data;

use AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\StaffLabelRecordsQueryResponseBody\content\data\labels\options;
use AlibabaCloud\Tea\Model;

class labels extends Model
{
    /**
     * @example long_termism_score
     *
     * @var string
     */
    public $code;

    /**
     * @example values.long_termism_score
     *
     * @var string
     */
    public $guid;

    /**
     * @example 持续业绩
     *
     * @var string
     */
    public $name;

    /**
     * @var options[]
     */
    public $options;

    /**
     * @example values
     *
     * @var string
     */
    public $typeCode;

    /**
     * @example 价值
     *
     * @var string
     */
    public $typeName;

    /**
     * @example 5（总是）
     *
     * @var string
     */
    public $value;
    protected $_name = [
        'code'     => 'code',
        'guid'     => 'guid',
        'name'     => 'name',
        'options'  => 'options',
        'typeCode' => 'typeCode',
        'typeName' => 'typeName',
        'value'    => 'value',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->code) {
            $res['code'] = $this->code;
        }
        if (null !== $this->guid) {
            $res['guid'] = $this->guid;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
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
        if (null !== $this->typeCode) {
            $res['typeCode'] = $this->typeCode;
        }
        if (null !== $this->typeName) {
            $res['typeName'] = $this->typeName;
        }
        if (null !== $this->value) {
            $res['value'] = $this->value;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return labels
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['code'])) {
            $model->code = $map['code'];
        }
        if (isset($map['guid'])) {
            $model->guid = $map['guid'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
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
        if (isset($map['typeCode'])) {
            $model->typeCode = $map['typeCode'];
        }
        if (isset($map['typeName'])) {
            $model->typeName = $map['typeName'];
        }
        if (isset($map['value'])) {
            $model->value = $map['value'];
        }

        return $model;
    }
}
