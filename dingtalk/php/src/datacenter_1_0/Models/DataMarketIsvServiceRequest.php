<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models;

use AlibabaCloud\Tea\Model;

class DataMarketIsvServiceRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $accountId;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $apiId;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $args;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'accountId' => 'accountId',
        'apiId' => 'apiId',
        'args' => 'args',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->accountId) {
            $res['accountId'] = $this->accountId;
        }
        if (null !== $this->apiId) {
            $res['apiId'] = $this->apiId;
        }
        if (null !== $this->args) {
            $res['args'] = $this->args;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DataMarketIsvServiceRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['accountId'])) {
            $model->accountId = $map['accountId'];
        }
        if (isset($map['apiId'])) {
            $model->apiId = $map['apiId'];
        }
        if (isset($map['args'])) {
            $model->args = $map['args'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
