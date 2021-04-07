<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateGroupResponseBody extends Model
{
    /**
     * @description 开放群ID
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @description 入群url
     *
     * @var string
     */
    public $groupUrl;
    protected $_name = [
        'openConversationId' => 'openConversationId',
        'groupUrl'           => 'groupUrl',
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
        if (null !== $this->groupUrl) {
            $res['groupUrl'] = $this->groupUrl;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateGroupResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['groupUrl'])) {
            $model->groupUrl = $map['groupUrl'];
        }

        return $model;
    }
}
