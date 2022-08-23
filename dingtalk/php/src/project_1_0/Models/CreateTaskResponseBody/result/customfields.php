<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\CreateTaskResponseBody\result;

use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\CreateTaskResponseBody\result\customfields\value;
use AlibabaCloud\Tea\Model;

class customfields extends Model
{
    /**
     * @description 自定义字段id
     *
     * @var string
     */
    public $customfieldId;

    /**
     * @description 自定义字段值
     *
     * @var value[]
     */
    public $value;
    protected $_name = [
        'customfieldId' => 'customfieldId',
        'value'         => 'value',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->customfieldId) {
            $res['customfieldId'] = $this->customfieldId;
        }
        if (null !== $this->value) {
            $res['value'] = [];
            if (null !== $this->value && \is_array($this->value)) {
                $n = 0;
                foreach ($this->value as $item) {
                    $res['value'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return customfields
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['customfieldId'])) {
            $model->customfieldId = $map['customfieldId'];
        }
        if (isset($map['value'])) {
            if (!empty($map['value'])) {
                $model->value = [];
                $n            = 0;
                foreach ($map['value'] as $item) {
                    $model->value[$n++] = null !== $item ? value::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
