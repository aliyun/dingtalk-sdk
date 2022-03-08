<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\QueryServiceGroupMessageReadStatusResponseBody;

use AlibabaCloud\Tea\Model;

class records extends Model
{
    /**
     * @description 状态：已读1/未读0
     *
     * @var int
     */
    public $readStatus;

    /**
     * @description 已读时间
     *
     * @var string
     */
    public $readTimeStr;

    /**
     * @description 接收者dingtalkId
     *
     * @var string
     */
    public $receiverDingTalkId;

    /**
     * @description 接收者昵称
     *
     * @var string
     */
    public $receiverName;

    /**
     * @description 已读人员为非企业员工则有值
     *
     * @var string
     */
    public $receiverUnionId;

    /**
     * @description 已读人员为企业员工则有值
     *
     * @var string
     */
    public $receiverUserId;

    /**
     * @description 发送时间
     *
     * @var string
     */
    public $sendTimeStr;
    protected $_name = [
        'readStatus'         => 'readStatus',
        'readTimeStr'        => 'readTimeStr',
        'receiverDingTalkId' => 'receiverDingTalkId',
        'receiverName'       => 'receiverName',
        'receiverUnionId'    => 'receiverUnionId',
        'receiverUserId'     => 'receiverUserId',
        'sendTimeStr'        => 'sendTimeStr',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->readStatus) {
            $res['readStatus'] = $this->readStatus;
        }
        if (null !== $this->readTimeStr) {
            $res['readTimeStr'] = $this->readTimeStr;
        }
        if (null !== $this->receiverDingTalkId) {
            $res['receiverDingTalkId'] = $this->receiverDingTalkId;
        }
        if (null !== $this->receiverName) {
            $res['receiverName'] = $this->receiverName;
        }
        if (null !== $this->receiverUnionId) {
            $res['receiverUnionId'] = $this->receiverUnionId;
        }
        if (null !== $this->receiverUserId) {
            $res['receiverUserId'] = $this->receiverUserId;
        }
        if (null !== $this->sendTimeStr) {
            $res['sendTimeStr'] = $this->sendTimeStr;
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
        if (isset($map['readStatus'])) {
            $model->readStatus = $map['readStatus'];
        }
        if (isset($map['readTimeStr'])) {
            $model->readTimeStr = $map['readTimeStr'];
        }
        if (isset($map['receiverDingTalkId'])) {
            $model->receiverDingTalkId = $map['receiverDingTalkId'];
        }
        if (isset($map['receiverName'])) {
            $model->receiverName = $map['receiverName'];
        }
        if (isset($map['receiverUnionId'])) {
            $model->receiverUnionId = $map['receiverUnionId'];
        }
        if (isset($map['receiverUserId'])) {
            $model->receiverUserId = $map['receiverUserId'];
        }
        if (isset($map['sendTimeStr'])) {
            $model->sendTimeStr = $map['sendTimeStr'];
        }

        return $model;
    }
}
