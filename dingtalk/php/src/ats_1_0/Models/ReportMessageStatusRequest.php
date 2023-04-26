<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models;

use AlibabaCloud\Tea\Model;

class ReportMessageStatusRequest extends Model
{
    /**
     * @example ddats
     *
     * @var string
     */
    public $bizCode;

    /**
     * @example corp-ABC-prd
     *
     * @var string
     */
    public $channel;

    /**
     * @example INVALID_USER
     *
     * @var string
     */
    public $errorCode;

    /**
     * @example 无效用户
     *
     * @var string
     */
    public $errorMsg;

    /**
     * @example 594c5b30-57bd-4001-8903-4dc64cdc6739
     *
     * @var string
     */
    public $messageId;

    /**
     * @example AppUid@Channel
     *
     * @var string
     */
    public $receiverUserId;

    /**
     * @example AppUid@Channel
     *
     * @var string
     */
    public $senderUserId;
    protected $_name = [
        'bizCode'        => 'bizCode',
        'channel'        => 'channel',
        'errorCode'      => 'errorCode',
        'errorMsg'       => 'errorMsg',
        'messageId'      => 'messageId',
        'receiverUserId' => 'receiverUserId',
        'senderUserId'   => 'senderUserId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizCode) {
            $res['bizCode'] = $this->bizCode;
        }
        if (null !== $this->channel) {
            $res['channel'] = $this->channel;
        }
        if (null !== $this->errorCode) {
            $res['errorCode'] = $this->errorCode;
        }
        if (null !== $this->errorMsg) {
            $res['errorMsg'] = $this->errorMsg;
        }
        if (null !== $this->messageId) {
            $res['messageId'] = $this->messageId;
        }
        if (null !== $this->receiverUserId) {
            $res['receiverUserId'] = $this->receiverUserId;
        }
        if (null !== $this->senderUserId) {
            $res['senderUserId'] = $this->senderUserId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ReportMessageStatusRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizCode'])) {
            $model->bizCode = $map['bizCode'];
        }
        if (isset($map['channel'])) {
            $model->channel = $map['channel'];
        }
        if (isset($map['errorCode'])) {
            $model->errorCode = $map['errorCode'];
        }
        if (isset($map['errorMsg'])) {
            $model->errorMsg = $map['errorMsg'];
        }
        if (isset($map['messageId'])) {
            $model->messageId = $map['messageId'];
        }
        if (isset($map['receiverUserId'])) {
            $model->receiverUserId = $map['receiverUserId'];
        }
        if (isset($map['senderUserId'])) {
            $model->senderUserId = $map['senderUserId'];
        }

        return $model;
    }
}
