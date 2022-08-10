<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\QueryLiveWatchUserListResponseBody\result;

use AlibabaCloud\Tea\Model;

class orgUsesList extends Model
{
    /**
     * @description 部门名称
     *
     * @var string
     */
    public $deptName;

    /**
     * @description 姓名
     *
     * @var string
     */
    public $name;

    /**
     * @description 用户id
     *
     * @var string
     */
    public $unionId;

    /**
     * @description 员工id
     *
     * @var string
     */
    public $userId;

    /**
     * @description 观看直播时长
     *
     * @var int
     */
    public $watchLiveTime;

    /**
     * @description 观看回放时长
     *
     * @var int
     */
    public $watchPlaybackTime;

    /**
     * @description 回放观看进度
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
