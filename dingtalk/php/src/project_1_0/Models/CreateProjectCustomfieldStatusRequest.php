<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\CreateProjectCustomfieldStatusRequest\value;
use AlibabaCloud\Tea\Model;

class CreateProjectCustomfieldStatusRequest extends Model
{
    /**
     * @description 自定义字段ID。
     *
     * @var string
     */
    public $customfieldId;

    /**
     * @description 自定义字段InstanceId(如果提供自定义字段ID 或者 自定义字段名称 则忽略)。
     *
     * @var string
     */
    public $customfieldInstanceId;

    /**
     * @description 自定义字段名称(如果提供自定义字段ID 则忽略)。
     *
     * @var string
     */
    public $customfieldName;

    /**
     * @description 字段值集合。
     *
     * @var value[]
     */
    public $value;
    protected $_name = [
        'customfieldId'         => 'customfieldId',
        'customfieldInstanceId' => 'customfieldInstanceId',
        'customfieldName'       => 'customfieldName',
        'value'                 => 'value',
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
        if (null !== $this->customfieldInstanceId) {
            $res['customfieldInstanceId'] = $this->customfieldInstanceId;
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
     * @return CreateProjectCustomfieldStatusRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['customfieldId'])) {
            $model->customfieldId = $map['customfieldId'];
        }
        if (isset($map['customfieldInstanceId'])) {
            $model->customfieldInstanceId = $map['customfieldInstanceId'];
        }
        if (isset($map['customfieldName'])) {
            $model->customfieldName = $map['customfieldName'];
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
