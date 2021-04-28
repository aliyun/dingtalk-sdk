<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\QueryServiceGroupMessageReadStatusResponseBody;

use AlibabaCloud\Tea\Model;

class records extends Model
{
    /**
     * @description 已读人员为企业员工则有值
     *
     * @var string
     */
    public $receiverUserId;

    /**
     * @description 已读人员为非企业员工则有值
     *
     * @var string
     */
    public $receiverUnionId;

    /**
     * @description 状态：已读1/未读0
     *
     * @var int
     */
    public $readStatus;
    protected $_name = [
        'receiverUserId'  => 'receiverUserId',
        'receiverUnionId' => 'receiverUnionId',
        'readStatus'      => 'readStatus',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->receiverUserId) {
            $res['receiverUserId'] = $this->receiverUserId;
        }
        if (null !== $this->receiverUnionId) {
            $res['receiverUnionId'] = $this->receiverUnionId;
        }
        if (null !== $this->readStatus) {
            $res['readStatus'] = $this->readStatus;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return records
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['receiverUserId'])) {
            $model->receiverUserId = $map['receiverUserId'];
        }
        if (isset($map['receiverUnionId'])) {
            $model->receiverUnionId = $map['receiverUnionId'];
        }
        if (isset($map['readStatus'])) {
            $model->readStatus = $map['readStatus'];
        }

        return $model;
    }
}
