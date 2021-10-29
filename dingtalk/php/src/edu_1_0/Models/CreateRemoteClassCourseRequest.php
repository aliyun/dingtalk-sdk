<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateRemoteClassCourseRequest\attendParticipants;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateRemoteClassCourseRequest\teachingParticipant;
use AlibabaCloud\Tea\Model;

class CreateRemoteClassCourseRequest extends Model
{
    /**
     * @description 课程名称
     *
     * @var string
     */
    public $courseName;

    /**
     * @description 开始时间
     *
     * @var int
     */
    public $startTime;

    /**
     * @description 结束时间
     *
     * @var int
     */
    public $endTime;

    /**
     * @description 授课设备
     *
     * @var teachingParticipant
     */
    public $teachingParticipant;

    /**
     * @description 听课设备列表
     *
     * @var attendParticipants[]
     */
    public $attendParticipants;

    /**
     * @description 免登码
     *
     * @var string
     */
    public $authCode;

    /**
     * @var string
     */
    public $dingClientId;

    /**
     * @var string
     */
    public $dingSuiteKey;

    /**
     * @var int
     */
    public $dingTokenGrantType;

    /**
     * @var int
     */
    public $dingOauthAppId;

    /**
     * @var int
     */
    public $dingIsvOrgId;

    /**
     * @var string
     */
    public $dingCorpId;
    protected $_name = [
        'courseName'          => 'courseName',
        'startTime'           => 'startTime',
        'endTime'             => 'endTime',
        'teachingParticipant' => 'teachingParticipant',
        'attendParticipants'  => 'attendParticipants',
        'authCode'            => 'authCode',
        'dingClientId'        => 'dingClientId',
        'dingSuiteKey'        => 'dingSuiteKey',
        'dingTokenGrantType'  => 'dingTokenGrantType',
        'dingOauthAppId'      => 'dingOauthAppId',
        'dingIsvOrgId'        => 'dingIsvOrgId',
        'dingCorpId'          => 'dingCorpId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->courseName) {
            $res['courseName'] = $this->courseName;
        }
        if (null !== $this->startTime) {
            $res['startTime'] = $this->startTime;
        }
        if (null !== $this->endTime) {
            $res['endTime'] = $this->endTime;
        }
        if (null !== $this->teachingParticipant) {
            $res['teachingParticipant'] = null !== $this->teachingParticipant ? $this->teachingParticipant->toMap() : null;
        }
        if (null !== $this->attendParticipants) {
            $res['attendParticipants'] = [];
            if (null !== $this->attendParticipants && \is_array($this->attendParticipants)) {
                $n = 0;
                foreach ($this->attendParticipants as $item) {
                    $res['attendParticipants'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->authCode) {
            $res['authCode'] = $this->authCode;
        }
        if (null !== $this->dingClientId) {
            $res['dingClientId'] = $this->dingClientId;
        }
        if (null !== $this->dingSuiteKey) {
            $res['dingSuiteKey'] = $this->dingSuiteKey;
        }
        if (null !== $this->dingTokenGrantType) {
            $res['dingTokenGrantType'] = $this->dingTokenGrantType;
        }
        if (null !== $this->dingOauthAppId) {
            $res['dingOauthAppId'] = $this->dingOauthAppId;
        }
        if (null !== $this->dingIsvOrgId) {
            $res['dingIsvOrgId'] = $this->dingIsvOrgId;
        }
        if (null !== $this->dingCorpId) {
            $res['dingCorpId'] = $this->dingCorpId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateRemoteClassCourseRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['courseName'])) {
            $model->courseName = $map['courseName'];
        }
        if (isset($map['startTime'])) {
            $model->startTime = $map['startTime'];
        }
        if (isset($map['endTime'])) {
            $model->endTime = $map['endTime'];
        }
        if (isset($map['teachingParticipant'])) {
            $model->teachingParticipant = teachingParticipant::fromMap($map['teachingParticipant']);
        }
        if (isset($map['attendParticipants'])) {
            if (!empty($map['attendParticipants'])) {
                $model->attendParticipants = [];
                $n                         = 0;
                foreach ($map['attendParticipants'] as $item) {
                    $model->attendParticipants[$n++] = null !== $item ? attendParticipants::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['authCode'])) {
            $model->authCode = $map['authCode'];
        }
        if (isset($map['dingClientId'])) {
            $model->dingClientId = $map['dingClientId'];
        }
        if (isset($map['dingSuiteKey'])) {
            $model->dingSuiteKey = $map['dingSuiteKey'];
        }
        if (isset($map['dingTokenGrantType'])) {
            $model->dingTokenGrantType = $map['dingTokenGrantType'];
        }
        if (isset($map['dingOauthAppId'])) {
            $model->dingOauthAppId = $map['dingOauthAppId'];
        }
        if (isset($map['dingIsvOrgId'])) {
            $model->dingIsvOrgId = $map['dingIsvOrgId'];
        }
        if (isset($map['dingCorpId'])) {
            $model->dingCorpId = $map['dingCorpId'];
        }

        return $model;
    }
}
