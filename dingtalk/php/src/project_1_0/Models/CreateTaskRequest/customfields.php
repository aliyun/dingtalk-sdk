<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\CreateTaskRequest;

use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\CreateTaskRequest\customfields\value;
use AlibabaCloud\Tea\Model;

class customfields extends Model
{
    /**
     * @example 自定义字段别名
     *
     * @var string
     */
    public $customfieldAlias;

    /**
     * @example 62fb0bxxxxxxx
     *
     * @var string
     */
    public $customfieldId;

    /**
     * @example 自定义字段-文本
     *
     * @var string
     */
    public $customfieldName;

    /**
     * @var value[]
     */
    public $value;
    protected $_name = [
        'customfieldAlias' => 'customfieldAlias',
        'customfieldId' => 'customfieldId',
        'customfieldName' => 'customfieldName',
        'value' => 'value',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->customfieldAlias) {
            $res['customfieldAlias'] = $this->customfieldAlias;
        }
        if (null !== $this->customfieldId) {
            $res['customfieldId'] = $this->customfieldId;
        }
        if (null !== $this->customfieldName) {
            $res['customfieldName'] = $this->customfieldName;
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
        if (isset($map['customfieldAlias'])) {
            $model->customfieldAlias = $map['customfieldAlias'];
        }
        if (isset($map['customfieldId'])) {
            $model->customfieldId = $map['customfieldId'];
        }
        if (isset($map['customfieldName'])) {
            $model->customfieldName = $map['customfieldName'];
        }
        if (isset($map['value'])) {
            if (!empty($map['value'])) {
                $model->value = [];
                $n = 0;
                foreach ($map['value'] as $item) {
                    $model->value[$n++] = null !== $item ? value::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
