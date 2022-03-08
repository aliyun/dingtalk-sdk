<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryConferenceInfoBatchResponseBody\infos;

use AlibabaCloud\Tea\Model;

class userList extends Model
{
    /**
     * @description 在会状态
     *
     * @var int
     */
    public $attendStatus;

    /**
     * @description 摄像头状态
     *
     * @var int
     */
    public $cameraStatus;

    /**
     * @description 麦克风状态
     *
     * @var int
     */
    public $micStatus;

    /**
     * @description 名称
     *
     * @var string
     */
    public $nick;

    /**
     * @description 拒绝原因
     *
     * @var string
     */
    public $rejectDescription;

    /**
     * @description 用户id
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'attendStatus'      => 'attendStatus',
        'cameraStatus'      => 'cameraStatus',
        'micStatus'         => 'micStatus',
        'nick'              => 'nick',
        'rejectDescription' => 'rejectDescription',
        'userId'            => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->attendStatus) {
            $res['attendStatus'] = $this->attendStatus;
        }
        if (null !== $this->cameraStatus) {
            $res['cameraStatus'] = $this->cameraStatus;
        }
        if (null !== $this->micStatus) {
            $res['micStatus'] = $this->micStatus;
        }
        if (null !== $this->nick) {
            $res['nick'] = $this->nick;
        }
        if (null !== $this->rejectDescription) {
            $res['rejectDescription'] = $this->rejectDescription;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return userList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['attendStatus'])) {
            $model->attendStatus = $map['attendStatus'];
        }
        if (isset($map['cameraStatus'])) {
            $model->cameraStatus = $map['cameraStatus'];
        }
        if (isset($map['micStatus'])) {
            $model->micStatus = $map['micStatus'];
        }
        if (isset($map['nick'])) {
            $model->nick = $map['nick'];
        }
        if (isset($map['rejectDescription'])) {
            $model->rejectDescription = $map['rejectDescription'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
