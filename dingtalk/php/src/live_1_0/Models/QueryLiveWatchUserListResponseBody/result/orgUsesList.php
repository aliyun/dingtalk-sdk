<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\QueryLiveWatchUserListResponseBody\result;

use AlibabaCloud\Tea\Model;

class orgUsesList extends Model
{
    /**
     * @example xxx.设计部
     *
     * @var string
     */
    public $deptName;

    /**
     * @example 李四
     *
     * @var string
     */
    public $name;

    /**
     * @example DC7wZGOSueEEIGOf3WKwWgiEiE
     *
     * @var string
     */
    public $unionId;

    /**
     * @example 214675
     *
     * @var string
     */
    public $userId;

    /**
     * @example 189930
     *
     * @var int
     */
    public $watchLiveTime;

    /**
     * @example 23667
     *
     * @var int
     */
    public $watchPlaybackTime;

    /**
     * @example 2330
     *
     * @var int
     */
    public $watchProgressMs;
    protected $_name = [
        'deptName'          => 'deptName',
        'name'              => 'name',
        'unionId'           => 'unionId',
        'userId'            => 'userId',
        'watchLiveTime'     => 'watchLiveTime',
        'watchPlaybackTime' => 'watchPlaybackTime',
        'watchProgressMs'   => 'watchProgressMs',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->deptName) {
            $res['deptName'] = $this->deptName;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->watchLiveTime) {
            $res['watchLiveTime'] = $this->watchLiveTime;
        }
        if (null !== $this->watchPlaybackTime) {
            $res['watchPlaybackTime'] = $this->watchPlaybackTime;
        }
        if (null !== $this->watchProgressMs) {
            $res['watchProgressMs'] = $this->watchProgressMs;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return orgUsesList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deptName'])) {
            $model->deptName = $map['deptName'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['watchLiveTime'])) {
            $model->watchLiveTime = $map['watchLiveTime'];
        }
        if (isset($map['watchPlaybackTime'])) {
            $model->watchPlaybackTime = $map['watchPlaybackTime'];
        }
        if (isset($map['watchProgressMs'])) {
            $model->watchProgressMs = $map['watchProgressMs'];
        }

        return $model;
    }
}
