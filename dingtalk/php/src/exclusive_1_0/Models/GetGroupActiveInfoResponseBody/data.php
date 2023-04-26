<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetGroupActiveInfoResponseBody;

use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @var string
     */
    public $dingGroupId;

    /**
     * @var string
     */
    public $groupCreateTime;

    /**
     * @var string
     */
    public $groupCreateUserId;

    /**
     * @var string
     */
    public $groupCreateUserName;

    /**
     * @var string
     */
    public $groupName;

    /**
     * @var int
     */
    public $groupType;

    /**
     * @var int
     */
    public $groupUserCnt1d;

    /**
     * @var int
     */
    public $openConvUv1d;

    /**
     * @var int
     */
    public $sendMessageCnt1d;

    /**
     * @var int
     */
    public $sendMessageUserCnt1d;

    /**
     * @var string
     */
    public $statDate;
    protected $_name = [
        'dingGroupId'          => 'dingGroupId',
        'groupCreateTime'      => 'groupCreateTime',
        'groupCreateUserId'    => 'groupCreateUserId',
        'groupCreateUserName'  => 'groupCreateUserName',
        'groupName'            => 'groupName',
        'groupType'            => 'groupType',
        'groupUserCnt1d'       => 'groupUserCnt1d',
        'openConvUv1d'         => 'openConvUv1d',
        'sendMessageCnt1d'     => 'sendMessageCnt1d',
        'sendMessageUserCnt1d' => 'sendMessageUserCnt1d',
        'statDate'             => 'statDate',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->dingGroupId) {
            $res['dingGroupId'] = $this->dingGroupId;
        }
        if (null !== $this->groupCreateTime) {
            $res['groupCreateTime'] = $this->groupCreateTime;
        }
        if (null !== $this->groupCreateUserId) {
            $res['groupCreateUserId'] = $this->groupCreateUserId;
        }
        if (null !== $this->groupCreateUserName) {
            $res['groupCreateUserName'] = $this->groupCreateUserName;
        }
        if (null !== $this->groupName) {
            $res['groupName'] = $this->groupName;
        }
        if (null !== $this->groupType) {
            $res['groupType'] = $this->groupType;
        }
        if (null !== $this->groupUserCnt1d) {
            $res['groupUserCnt1d'] = $this->groupUserCnt1d;
        }
        if (null !== $this->openConvUv1d) {
            $res['openConvUv1d'] = $this->openConvUv1d;
        }
        if (null !== $this->sendMessageCnt1d) {
            $res['sendMessageCnt1d'] = $this->sendMessageCnt1d;
        }
        if (null !== $this->sendMessageUserCnt1d) {
            $res['sendMessageUserCnt1d'] = $this->sendMessageUserCnt1d;
        }
        if (null !== $this->statDate) {
            $res['statDate'] = $this->statDate;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return data
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dingGroupId'])) {
            $model->dingGroupId = $map['dingGroupId'];
        }
        if (isset($map['groupCreateTime'])) {
            $model->groupCreateTime = $map['groupCreateTime'];
        }
        if (isset($map['groupCreateUserId'])) {
            $model->groupCreateUserId = $map['groupCreateUserId'];
        }
        if (isset($map['groupCreateUserName'])) {
            $model->groupCreateUserName = $map['groupCreateUserName'];
        }
        if (isset($map['groupName'])) {
            $model->groupName = $map['groupName'];
        }
        if (isset($map['groupType'])) {
            $model->groupType = $map['groupType'];
        }
        if (isset($map['groupUserCnt1d'])) {
            $model->groupUserCnt1d = $map['groupUserCnt1d'];
        }
        if (isset($map['openConvUv1d'])) {
            $model->openConvUv1d = $map['openConvUv1d'];
        }
        if (isset($map['sendMessageCnt1d'])) {
            $model->sendMessageCnt1d = $map['sendMessageCnt1d'];
        }
        if (isset($map['sendMessageUserCnt1d'])) {
            $model->sendMessageUserCnt1d = $map['sendMessageUserCnt1d'];
        }
        if (isset($map['statDate'])) {
            $model->statDate = $map['statDate'];
        }

        return $model;
    }
}
