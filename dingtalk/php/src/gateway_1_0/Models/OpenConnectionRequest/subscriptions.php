<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vgateway_1_0\Models\OpenConnectionRequest;

use AlibabaCloud\Tea\Model;

class subscriptions extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example /v1.0/im/bot/messages/get
     *
     * @var string
     */
    public $topic;

    /**
     * @description This parameter is required.
     *
     * @example EVENT
     *
     * @var string
     */
    public $type;
    protected $_name = [
        'topic' => 'topic',
        'type'  => 'type',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->topic) {
            $res['topic'] = $this->topic;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return subscriptions
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['topic'])) {
            $model->topic = $map['topic'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }

        return $model;
    }
}
