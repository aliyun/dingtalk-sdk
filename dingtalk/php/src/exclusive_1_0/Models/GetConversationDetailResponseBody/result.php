<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetConversationDetailResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example -1
     *
     * @var int
     */
    public $categoryId;

    /**
     * @example categoryName
     *
     * @var string
     */
    public $categoryName;

    /**
     * @var string
     */
    public $groupCode;

    /**
     * @example 5
     *
     * @var int
     */
    public $groupMembersCnt;

    /**
     * @example 5
     *
     * @var string
     */
    public $groupName;

    /**
     * @example groupOwnerName
     *
     * @var string
     */
    public $groupOwnerName;

    /**
     * @example groupOwnerUserId
     *
     * @var string
     */
    public $groupOwnerUserId;

    /**
     * @var bool
     */
    public $isKpConversation;

    /**
     * @example 1
     *
     * @var int
     */
    public $manageSign;

    /**
     * @description This parameter is required.
     *
     * @example cidxxx
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @example 1
     *
     * @var int
     */
    public $order;

    /**
     * @var int
     */
    public $status;
    protected $_name = [
        'categoryId'         => 'categoryId',
        'categoryName'       => 'categoryName',
        'groupCode'          => 'groupCode',
        'groupMembersCnt'    => 'groupMembersCnt',
        'groupName'          => 'groupName',
        'groupOwnerName'     => 'groupOwnerName',
        'groupOwnerUserId'   => 'groupOwnerUserId',
        'isKpConversation'   => 'isKpConversation',
        'manageSign'         => 'manageSign',
        'openConversationId' => 'openConversationId',
        'order'              => 'order',
        'status'             => 'status',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->categoryId) {
            $res['categoryId'] = $this->categoryId;
        }
        if (null !== $this->categoryName) {
            $res['categoryName'] = $this->categoryName;
        }
        if (null !== $this->groupCode) {
            $res['groupCode'] = $this->groupCode;
        }
        if (null !== $this->groupMembersCnt) {
            $res['groupMembersCnt'] = $this->groupMembersCnt;
        }
        if (null !== $this->groupName) {
            $res['groupName'] = $this->groupName;
        }
        if (null !== $this->groupOwnerName) {
            $res['groupOwnerName'] = $this->groupOwnerName;
        }
        if (null !== $this->groupOwnerUserId) {
            $res['groupOwnerUserId'] = $this->groupOwnerUserId;
        }
        if (null !== $this->isKpConversation) {
            $res['isKpConversation'] = $this->isKpConversation;
        }
        if (null !== $this->manageSign) {
            $res['manageSign'] = $this->manageSign;
        }
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }
        if (null !== $this->order) {
            $res['order'] = $this->order;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['categoryId'])) {
            $model->categoryId = $map['categoryId'];
        }
        if (isset($map['categoryName'])) {
            $model->categoryName = $map['categoryName'];
        }
        if (isset($map['groupCode'])) {
            $model->groupCode = $map['groupCode'];
        }
        if (isset($map['groupMembersCnt'])) {
            $model->groupMembersCnt = $map['groupMembersCnt'];
        }
        if (isset($map['groupName'])) {
            $model->groupName = $map['groupName'];
        }
        if (isset($map['groupOwnerName'])) {
            $model->groupOwnerName = $map['groupOwnerName'];
        }
        if (isset($map['groupOwnerUserId'])) {
            $model->groupOwnerUserId = $map['groupOwnerUserId'];
        }
        if (isset($map['isKpConversation'])) {
            $model->isKpConversation = $map['isKpConversation'];
        }
        if (isset($map['manageSign'])) {
            $model->manageSign = $map['manageSign'];
        }
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['order'])) {
            $model->order = $map['order'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }

        return $model;
    }
}
