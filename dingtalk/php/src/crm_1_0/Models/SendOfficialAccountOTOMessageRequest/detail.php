<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\SendOfficialAccountOTOMessageRequest;

use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\SendOfficialAccountOTOMessageRequest\detail\messageBody;
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
     * @var string
     */
    public $unionId;

    /**
     * @var string
     */
    public $userId;

    /**
     * @var string
     */
    public $uuid;
    protected $_name = [
        'messageBody' => 'messageBody',
        'msgType'     => 'msgType',
        'unionId'     => 'unionId',
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
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
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
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
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
