<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class AddSchoolConfigRequest extends Model
{
    /**
     * @example 操作人id
     *
     * @var string
     */
    public $operatorId;

    /**
     * @example 操作人名称
     *
     * @var string
     */
    public $operatorName;

    /**
     * @example 测温上限
     *
     * @var int
     */
    public $temperatureUpLimit;
    protected $_name = [
        'operatorId'         => 'operatorId',
        'operatorName'       => 'operatorName',
        'temperatureUpLimit' => 'temperatureUpLimit',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }
        if (null !== $this->operatorName) {
            $res['operatorName'] = $this->operatorName;
        }
        if (null !== $this->temperatureUpLimit) {
            $res['temperatureUpLimit'] = $this->temperatureUpLimit;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AddSchoolConfigRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }
        if (isset($map['operatorName'])) {
            $model->operatorName = $map['operatorName'];
        }
        if (isset($map['temperatureUpLimit'])) {
            $model->temperatureUpLimit = $map['temperatureUpLimit'];
        }

        return $model;
    }
}
