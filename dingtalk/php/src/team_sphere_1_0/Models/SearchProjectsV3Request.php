<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models;

use AlibabaCloud\Tea\Model;

class SearchProjectsV3Request extends Model
{
    /**
     * @var bool
     */
    public $includeTemplate;

    /**
     * @var int
     */
    public $maxResults;

    /**
     * @var string
     */
    public $name;

    /**
     * @var string
     */
    public $nextToken;

    /**
     * @var string
     */
    public $projectIds;

    /**
     * @var string
     */
    public $sourceId;

    /**
     * @description This parameter is required.
     *
     * @example 0517xxx
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'includeTemplate' => 'includeTemplate',
        'maxResults'      => 'maxResults',
        'name'            => 'name',
        'nextToken'       => 'nextToken',
        'projectIds'      => 'projectIds',
        'sourceId'        => 'sourceId',
        'userId'          => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->includeTemplate) {
            $res['includeTemplate'] = $this->includeTemplate;
        }
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->projectIds) {
            $res['projectIds'] = $this->projectIds;
        }
        if (null !== $this->sourceId) {
            $res['sourceId'] = $this->sourceId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SearchProjectsV3Request
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['includeTemplate'])) {
            $model->includeTemplate = $map['includeTemplate'];
        }
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['projectIds'])) {
            $model->projectIds = $map['projectIds'];
        }
        if (isset($map['sourceId'])) {
            $model->sourceId = $map['sourceId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
