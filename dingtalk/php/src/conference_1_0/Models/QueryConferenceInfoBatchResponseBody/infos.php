<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryConferenceInfoBatchResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryConferenceInfoBatchResponseBody\infos\userList;
use AlibabaCloud\Tea\Model;

class infos extends Model
{
    /**
     * @description 会议iD
     *
     * @var string
     */
    public $conferenceId;

    /**
     * @description 媒体状态
     *
     * @var int
     */
    public $mediaStatus;

    /**
     * @description 会议开始时间
     *
     * @var int
     */
    public $startTime;

    /**
     * @description 会议状态
     *
     * @var int
     */
    public $status;

    /**
     * @description 会议名称
     *
     * @var string
     */
    public $title;

    /**
     * @description 参会用户列表
     *
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
