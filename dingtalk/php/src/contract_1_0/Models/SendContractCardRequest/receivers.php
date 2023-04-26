<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\SendContractCardRequest;

use AlibabaCloud\Tea\Model;

class receivers extends Model
{
    /**
     * @example ding5f62ac8a3c24952ebc961a6cb783455b
     *
     * @var string
     */
    public $corpId;

    /**
     * @example 1622265907855672
     *
     * @var string
     */
    public $userId;

    /**
     * @example 可以为空
     *
     * @var string
     */
    public $userType;
    protected $_name = [
        'corpId'   => 'corpId',
        'userId'   => 'userId',
        'userType' => 'userType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->userType) {
            $res['userType'] = $this->userType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return receivers
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['userType'])) {
            $model->userType = $map['userType'];
        }

        return $model;
    }
}
