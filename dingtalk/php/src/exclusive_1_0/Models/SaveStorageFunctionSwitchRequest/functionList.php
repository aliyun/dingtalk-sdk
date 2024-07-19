<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\SaveStorageFunctionSwitchRequest;

use AlibabaCloud\Tea\Model;

class functionList extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $functionKey;

    /**
     * @description This parameter is required.
     *
     * @example 1
     *
     * @var string
     */
    public $functionValue;
    protected $_name = [
        'functionKey'   => 'functionKey',
        'functionValue' => 'functionValue',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->functionKey) {
            $res['functionKey'] = $this->functionKey;
        }
        if (null !== $this->functionValue) {
            $res['functionValue'] = $this->functionValue;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return functionList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['functionKey'])) {
            $model->functionKey = $map['functionKey'];
        }
        if (isset($map['functionValue'])) {
            $model->functionValue = $map['functionValue'];
        }

        return $model;
    }
}
