<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\QueryMessageSendResultResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example msghcuh234
     *
     * @var string
     */
    public $openMessageId;

    /**
     * @example 1
     *
     * @var int
     */
    public $sendStatus;
    protected $_name = [
        'openMessageId' => 'openMessageId',
        'sendStatus'    => 'sendStatus',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->openMessageId) {
            $res['openMessageId'] = $this->openMessageId;
        }
        if (null !== $this->sendStatus) {
            $res['sendStatus'] = $this->sendStatus;
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
        if (isset($map['openMessageId'])) {
            $model->openMessageId = $map['openMessageId'];
        }
        if (isset($map['sendStatus'])) {
            $model->sendStatus = $map['sendStatus'];
        }

        return $model;
    }
}
