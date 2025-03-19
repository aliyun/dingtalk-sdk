<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models;

use AlibabaCloud\Tea\Model;

class SubscribeLiveRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 3dd295eb-17a1-4dfg-ae1b-aa165c5007eb
     *
     * @var string
     */
    public $liveId;

    /**
     * @description This parameter is required.
     *
     * @var bool
     */
    public $subscribe;

    /**
     * @description This parameter is required.
     *
     * @example 6crtQT2XOgPHviiPvXhhiP6gdhiE
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'liveId' => 'liveId',
        'subscribe' => 'subscribe',
        'unionId' => 'unionId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->liveId) {
            $res['liveId'] = $this->liveId;
        }
        if (null !== $this->subscribe) {
            $res['subscribe'] = $this->subscribe;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SubscribeLiveRequest
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
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
