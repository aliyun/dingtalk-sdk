<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\RosterMetaFieldOptionsUpdateRequest\body;
use AlibabaCloud\Tea\Model;

class RosterMetaFieldOptionsUpdateRequest extends Model
{
    /**
     * @var int
     */
    public $appAgentId;

    /**
     * @var body
     */
    public $body;
    protected $_name = [
        'appAgentId' => 'appAgentId',
        'body'       => 'body',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->appAgentId) {
            $res['appAgentId'] = $this->appAgentId;
        }
        if (null !== $this->body) {
            $res['body'] = null !== $this->body ? $this->body->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return RosterMetaFieldOptionsUpdateRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appAgentId'])) {
            $model->appAgentId = $map['appAgentId'];
        }
        if (isset($map['body'])) {
            $model->body = body::fromMap($map['body']);
        }

        return $model;
    }
}
