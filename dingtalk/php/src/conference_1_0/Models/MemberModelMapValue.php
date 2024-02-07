<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models;

use AlibabaCloud\Tea\Model;

class MemberModelMapValue extends Model
{
    /**
     * @example 2iPOLbpUNMLzB5LuwggiiqiPwiEiE
     *
     * @var string
     */
    public $unionId;

    /**
     * @example 654058f2411fe90147e68780
     *
     * @var string
     */
    public $conferenceId;

    /**
     * @example 测试昵称
     *
     * @var string
     */
    public $userNick;

    /**
     * @example 1699347295876
     *
     * @var int
     */
    public $joinTime;

    /**
     * @example 1699347395876
     *
     * @var int
     */
    public $leaveTime;

    /**
     * @example 100000
     *
     * @var int
     */
    public $duration;

    /**
     * @example 1：初始化  2：呼叫中  3：活跃（在会）  4：入会失败（拒接等）  5：被踢  6：离会
     *
     * @var int
     */
    public $attendStatus;

    /**
     * @example true：是  false：否
     *
     * @var bool
     */
    public $host;

    /**
     * @example true：是  false：否
     *
     * @var bool
     */
    public $coHost;

    /**
     * @example true：是  false：否
     *
     * @var bool
     */
    public $outerOrgMember;

    /**
     * @example true：是  false：否
     *
     * @var bool
     */
    public $pstnJoin;

    /**
     * @example Win Mac iOS Android
     *
     * @var string
     */
    public $deviceType;
    protected $_name = [
        'unionId'        => 'unionId',
        'conferenceId'   => 'conferenceId',
        'userNick'       => 'userNick',
        'joinTime'       => 'joinTime',
        'leaveTime'      => 'leaveTime',
        'duration'       => 'duration',
        'attendStatus'   => 'attendStatus',
        'host'           => 'host',
        'coHost'         => 'coHost',
        'outerOrgMember' => 'outerOrgMember',
        'pstnJoin'       => 'pstnJoin',
        'deviceType'     => 'deviceType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }
        if (null !== $this->conferenceId) {
            $res['conferenceId'] = $this->conferenceId;
        }
        if (null !== $this->userNick) {
            $res['userNick'] = $this->userNick;
        }
        if (null !== $this->joinTime) {
            $res['joinTime'] = $this->joinTime;
        }
        if (null !== $this->leaveTime) {
            $res['leaveTime'] = $this->leaveTime;
        }
        if (null !== $this->duration) {
            $res['duration'] = $this->duration;
        }
        if (null !== $this->attendStatus) {
            $res['attendStatus'] = $this->attendStatus;
        }
        if (null !== $this->host) {
            $res['host'] = $this->host;
        }
        if (null !== $this->coHost) {
            $res['coHost'] = $this->coHost;
        }
        if (null !== $this->outerOrgMember) {
            $res['outerOrgMember'] = $this->outerOrgMember;
        }
        if (null !== $this->pstnJoin) {
            $res['pstnJoin'] = $this->pstnJoin;
        }
        if (null !== $this->deviceType) {
            $res['deviceType'] = $this->deviceType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return MemberModelMapValue
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }
        if (isset($map['conferenceId'])) {
            $model->conferenceId = $map['conferenceId'];
        }
        if (isset($map['userNick'])) {
            $model->userNick = $map['userNick'];
        }
        if (isset($map['joinTime'])) {
            $model->joinTime = $map['joinTime'];
        }
        if (isset($map['leaveTime'])) {
            $model->leaveTime = $map['leaveTime'];
        }
        if (isset($map['duration'])) {
            $model->duration = $map['duration'];
        }
        if (isset($map['attendStatus'])) {
            $model->attendStatus = $map['attendStatus'];
        }
        if (isset($map['host'])) {
            $model->host = $map['host'];
        }
        if (isset($map['coHost'])) {
            $model->coHost = $map['coHost'];
        }
        if (isset($map['outerOrgMember'])) {
            $model->outerOrgMember = $map['outerOrgMember'];
        }
        if (isset($map['pstnJoin'])) {
            $model->pstnJoin = $map['pstnJoin'];
        }
        if (isset($map['deviceType'])) {
            $model->deviceType = $map['deviceType'];
        }

        return $model;
    }
}
