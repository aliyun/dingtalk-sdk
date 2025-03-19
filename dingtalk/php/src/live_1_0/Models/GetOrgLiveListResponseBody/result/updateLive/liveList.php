<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models\GetOrgLiveListResponseBody\result\updateLive;

use AlibabaCloud\Tea\Model;

class liveList extends Model
{
    /**
     * @var string
     */
    public $anchorNickname;

    /**
     * @var string
     */
    public $anchorUnionId;

    /**
     * @var int
     */
    public $liveEndTime;

    /**
     * @var int
     */
    public $liveStartTime;

    /**
     * @var string
     */
    public $liveUuid;

    /**
     * @var string
     */
    public $title;
    protected $_name = [
        'anchorNickname' => 'anchorNickname',
        'anchorUnionId' => 'anchorUnionId',
        'liveEndTime' => 'liveEndTime',
        'liveStartTime' => 'liveStartTime',
        'liveUuid' => 'liveUuid',
        'title' => 'title',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->anchorNickname) {
            $res['anchorNickname'] = $this->anchorNickname;
        }
        if (null !== $this->anchorUnionId) {
            $res['anchorUnionId'] = $this->anchorUnionId;
        }
        if (null !== $this->liveEndTime) {
            $res['liveEndTime'] = $this->liveEndTime;
        }
        if (null !== $this->liveStartTime) {
            $res['liveStartTime'] = $this->liveStartTime;
        }
        if (null !== $this->liveUuid) {
            $res['liveUuid'] = $this->liveUuid;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return liveList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['anchorNickname'])) {
            $model->anchorNickname = $map['anchorNickname'];
        }
        if (isset($map['anchorUnionId'])) {
            $model->anchorUnionId = $map['anchorUnionId'];
        }
        if (isset($map['liveEndTime'])) {
            $model->liveEndTime = $map['liveEndTime'];
        }
        if (isset($map['liveStartTime'])) {
            $model->liveStartTime = $map['liveStartTime'];
        }
        if (isset($map['liveUuid'])) {
            $model->liveUuid = $map['liveUuid'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }

        return $model;
    }
}
