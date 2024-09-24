<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class GroupQueryByOpenIdRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $secretKey;
    protected $_name = [
        'openConversationId' => 'openConversationId',
        'secretKey'          => 'secretKey',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }
        if (null !== $this->secretKey) {
            $res['secretKey'] = $this->secretKey;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GroupQueryByOpenIdRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['secretKey'])) {
            $model->secretKey = $map['secretKey'];
        }

        return $model;
    }
}
