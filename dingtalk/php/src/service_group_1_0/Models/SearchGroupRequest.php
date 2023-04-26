<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\Tea\Model;

class SearchGroupRequest extends Model
{
    /**
     * @example 钉钉专属服务群
     *
     * @var string
     */
    public $groupName;

    /**
     * @example 10
     *
     * @var int
     */
    public $maxResults;

    /**
     * @example CXiw
     *
     * @var string
     */
    public $nextToken;

    /**
     * @example cidxxxx==
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @example sjfuwid
     *
     * @var string
     */
    public $openGroupSetId;

    /**
     * @example jfuwida
     *
     * @var string
     */
    public $openTeamId;

    /**
     * @example 目前支持PAGE 和 SCROLL，默认PAGE类型
     *
     * @var string
     */
    public $searchType;
    protected $_name = [
        'groupName'          => 'groupName',
        'maxResults'         => 'maxResults',
        'nextToken'          => 'nextToken',
        'openConversationId' => 'openConversationId',
        'openGroupSetId'     => 'openGroupSetId',
        'openTeamId'         => 'openTeamId',
        'searchType'         => 'searchType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->groupName) {
            $res['groupName'] = $this->groupName;
        }
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }
        if (null !== $this->openGroupSetId) {
            $res['openGroupSetId'] = $this->openGroupSetId;
        }
        if (null !== $this->openTeamId) {
            $res['openTeamId'] = $this->openTeamId;
        }
        if (null !== $this->searchType) {
            $res['searchType'] = $this->searchType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SearchGroupRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['groupName'])) {
            $model->groupName = $map['groupName'];
        }
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['openGroupSetId'])) {
            $model->openGroupSetId = $map['openGroupSetId'];
        }
        if (isset($map['openTeamId'])) {
            $model->openTeamId = $map['openTeamId'];
        }
        if (isset($map['searchType'])) {
            $model->searchType = $map['searchType'];
        }

        return $model;
    }
}
