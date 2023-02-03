<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryConferenceMembersResponseBody;

use AlibabaCloud\Tea\Model;

class memberModels extends Model
{
    /**
     * @description 成员状态
     * 6 离会
     * @var int
     */
    public $attendStatus;

    /**
     * @description 是否为联席主持人
     *
     * @var bool
     */
    public $coHost;

    /**
     * @description 会议id
     *
     * @var string
     */
    public $conferenceId;

    /**
     * @description 在会时长
     *
     * @var int
     */
    public $duration;

    /**
     * @description 是否为主持人
     *
     * @var bool
     */
    public $host;

    /**
     * @description 入会时间
     *
     * @var int
     */
    public $joinTime;

    /**
     * @description 离会时间
     *
     * @var int
     */
    public $leaveTime;

    /**
     * @description 是否为非会议所属企业内成员
     *
     * @var bool
     */
    public $outerOrgMember;

    /**
     * @description 是否为pstn入会
     *
     * @var bool
     */
    public $pstnJoin;

    /**
     * @description 用户unionId
     *
     * @var string
     */
    public $unionId;

    /**
     * @description 成员昵称
     *
     * @var string
     */
    public $userNick;
    protected $_name = [
        'attendStatus'   => 'attendStatus',
        'coHost'         => 'coHost',
        'conferenceId'   => 'conferenceId',
        'duration'       => 'duration',
        'host'           => 'host',
        'joinTime'       => 'joinTime',
        'leaveTime'      => 'leaveTime',
        'outerOrgMember' => 'outerOrgMember',
        'pstnJoin'       => 'pstnJoin',
        'unionId'        => 'unionId',
        'userNick'       => 'userNick',
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
        if (null !== $this->coHost) {
            $res['coHost'] = $this->coHost;
        }
        if (null !== $this->conferenceId) {
            $res['conferenceId'] = $this->conferenceId;
        }
        if (null !== $this->duration) {
            $res['duration'] = $this->duration;
        }
        if (null !== $this->host) {
            $res['host'] = $this->host;
        }
        if (null !== $this->joinTime) {
            $res['joinTime'] = $this->joinTime;
        }
        if (null !== $this->leaveTime) {
            $res['leaveTime'] = $this->leaveTime;
        }
        if (null !== $this->outerOrgMember) {
            $res['outerOrgMember'] = $this->outerOrgMember;
        }
        if (null !== $this->pstnJoin) {
            $res['pstnJoin'] = $this->pstnJoin;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }
        if (null !== $this->userNick) {
            $res['userNick'] = $this->userNick;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return memberModels
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['attendStatus'])) {
            $model->attendStatus = $map['attendStatus'];
        }
        if (isset($map['coHost'])) {
            $model->coHost = $map['coHost'];
        }
        if (isset($map['conferenceId'])) {
            $model->conferenceId = $map['conferenceId'];
        }
        if (isset($map['duration'])) {
            $model->duration = $map['duration'];
        }
        if (isset($map['host'])) {
            $model->host = $map['host'];
        }
        if (isset($map['joinTime'])) {
            $model->joinTime = $map['joinTime'];
        }
        if (isset($map['leaveTime'])) {
            $model->leaveTime = $map['leaveTime'];
        }
        if (isset($map['outerOrgMember'])) {
            $model->outerOrgMember = $map['outerOrgMember'];
        }
        if (isset($map['pstnJoin'])) {
            $model->pstnJoin = $map['pstnJoin'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }
        if (isset($map['userNick'])) {
            $model->userNick = $map['userNick'];
        }

        return $model;
    }
}
