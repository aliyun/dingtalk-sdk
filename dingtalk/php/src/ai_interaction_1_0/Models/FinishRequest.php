<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vai_interaction_1_0\Models;

use AlibabaCloud\Tea\Model;

class FinishRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $conversationToken;
    protected $_name = [
        'conversationToken' => 'conversationToken',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->conversationToken) {
            $res['conversationToken'] = $this->conversationToken;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return FinishRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['conversationToken'])) {
            $model->conversationToken = $map['conversationToken'];
        }

        return $model;
    }
}
