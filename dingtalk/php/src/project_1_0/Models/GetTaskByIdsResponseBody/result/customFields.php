<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\GetTaskByIdsResponseBody\result;

use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\GetTaskByIdsResponseBody\result\customFields\value;
use AlibabaCloud\Tea\Model;

class customFields extends Model
{
    /**
     * @example 61122xxxxxxxx
     *
     * @var string
     */
    public $customFieldId;

    /**
     * @var string
     */
    public $type;

    /**
     * @var value[]
     */
    public $value;
    protected $_name = [
        'customFieldId' => 'customFieldId',
        'type'          => 'type',
        'value'         => 'value',
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
        if (null !== $this->type) {
            $res['type'] = $this->type;
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
     * @return customFields
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['customFieldId'])) {
            $model->customFieldId = $map['customFieldId'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
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
