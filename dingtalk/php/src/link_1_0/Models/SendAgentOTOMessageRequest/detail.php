<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\SendAgentOTOMessageRequest;

use AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\SendAgentOTOMessageRequest\detail\messageBody;
use AlibabaCloud\Tea\Model;

class detail extends Model
{
    /**
     * @var messageBody
     */
    public $messageBody;

    /**
     * @example text
     *
     * @var string
     */
    public $msgType;

    /**
     * @example sid002b6dbb4f963e93e0
     *
     * @var string
     */
    public $sessionId;

    /**
     * @example user0001
     *
     * @var string
     */
    public $userId;

    /**
     * @example 1234-5678-000
     *
     * @var string
     */
    public $uuid;
    protected $_name = [
        'messageBody' => 'messageBody',
        'msgType'     => 'msgType',
        'sessionId'   => 'sessionId',
        'userId'      => 'userId',
        'uuid'        => 'uuid',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->messageBody) {
            $res['messageBody'] = null !== $this->messageBody ? $this->messageBody->toMap() : null;
        }
        if (null !== $this->msgType) {
            $res['msgType'] = $this->msgType;
        }
        if (null !== $this->sessionId) {
            $res['sessionId'] = $this->sessionId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->uuid) {
            $res['uuid'] = $this->uuid;
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
        if (isset($map['messageBody'])) {
            $model->messageBody = messageBody::fromMap($map['messageBody']);
        }
        if (isset($map['msgType'])) {
            $model->msgType = $map['msgType'];
        }
        if (isset($map['sessionId'])) {
            $model->sessionId = $map['sessionId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['uuid'])) {
            $model->uuid = $map['uuid'];
        }

        return $model;
    }
}
