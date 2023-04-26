<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryConferenceInfoBatchResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryConferenceInfoBatchResponseBody\infos\userList;
use AlibabaCloud\Tea\Model;

class infos extends Model
{
    /**
     * @var string
     */
    public $conferenceId;

    /**
     * @example 0-正常，1-麦克风静音，2-摄像头关闭，4-强制全员静音
     *
     * @var int
     */
    public $mediaStatus;

    /**
     * @var int
     */
    public $startTime;

    /**
     * @example 0-初始化，1-会议结束，2-会议开始
     *
     * @var int
     */
    public $status;

    /**
     * @var string
     */
    public $title;

    /**
     * @var userList[]
     */
    public $userList;
    protected $_name = [
        'conferenceId' => 'conferenceId',
        'mediaStatus'  => 'mediaStatus',
        'startTime'    => 'startTime',
        'status'       => 'status',
        'title'        => 'title',
        'userList'     => 'userList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->conferenceId) {
            $res['conferenceId'] = $this->conferenceId;
        }
        if (null !== $this->mediaStatus) {
            $res['mediaStatus'] = $this->mediaStatus;
        }
        if (null !== $this->startTime) {
            $res['startTime'] = $this->startTime;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->userList) {
            $res['userList'] = [];
            if (null !== $this->userList && \is_array($this->userList)) {
                $n = 0;
                foreach ($this->userList as $item) {
                    $res['userList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return infos
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['conferenceId'])) {
            $model->conferenceId = $map['conferenceId'];
        }
        if (isset($map['mediaStatus'])) {
            $model->mediaStatus = $map['mediaStatus'];
        }
        if (isset($map['startTime'])) {
            $model->startTime = $map['startTime'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['userList'])) {
            if (!empty($map['userList'])) {
                $model->userList = [];
                $n               = 0;
                foreach ($map['userList'] as $item) {
                    $model->userList[$n++] = null !== $item ? userList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
