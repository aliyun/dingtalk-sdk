<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class RosterMetaFieldOptionsUpdateShrinkRequest extends Model
{
    /**
     * @var int
     */
    public $appAgentId;

    /**
     * @var string
     */
    public $bodyShrink;
    protected $_name = [
        'appAgentId' => 'appAgentId',
        'bodyShrink' => 'body',
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
        if (null !== $this->bodyShrink) {
            $res['body'] = $this->bodyShrink;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return RosterMetaFieldOptionsUpdateShrinkRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appAgentId'])) {
            $model->appAgentId = $map['appAgentId'];
        }
        if (isset($map['body'])) {
            $model->bodyShrink = $map['body'];
        }

        return $model;
    }
}
