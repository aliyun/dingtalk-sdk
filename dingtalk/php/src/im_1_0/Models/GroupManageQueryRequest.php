<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class GroupManageQueryRequest extends Model
{
    /**
     * @example 1652183395772
     *
     * @var int
     */
    public $createdAfter;

    /**
     * @example 53364321
     *
     * @var string
     */
    public $groupId;

    /**
     * @var string[]
     */
    public $groupMemberSamples;

    /**
     * @example 4122134
     *
     * @var string
     */
    public $groupOwner;

    /**
     * @var string[]
     */
    public $groupTitleKeywords;

    /**
     * @example https://h5.dingtalk.com/circle/healthCheckin.html?dtaction=os&corpId=ding91766asjkldhfkjklasdjkfjkhajksdjkfhjkla811&5fd5e=db2ed&cbdbhh=qwertyuiop
     *
     * @var string
     */
    public $groupUrl;

    /**
     * @example 500
     *
     * @var int
     */
    public $maxResults;

    /**
     * @example 1
     *
     * @var int
     */
    public $membersOver;

    /**
     * @example 500
     *
     * @var string
     */
    public $nextToken;

    /**
     * @example cidnvcxzklxv23jhkg412hj==
     *
     * @var string
     */
    public $openConversationId;
    protected $_name = [
        'createdAfter' => 'createdAfter',
        'groupId' => 'groupId',
        'groupMemberSamples' => 'groupMemberSamples',
        'groupOwner' => 'groupOwner',
        'groupTitleKeywords' => 'groupTitleKeywords',
        'groupUrl' => 'groupUrl',
        'maxResults' => 'maxResults',
        'membersOver' => 'membersOver',
        'nextToken' => 'nextToken',
        'openConversationId' => 'openConversationId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->createdAfter) {
            $res['createdAfter'] = $this->createdAfter;
        }
        if (null !== $this->groupId) {
            $res['groupId'] = $this->groupId;
        }
        if (null !== $this->groupMemberSamples) {
            $res['groupMemberSamples'] = $this->groupMemberSamples;
        }
        if (null !== $this->groupOwner) {
            $res['groupOwner'] = $this->groupOwner;
        }
        if (null !== $this->groupTitleKeywords) {
            $res['groupTitleKeywords'] = $this->groupTitleKeywords;
        }
        if (null !== $this->groupUrl) {
            $res['groupUrl'] = $this->groupUrl;
        }
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }
        if (null !== $this->membersOver) {
            $res['membersOver'] = $this->membersOver;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GroupManageQueryRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['createdAfter'])) {
            $model->createdAfter = $map['createdAfter'];
        }
        if (isset($map['groupId'])) {
            $model->groupId = $map['groupId'];
        }
        if (isset($map['groupMemberSamples'])) {
            if (!empty($map['groupMemberSamples'])) {
                $model->groupMemberSamples = $map['groupMemberSamples'];
            }
        }
        if (isset($map['groupOwner'])) {
            $model->groupOwner = $map['groupOwner'];
        }
        if (isset($map['groupTitleKeywords'])) {
            if (!empty($map['groupTitleKeywords'])) {
                $model->groupTitleKeywords = $map['groupTitleKeywords'];
            }
        }
        if (isset($map['groupUrl'])) {
            $model->groupUrl = $map['groupUrl'];
        }
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }
        if (isset($map['membersOver'])) {
            $model->membersOver = $map['membersOver'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }

        return $model;
    }
}
