<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\QuerySubscribeStatusResponseBody\result;

use AlibabaCloud\Tea\Model;

class subscribeStatusDTOS extends Model
{
    /**
     * @description 直播uuid
     *
     * @var string
     */
    public $liveId;

    /**
     * @description 是否订阅 true:订阅 false:非订阅
     *
     * @var bool
     */
    public $subscribe;
    protected $_name = [
        'liveId'    => 'liveId',
        'subscribe' => 'subscribe',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->liveId) {
            $res['liveId'] = $this->liveId;
        }
        if (null !== $this->subscribe) {
            $res['subscribe'] = $this->subscribe;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return subscribeStatusDTOS
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['liveId'])) {
            $model->liveId = $map['liveId'];
        }
        if (isset($map['subscribe'])) {
            $model->subscribe = $map['subscribe'];
        }

        return $model;
    }
}
