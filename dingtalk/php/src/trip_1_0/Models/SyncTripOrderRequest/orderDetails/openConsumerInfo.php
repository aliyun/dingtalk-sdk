<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\SyncTripOrderRequest\orderDetails;

use AlibabaCloud\Tea\Model;

class openConsumerInfo extends Model
{
    /**
     * @var string
     */
    public $corpId;

    /**
     * @var string
     */
    public $name;

    /**
     * @var bool
     */
    public $staffFlag;

    /**
     * @var string
     */
    public $status;

    /**
     * @var string
     */
    public $ticketAmount;

    /**
     * @var string
     */
    public $ticketNo;

    /**
     * @var string
     */
    public $userId;
    protected $_name = [
        'corpId' => 'corpId',
        'name' => 'name',
        'staffFlag' => 'staffFlag',
        'status' => 'status',
        'ticketAmount' => 'ticketAmount',
        'ticketNo' => 'ticketNo',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->staffFlag) {
            $res['staffFlag'] = $this->staffFlag;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->ticketAmount) {
            $res['ticketAmount'] = $this->ticketAmount;
        }
        if (null !== $this->ticketNo) {
            $res['ticketNo'] = $this->ticketNo;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return openConsumerInfo
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['staffFlag'])) {
            $model->staffFlag = $map['staffFlag'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['ticketAmount'])) {
            $model->ticketAmount = $map['ticketAmount'];
        }
        if (isset($map['ticketNo'])) {
            $model->ticketNo = $map['ticketNo'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
