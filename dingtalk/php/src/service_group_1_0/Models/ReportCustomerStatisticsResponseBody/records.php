<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\ReportCustomerStatisticsResponseBody;

use AlibabaCloud\Tea\Model;

class records extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 1
     *
     * @var int
     */
    public $atRobotCnt;

    /**
     * @example bizXX
     *
     * @var string
     */
    public $bizId;

    /**
     * @description This parameter is required.
     *
     * @example 3
     *
     * @var int
     */
    public $customerCnt;

    /**
     * @description This parameter is required.
     *
     * @example 测试群
     *
     * @var string
     */
    public $groupName;

    /**
     * @description This parameter is required.
     *
     * @example 测试群分组
     *
     * @var string
     */
    public $groupSetName;

    /**
     * @description This parameter is required.
     *
     * @example 2
     *
     * @var int
     */
    public $loginCnt;

    /**
     * @description This parameter is required.
     *
     * @example 1
     *
     * @var int
     */
    public $openConvCnt;

    /**
     * @description This parameter is required.
     *
     * @example cidXXX
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @description This parameter is required.
     *
     * @example iSoqrhLQDtK
     *
     * @var string
     */
    public $openGroupSetId;

    /**
     * @description This parameter is required.
     *
     * @example 2
     *
     * @var int
     */
    public $sendMsgCnt;

    /**
     * @description This parameter is required.
     *
     * @example 2
     *
     * @var int
     */
    public $senderCnt;
    protected $_name = [
        'atRobotCnt'         => 'atRobotCnt',
        'bizId'              => 'bizId',
        'customerCnt'        => 'customerCnt',
        'groupName'          => 'groupName',
        'groupSetName'       => 'groupSetName',
        'loginCnt'           => 'loginCnt',
        'openConvCnt'        => 'openConvCnt',
        'openConversationId' => 'openConversationId',
        'openGroupSetId'     => 'openGroupSetId',
        'sendMsgCnt'         => 'sendMsgCnt',
        'senderCnt'          => 'senderCnt',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->atRobotCnt) {
            $res['atRobotCnt'] = $this->atRobotCnt;
        }
        if (null !== $this->bizId) {
            $res['bizId'] = $this->bizId;
        }
        if (null !== $this->customerCnt) {
            $res['customerCnt'] = $this->customerCnt;
        }
        if (null !== $this->groupName) {
            $res['groupName'] = $this->groupName;
        }
        if (null !== $this->groupSetName) {
            $res['groupSetName'] = $this->groupSetName;
        }
        if (null !== $this->loginCnt) {
            $res['loginCnt'] = $this->loginCnt;
        }
        if (null !== $this->openConvCnt) {
            $res['openConvCnt'] = $this->openConvCnt;
        }
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }
        if (null !== $this->openGroupSetId) {
            $res['openGroupSetId'] = $this->openGroupSetId;
        }
        if (null !== $this->sendMsgCnt) {
            $res['sendMsgCnt'] = $this->sendMsgCnt;
        }
        if (null !== $this->senderCnt) {
            $res['senderCnt'] = $this->senderCnt;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return records
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['atRobotCnt'])) {
            $model->atRobotCnt = $map['atRobotCnt'];
        }
        if (isset($map['bizId'])) {
            $model->bizId = $map['bizId'];
        }
        if (isset($map['customerCnt'])) {
            $model->customerCnt = $map['customerCnt'];
        }
        if (isset($map['groupName'])) {
            $model->groupName = $map['groupName'];
        }
        if (isset($map['groupSetName'])) {
            $model->groupSetName = $map['groupSetName'];
        }
        if (isset($map['loginCnt'])) {
            $model->loginCnt = $map['loginCnt'];
        }
        if (isset($map['openConvCnt'])) {
            $model->openConvCnt = $map['openConvCnt'];
        }
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['openGroupSetId'])) {
            $model->openGroupSetId = $map['openGroupSetId'];
        }
        if (isset($map['sendMsgCnt'])) {
            $model->sendMsgCnt = $map['sendMsgCnt'];
        }
        if (isset($map['senderCnt'])) {
            $model->senderCnt = $map['senderCnt'];
        }

        return $model;
    }
}
