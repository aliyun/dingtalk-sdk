<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryConferenceInfoBatchResponseBody\infos;

use AlibabaCloud\Tea\Model;

class userList extends Model
{
    /**
     * @example 0-未定义,1-初始化,2-加入中,3-在会,4-加入失败,5,被踢出,6-离开
     *
     * @var int
     */
    public $attendStatus;

    /**
     * @example 0-初始化，1-关闭，2-打开
     *
     * @var int
     */
    public $cameraStatus;

    /**
     * @example 0-初始化，1-关闭，2-打开
     *
     * @var int
     */
    public $micStatus;

    /**
     * @var string
     */
    public $nick;

    /**
     * @example 抱歉，正在开会
     *
     * @var string
     */
    public $rejectDescription;

    /**
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
