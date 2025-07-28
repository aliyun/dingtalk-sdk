<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmail_1_0\Models;

use AlibabaCloud\Tea\Model;

class SendMessageRequest extends Model
{
    /**
     * @var bool
     */
    public $saveToSentItems;
    protected $_name = [
        'saveToSentItems' => 'saveToSentItems',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->saveToSentItems) {
            $res['saveToSentItems'] = $this->saveToSentItems;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SendMessageRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['saveToSentItems'])) {
            $model->saveToSentItems = $map['saveToSentItems'];
        }

        return $model;
    }
}
