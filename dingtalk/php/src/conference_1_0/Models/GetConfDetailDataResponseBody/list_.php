<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\GetConfDetailDataResponseBody;

use AlibabaCloud\Tea\Model;

class list_ extends Model
{
    /**
     * @example true
     *
     * @var string
     */
    public $belongOrg;

    /**
     * @example 6449d8a6414xxxxxxxx01464af9f0
     *
     * @var string
     */
    public $conferenceId;

    /**
     * @example Mac
     *
     * @var string
     */
    public $deviceType;

    /**
     * @example 974000
     *
     * @var int
     */
    public $duration;

    /**
     * @example 1682561199000
     *
     * @var int
     */
    public $joinTime;

    /**
     * @example 1682562173000
     *
     * @var int
     */
    public $leaveTime;

    /**
     * @example -1
     *
     * @var string
     */
    public $networkQuality;

    /**
     * @example 张三
     *
     * @var string
     */
    public $nick;

    /**
     * @example 参会人
     *
     * @var string
     */
    public $role;

    /**
     * @example xxxx
     *
     * @var string
     */
    public $sessionId;

    /**
     * @example 已离开
     *
     * @var string
     */
    public $status;

    /**
     * @example njMTqKo9xxxxEiE
     *
     * @var string
     */
    public $unionId;

    /**
     * @example 6.1.1
     *
     * @var string
     */
    public $version;
    protected $_name = [
        'belongOrg' => 'belongOrg',
        'conferenceId' => 'conferenceId',
        'deviceType' => 'deviceType',
        'duration' => 'duration',
        'joinTime' => 'joinTime',
        'leaveTime' => 'leaveTime',
        'networkQuality' => 'networkQuality',
        'nick' => 'nick',
        'role' => 'role',
        'sessionId' => 'sessionId',
        'status' => 'status',
        'unionId' => 'unionId',
        'version' => 'version',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->belongOrg) {
            $res['belongOrg'] = $this->belongOrg;
        }
        if (null !== $this->conferenceId) {
            $res['conferenceId'] = $this->conferenceId;
        }
        if (null !== $this->deviceType) {
            $res['deviceType'] = $this->deviceType;
        }
        if (null !== $this->duration) {
            $res['duration'] = $this->duration;
        }
        if (null !== $this->joinTime) {
            $res['joinTime'] = $this->joinTime;
        }
        if (null !== $this->leaveTime) {
            $res['leaveTime'] = $this->leaveTime;
        }
        if (null !== $this->networkQuality) {
            $res['networkQuality'] = $this->networkQuality;
        }
        if (null !== $this->nick) {
            $res['nick'] = $this->nick;
        }
        if (null !== $this->role) {
            $res['role'] = $this->role;
        }
        if (null !== $this->sessionId) {
            $res['sessionId'] = $this->sessionId;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }
        if (null !== $this->version) {
            $res['version'] = $this->version;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return list_
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['belongOrg'])) {
            $model->belongOrg = $map['belongOrg'];
        }
        if (isset($map['conferenceId'])) {
            $model->conferenceId = $map['conferenceId'];
        }
        if (isset($map['deviceType'])) {
            $model->deviceType = $map['deviceType'];
        }
        if (isset($map['duration'])) {
            $model->duration = $map['duration'];
        }
        if (isset($map['joinTime'])) {
            $model->joinTime = $map['joinTime'];
        }
        if (isset($map['leaveTime'])) {
            $model->leaveTime = $map['leaveTime'];
        }
        if (isset($map['networkQuality'])) {
            $model->networkQuality = $map['networkQuality'];
        }
        if (isset($map['nick'])) {
            $model->nick = $map['nick'];
        }
        if (isset($map['role'])) {
            $model->role = $map['role'];
        }
        if (isset($map['sessionId'])) {
            $model->sessionId = $map['sessionId'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }
        if (isset($map['version'])) {
            $model->version = $map['version'];
        }

        return $model;
    }
}
