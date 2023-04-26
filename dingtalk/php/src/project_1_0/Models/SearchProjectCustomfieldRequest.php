<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models;

use AlibabaCloud\Tea\Model;

class SearchProjectCustomfieldRequest extends Model
{
    /**
     * @example 60a2187eb72xxxxxxx,60a2187eb72xxxxxxx
     *
     * @var string
     */
    public $customfieldIds;

    /**
     * @example 60a2187eb72xxxxxxx,60a2187eb72xxxxxxx
     *
     * @var string
     */
    public $instanceIds;

    /**
     * @example 10
     *
     * @var int
     */
    public $maxResults;

    /**
     * @example f279e812xxxxxx
     *
     * @var string
     */
    public $nextToken;

    /**
     * @example 自定义字段名1
     *
     * @var string
     */
    public $query;

    /**
     * @example 60a2187eb72xxxxxxx
     *
     * @var string
     */
    public $scenariofieldconfigId;

    /**
     * @example all
     *
     * @var string
     */
    public $scope;
    protected $_name = [
        'customfieldIds'        => 'customfieldIds',
        'instanceIds'           => 'instanceIds',
        'maxResults'            => 'maxResults',
        'nextToken'             => 'nextToken',
        'query'                 => 'query',
        'scenariofieldconfigId' => 'scenariofieldconfigId',
        'scope'                 => 'scope',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->customfieldIds) {
            $res['customfieldIds'] = $this->customfieldIds;
        }
        if (null !== $this->instanceIds) {
            $res['instanceIds'] = $this->instanceIds;
        }
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->query) {
            $res['query'] = $this->query;
        }
        if (null !== $this->scenariofieldconfigId) {
            $res['scenariofieldconfigId'] = $this->scenariofieldconfigId;
        }
        if (null !== $this->scope) {
            $res['scope'] = $this->scope;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SearchProjectCustomfieldRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['customfieldIds'])) {
            $model->customfieldIds = $map['customfieldIds'];
        }
        if (isset($map['instanceIds'])) {
            $model->instanceIds = $map['instanceIds'];
        }
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['query'])) {
            $model->query = $map['query'];
        }
        if (isset($map['scenariofieldconfigId'])) {
            $model->scenariofieldconfigId = $map['scenariofieldconfigId'];
        }
        if (isset($map['scope'])) {
            $model->scope = $map['scope'];
        }

        return $model;
    }
}
