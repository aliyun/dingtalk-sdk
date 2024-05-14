<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcarbon_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetPersonalCarbonInfoRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example salary
     *
     * @var string
     */
    public $actionType;

    /**
     * @description This parameter is required.
     *
     * @example 23121
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'actionType' => 'actionType',
        'unionId'    => 'unionId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->actionType) {
            $res['actionType'] = $this->actionType;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetPersonalCarbonInfoRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['actionType'])) {
            $model->actionType = $map['actionType'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
