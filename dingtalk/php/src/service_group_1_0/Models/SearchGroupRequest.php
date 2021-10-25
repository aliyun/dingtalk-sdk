<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\Tea\Model;

class SearchGroupRequest extends Model
{
    /**
     * @var int
     */
    public $dingIsvOrgId;

    /**
     * @var int
     */
    public $dingOrgId;

    /**
     * @var string
     */
    public $dingSuiteKey;

    /**
     * @var int
     */
    public $dingTokenGrantType;

    /**
     * @description 开放群ID
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @description 群名称
     *
     * @var string
     */
    public $groupName;

    /**
     * @description 开放团队ID
     *
     * @var string
     */
    public $openTeamId;

    /**
     * @description 开群组ID
     *
     * @var string
     */
    public $openGroupSetId;

    /**
     * @description 用来标记当前开始读取的位置，置空表示从头开始。
     *
     * @var string
     */
    public $nextToken;

    /**
     * @description 本次读取的最大数据记录数量，此参数为可选参数，用户传入为空时，应该有默认值。应设置最大值限制，最大不超过100
     *
     * @var int
     */
    public $maxResults;

    /**
     * @description 搜索类型
     *
     * @var string
     */
    public $searchType;
    protected $_name = [
        'dingIsvOrgId'       => 'dingIsvOrgId',
        'dingOrgId'          => 'dingOrgId',
        'dingSuiteKey'       => 'dingSuiteKey',
        'dingTokenGrantType' => 'dingTokenGrantType',
        'openConversationId' => 'openConversationId',
        'groupName'          => 'groupName',
        'openTeamId'         => 'openTeamId',
        'openGroupSetId'     => 'openGroupSetId',
        'nextToken'          => 'nextToken',
        'maxResults'         => 'maxResults',
        'searchType'         => 'searchType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->dingIsvOrgId) {
            $res['dingIsvOrgId'] = $this->dingIsvOrgId;
        }
        if (null !== $this->dingOrgId) {
            $res['dingOrgId'] = $this->dingOrgId;
        }
        if (null !== $this->dingSuiteKey) {
            $res['dingSuiteKey'] = $this->dingSuiteKey;
        }
        if (null !== $this->dingTokenGrantType) {
            $res['dingTokenGrantType'] = $this->dingTokenGrantType;
        }
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }
        if (null !== $this->groupName) {
            $res['groupName'] = $this->groupName;
        }
        if (null !== $this->openTeamId) {
            $res['openTeamId'] = $this->openTeamId;
        }
        if (null !== $this->openGroupSetId) {
            $res['openGroupSetId'] = $this->openGroupSetId;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
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
        if (isset($map['dingIsvOrgId'])) {
            $model->dingIsvOrgId = $map['dingIsvOrgId'];
        }
        if (isset($map['dingOrgId'])) {
            $model->dingOrgId = $map['dingOrgId'];
        }
        if (isset($map['dingSuiteKey'])) {
            $model->dingSuiteKey = $map['dingSuiteKey'];
        }
        if (isset($map['dingTokenGrantType'])) {
            $model->dingTokenGrantType = $map['dingTokenGrantType'];
        }
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['groupName'])) {
            $model->groupName = $map['groupName'];
        }
        if (isset($map['openTeamId'])) {
            $model->openTeamId = $map['openTeamId'];
        }
        if (isset($map['openGroupSetId'])) {
            $model->openGroupSetId = $map['openGroupSetId'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }
        if (isset($map['searchType'])) {
            $model->searchType = $map['searchType'];
        }

        return $model;
    }
}
