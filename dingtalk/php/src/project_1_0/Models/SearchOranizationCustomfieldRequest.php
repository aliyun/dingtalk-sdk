<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models;

use AlibabaCloud\Tea\Model;

class SearchOranizationCustomfieldRequest extends Model
{
    /**
     * @example 60a2187eb72xxxxxxx
     *
     * @var string
     */
    public $customFieldIds;

    /**
     * @example 60a2187eb72xxxxxxx
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
     * @example 60a2187eb72xxxxxxx,60a2187eb72xxxxxxx
     *
     * @var string
     */
    public $projectIds;

    /**
     * @example 自定义字段1
     *
     * @var string
     */
    public $query;
    protected $_name = [
        'customFieldIds' => 'customFieldIds',
        'instanceIds'    => 'instanceIds',
        'maxResults'     => 'maxResults',
        'nextToken'      => 'nextToken',
        'projectIds'     => 'projectIds',
        'query'          => 'query',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->customFieldIds) {
            $res['customFieldIds'] = $this->customFieldIds;
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
        if (null !== $this->projectIds) {
            $res['projectIds'] = $this->projectIds;
        }
        if (null !== $this->query) {
            $res['query'] = $this->query;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SearchOranizationCustomfieldRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['customFieldIds'])) {
            $model->customFieldIds = $map['customFieldIds'];
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
        if (isset($map['projectIds'])) {
            $model->projectIds = $map['projectIds'];
        }
        if (isset($map['query'])) {
            $model->query = $map['query'];
        }

        return $model;
    }
}
