<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\ServiceWindowMessageBatchPushRequest;

use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\ServiceWindowMessageBatchPushRequest\detail\messageBody;
use AlibabaCloud\Tea\Model;

class detail extends Model
{
    /**
     * @var string
     */
    public $msgType;

    /**
     * @var string
     */
    public $uuid;

    /**
     * @var string
     */
    public $bizRequestId;

    /**
     * @var string[]
     */
    public $userIdList;

    /**
     * @var messageBody
     */
    public $messageBody;

    /**
     * @var bool
     */
    public $sendToAll;
    protected $_name = [
        'msgType'      => 'msgType',
        'uuid'         => 'uuid',
        'bizRequestId' => 'bizRequestId',
        'userIdList'   => 'userIdList',
        'messageBody'  => 'messageBody',
        'sendToAll'    => 'sendToAll',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->msgType) {
            $res['msgType'] = $this->msgType;
        }
        if (null !== $this->uuid) {
            $res['uuid'] = $this->uuid;
        }
        if (null !== $this->bizRequestId) {
            $res['bizRequestId'] = $this->bizRequestId;
        }
        if (null !== $this->userIdList) {
            $res['userIdList'] = $this->userIdList;
        }
        if (null !== $this->messageBody) {
            $res['messageBody'] = null !== $this->messageBody ? $this->messageBody->toMap() : null;
        }
        if (null !== $this->sendToAll) {
            $res['sendToAll'] = $this->sendToAll;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return detail
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['msgType'])) {
            $model->msgType = $map['msgType'];
        }
        if (isset($map['uuid'])) {
            $model->uuid = $map['uuid'];
        }
        if (isset($map['bizRequestId'])) {
            $model->bizRequestId = $map['bizRequestId'];
        }
        if (isset($map['userIdList'])) {
            if (!empty($map['userIdList'])) {
                $model->userIdList = $map['userIdList'];
            }
        }
        if (isset($map['messageBody'])) {
            $model->messageBody = messageBody::fromMap($map['messageBody']);
        }
        if (isset($map['sendToAll'])) {
            $model->sendToAll = $map['sendToAll'];
        }

        return $model;
    }
}
