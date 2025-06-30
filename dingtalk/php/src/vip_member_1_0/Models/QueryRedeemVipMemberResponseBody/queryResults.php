<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vvip_member_1_0\Models\QueryRedeemVipMemberResponseBody;

use AlibabaCloud\Tea\Model;

class queryResults extends Model
{
    /**
     * @var string
     */
    public $action;

    /**
     * @var string
     */
    public $actionTime;

    /**
     * @var string
     */
    public $dingtalkId;

    /**
     * @var int
     */
    public $duration;

    /**
     * @var string
     */
    public $nick;
    protected $_name = [
        'action' => 'action',
        'actionTime' => 'actionTime',
        'dingtalkId' => 'dingtalkId',
        'duration' => 'duration',
        'nick' => 'nick',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->action) {
            $res['action'] = $this->action;
        }
        if (null !== $this->actionTime) {
            $res['actionTime'] = $this->actionTime;
        }
        if (null !== $this->dingtalkId) {
            $res['dingtalkId'] = $this->dingtalkId;
        }
        if (null !== $this->duration) {
            $res['duration'] = $this->duration;
        }
        if (null !== $this->nick) {
            $res['nick'] = $this->nick;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return queryResults
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['action'])) {
            $model->action = $map['action'];
        }
        if (isset($map['actionTime'])) {
            $model->actionTime = $map['actionTime'];
        }
        if (isset($map['dingtalkId'])) {
            $model->dingtalkId = $map['dingtalkId'];
        }
        if (isset($map['duration'])) {
            $model->duration = $map['duration'];
        }
        if (isset($map['nick'])) {
            $model->nick = $map['nick'];
        }

        return $model;
    }
}
