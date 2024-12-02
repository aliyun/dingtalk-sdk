<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\QueryTaskResponseBody\result;

use AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\QueryTaskResponseBody\result\customfields\value;
use AlibabaCloud\Tea\Model;

class customfields extends Model
{
    /**
     * @var string
     */
    public $cfId;

    /**
     * @var string
     */
    public $type;

    /**
     * @var value[]
     */
    public $value;
    protected $_name = [
        'cfId'  => 'cfId',
        'type'  => 'type',
        'value' => 'value',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->cfId) {
            $res['cfId'] = $this->cfId;
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
     * @return customfields
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['cfId'])) {
            $model->cfId = $map['cfId'];
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
