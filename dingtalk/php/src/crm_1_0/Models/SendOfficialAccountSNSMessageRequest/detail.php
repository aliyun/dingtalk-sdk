<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\SendOfficialAccountSNSMessageRequest;

use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\SendOfficialAccountSNSMessageRequest\detail\messageBody;
use AlibabaCloud\Tea\Model;

class detail extends Model
{
    /**
     * @description 消息类型
     *
     * @var string
     */
    public $msgType;

    /**
     * @description 请求唯一 ID
     *
     * @var string
     */
    public $uuid;

    /**
     * @description 消息体
     *
     * @var messageBody
     */
    public $messageBody;
    protected $_name = [
        'msgType'     => 'msgType',
        'uuid'        => 'uuid',
        'messageBody' => 'messageBody',
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
        if (null !== $this->messageBody) {
            $res['messageBody'] = null !== $this->messageBody ? $this->messageBody->toMap() : null;
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
        if (isset($map['messageBody'])) {
            $model->messageBody = messageBody::fromMap($map['messageBody']);
        }

        return $model;
    }
}