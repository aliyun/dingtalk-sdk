<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class GroupManageQueryRequest extends Model
{
    /**
     * @description 建群时间不早于（辅助性条件，结合非排他条件使用）
     *
     * @var int
     */
    public $createdAfter;

    /**
     * @description 群号
     *
     * @var string
     */
    public $groupId;

    /**
     * @description 群成员样例工号列表
     *
     * @var string[]
     */
    public $groupMemberSamples;

    /**
     * @description 群主工号
     *
     * @var string
     */
    public $groupOwner;

    /**
     * @description 群标题关键词列表
     *
     * @var string[]
     */
    public $groupTitleKeywords;

    /**
     * @description 群链接
     *
     * @var string
     */
    public $groupUrl;

    /**
     * @description 分页拉取的页大小, 最大不可超过1000
     *
     * @var int
     */
    public $maxResults;

    /**
     * @description 群成员数下限（辅助性条件，结合非排他条件使用）
     *
     * @var int
     */
    public $membersOver;

    /**
     * @description 分页拉取游标, 若不指定，则从头开始拉
     *
     * @var string
     */
    public $nextToken;

    /**
     * @description 开放群id
     *
     * @var string
     */
    public $openConversationId;
    protected $_name = [
        'createdAfter'       => 'createdAfter',
        'groupId'            => 'groupId',
        'groupMemberSamples' => 'groupMemberSamples',
        'groupOwner'         => 'groupOwner',
        'groupTitleKeywords' => 'groupTitleKeywords',
        'groupUrl'           => 'groupUrl',
        'maxResults'         => 'maxResults',
        'membersOver'        => 'membersOver',
        'nextToken'          => 'nextToken',
        'openConversationId' => 'openConversationId',
    ];

    public function validate()
    {
    }

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
