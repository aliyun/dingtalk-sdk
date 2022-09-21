<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetConfBaseInfoByLogicalIdResponseBody extends Model
{
    /**
     * @description 会议ID（仅在会议正式开始后才返回该字段）
     *
     * @var string
     */
    public $conferenceId;

    /**
     * @description 会议逻辑id
     *
     * @var string
     */
    public $logicalConferenceId;

    /**
     * @description 会议创建用户昵称
     *
     * @var string
     */
    public $nickname;

    /**
     * @description 开始时间
     *
     * @var int
     */
    public $startTime;

    /**
     * @description 会议标题
     *
     * @var string
     */
    public $title;

    /**
     * @description 会议创建用户id
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'conferenceId'        => 'conferenceId',
        'logicalConferenceId' => 'logicalConferenceId',
        'nickname'            => 'nickname',
        'startTime'           => 'startTime',
        'title'               => 'title',
        'unionId'             => 'unionId',
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
        if (null !== $this->logicalConferenceId) {
            $res['logicalConferenceId'] = $this->logicalConferenceId;
        }
        if (null !== $this->nickname) {
            $res['nickname'] = $this->nickname;
        }
        if (null !== $this->startTime) {
            $res['startTime'] = $this->startTime;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetConfBaseInfoByLogicalIdResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['conferenceId'])) {
            $model->conferenceId = $map['conferenceId'];
        }
        if (isset($map['logicalConferenceId'])) {
            $model->logicalConferenceId = $map['logicalConferenceId'];
        }
        if (isset($map['nickname'])) {
            $model->nickname = $map['nickname'];
        }
        if (isset($map['startTime'])) {
            $model->startTime = $map['startTime'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
