<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlive_activities_1_0\Models\SendLiveActivityRequest;

use AlibabaCloud\Tea\Model;

class activityEventOption extends Model
{
    /**
     * @example 1686903998
     *
     * @var int
     */
    public $dismissalDate;

    /**
     * @example update
     *
     * @var string
     */
    public $pushType;

    /**
     * @example 1686903998
     *
     * @var int
     */
    public $sendDate;

    /**
     * @example 1686903998
     *
     * @var int
     */
    public $staleDate;
    protected $_name = [
        'dismissalDate' => 'dismissalDate',
        'pushType'      => 'pushType',
        'sendDate'      => 'sendDate',
        'staleDate'     => 'staleDate',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->dismissalDate) {
            $res['dismissalDate'] = $this->dismissalDate;
        }
        if (null !== $this->pushType) {
            $res['pushType'] = $this->pushType;
        }
        if (null !== $this->sendDate) {
            $res['sendDate'] = $this->sendDate;
        }
        if (null !== $this->staleDate) {
            $res['staleDate'] = $this->staleDate;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return activityEventOption
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dismissalDate'])) {
            $model->dismissalDate = $map['dismissalDate'];
        }
        if (isset($map['pushType'])) {
            $model->pushType = $map['pushType'];
        }
        if (isset($map['sendDate'])) {
            $model->sendDate = $map['sendDate'];
        }
        if (isset($map['staleDate'])) {
            $model->staleDate = $map['staleDate'];
        }

        return $model;
    }
}
