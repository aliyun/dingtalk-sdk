<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\ReportCustomerStatisticsResponseBody;

use AlibabaCloud\Tea\Model;

class records extends Model
{
    /**
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
     * @example 3
     *
     * @var int
     */
    public $customerCnt;

    /**
     * @example 测试群
     *
     * @var string
     */
    public $groupName;

    /**
     * @example 测试群分组
     *
     * @var string
     */
    public $groupSetName;

    /**
     * @example 2
     *
     * @var int
     */
    public $loginCnt;

    /**
     * @example 1
     *
     * @var int
     */
    public $openConvCnt;

    /**
     * @example cidXXX
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @example iSoqrhLQDtK
     *
     * @var string
     */
    public $openGroupSetId;

    /**
     * @example 2
     *
     * @var int
     */
    public $sendMsgCnt;

    /**
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
