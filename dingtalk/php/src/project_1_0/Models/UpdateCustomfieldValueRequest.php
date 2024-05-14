<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\UpdateCustomfieldValueRequest\value;
use AlibabaCloud\Tea\Model;

class UpdateCustomfieldValueRequest extends Model
{
    /**
     * @example 62a010c153c2ef52xxxx
     *
     * @var string
     */
    public $customFieldId;

    /**
     * @example 自定义字段-文本
     *
     * @var string
     */
    public $customFieldName;

    /**
     * @description This parameter is required.
     *
     * @var value[]
     */
    public $value;
    protected $_name = [
        'customFieldId'   => 'customFieldId',
        'customFieldName' => 'customFieldName',
        'value'           => 'value',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->customFieldId) {
            $res['customFieldId'] = $this->customFieldId;
        }
        if (null !== $this->customFieldName) {
            $res['customFieldName'] = $this->customFieldName;
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
     * @return UpdateCustomfieldValueRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['customFieldId'])) {
            $model->customFieldId = $map['customFieldId'];
        }
        if (isset($map['customFieldName'])) {
            $model->customFieldName = $map['customFieldName'];
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
