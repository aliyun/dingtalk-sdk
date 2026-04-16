<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateFilterRequest extends Model
{
    /**
     * @var CriteriaValue[]
     */
    public $criteria;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $range;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $operatorId;
    protected $_name = [
        'criteria' => 'criteria',
        'range' => 'range',
        'operatorId' => 'operatorId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->criteria) {
            $res['criteria'] = [];
            if (null !== $this->criteria && \is_array($this->criteria)) {
                foreach ($this->criteria as $key => $val) {
                    $res['criteria'][$key] = null !== $val ? $val->toMap() : $val;
                }
            }
        }
        if (null !== $this->range) {
            $res['range'] = $this->range;
        }
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateFilterRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['criteria'])) {
            $model->criteria = $map['criteria'];
        }
        if (isset($map['range'])) {
            $model->range = $map['range'];
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }

        return $model;
    }
}
