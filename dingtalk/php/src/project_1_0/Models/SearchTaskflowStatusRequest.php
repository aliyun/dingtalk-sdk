<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models;

use AlibabaCloud\Tea\Model;

class SearchTaskflowStatusRequest extends Model
{
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
     * @example 未开始
     *
     * @var string
     */
    public $query;

    /**
     * @example 60a2187eb72xxxxxxx,60a2187eb72xxxxxxx
     *
     * @var string
     */
    public $tfIds;

    /**
     * @example 60a2187eb72xxxxxxx,60a2187eb72xxxxxxx
     *
     * @var string
     */
    public $tfsIds;
    protected $_name = [
        'maxResults' => 'maxResults',
        'nextToken'  => 'nextToken',
        'query'      => 'query',
        'tfIds'      => 'tfIds',
        'tfsIds'     => 'tfsIds',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->query) {
            $res['query'] = $this->query;
        }
        if (null !== $this->tfIds) {
            $res['tfIds'] = $this->tfIds;
        }
        if (null !== $this->tfsIds) {
            $res['tfsIds'] = $this->tfsIds;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SearchTaskflowStatusRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['query'])) {
            $model->query = $map['query'];
        }
        if (isset($map['tfIds'])) {
            $model->tfIds = $map['tfIds'];
        }
        if (isset($map['tfsIds'])) {
            $model->tfsIds = $map['tfsIds'];
        }

        return $model;
    }
}
