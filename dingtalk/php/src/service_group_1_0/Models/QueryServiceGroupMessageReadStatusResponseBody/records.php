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

    /**
     * @description 接收者昵称
     *
     * @var string
     */
    public $receiverName;

    /**
     * @description 接收者dingtalkId
     *
     * @var string
     */
    public $receiverDingTalkId;
    protected $_name = [
        'receiverUserId'     => 'receiverUserId',
        'receiverUnionId'    => 'receiverUnionId',
        'readStatus'         => 'readStatus',
        'receiverName'       => 'receiverName',
        'receiverDingTalkId' => 'receiverDingTalkId',
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
        if (null !== $this->receiverName) {
            $res['receiverName'] = $this->receiverName;
        }
        if (null !== $this->receiverDingTalkId) {
            $res['receiverDingTalkId'] = $this->receiverDingTalkId;
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
        if (isset($map['receiverName'])) {
            $model->receiverName = $map['receiverName'];
        }
        if (isset($map['receiverDingTalkId'])) {
            $model->receiverDingTalkId = $map['receiverDingTalkId'];
        }

        return $model;
    }
}
