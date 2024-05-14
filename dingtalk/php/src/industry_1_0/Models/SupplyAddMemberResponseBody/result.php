<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SupplyAddMemberResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example NORMAL
     *
     * @var string
     */
    public $dingMemberStatus;

    /**
     * @description This parameter is required.
     *
     * @example 12345abc
     *
     * @var string
     */
    public $unionId;

    /**
     * @example 12345abc
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'dingMemberStatus' => 'dingMemberStatus',
        'unionId'          => 'unionId',
        'userId'           => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->dingMemberStatus) {
            $res['dingMemberStatus'] = $this->dingMemberStatus;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dingMemberStatus'])) {
            $model->dingMemberStatus = $map['dingMemberStatus'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
