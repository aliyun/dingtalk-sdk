<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\GetSubscribedCalendarResponseBody;

use AlibabaCloud\Tea\Model;

class subscribeScope extends Model
{
    /**
     * @description 可订阅组织
     *
     * @var string[]
     */
    public $corpIds;

    /**
     * @description 可订阅群组
     *
     * @var string[]
     */
    public $openConversationIds;

    /**
     * @description 可订阅用户
     *
     * @var string[]
     */
    public $unionIds;
    protected $_name = [
        'corpIds'             => 'corpIds',
        'openConversationIds' => 'openConversationIds',
        'unionIds'            => 'unionIds',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->corpIds) {
            $res['corpIds'] = $this->corpIds;
        }
        if (null !== $this->openConversationIds) {
            $res['openConversationIds'] = $this->openConversationIds;
        }
        if (null !== $this->unionIds) {
            $res['unionIds'] = $this->unionIds;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return subscribeScope
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['corpIds'])) {
            if (!empty($map['corpIds'])) {
                $model->corpIds = $map['corpIds'];
            }
        }
        if (isset($map['openConversationIds'])) {
            if (!empty($map['openConversationIds'])) {
                $model->openConversationIds = $map['openConversationIds'];
            }
        }
        if (isset($map['unionIds'])) {
            if (!empty($map['unionIds'])) {
                $model->unionIds = $map['unionIds'];
            }
        }

        return $model;
    }
}
