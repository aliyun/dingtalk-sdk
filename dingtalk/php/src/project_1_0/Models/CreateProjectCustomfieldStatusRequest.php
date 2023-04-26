<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\CreateProjectCustomfieldStatusRequest\value;
use AlibabaCloud\Tea\Model;

class CreateProjectCustomfieldStatusRequest extends Model
{
    /**
     * @example 63a5301e420637003f5dxxxx
     *
     * @var string
     */
    public $customfieldId;

    /**
     * @example 64a5301e420637003f5dxxxx
     *
     * @var string
     */
    public $customfieldInstanceId;

    /**
     * @example 项目进度
     *
     * @var string
     */
    public $customfieldName;

    /**
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
