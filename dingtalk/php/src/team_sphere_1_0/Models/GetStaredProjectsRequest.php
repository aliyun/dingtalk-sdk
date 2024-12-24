<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetStaredProjectsRequest extends Model
{
    /**
     * @example 10
     *
     * @var int
     */
    public $maxResults;

    /**
     * @var string
     */
    public $nextToken;

    /**
     * @example updated:desc
     *
     * @var string
     */
    public $sortBy;
    protected $_name = [
        'maxResults' => 'maxResults',
        'nextToken'  => 'nextToken',
        'sortBy'     => 'sortBy',
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
        if (null !== $this->sortBy) {
            $res['sortBy'] = $this->sortBy;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetStaredProjectsRequest
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
        if (isset($map['sortBy'])) {
            $model->sortBy = $map['sortBy'];
        }

        return $model;
    }
}
