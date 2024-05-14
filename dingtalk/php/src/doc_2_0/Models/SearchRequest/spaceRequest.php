<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\SearchRequest;

use AlibabaCloud\Tea\Model;

class spaceRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $maxResults;

    /**
     * @var string
     */
    public $nextToken;

    /**
     * @var bool
     */
    public $withTeamInfo;
    protected $_name = [
        'maxResults'   => 'maxResults',
        'nextToken'    => 'nextToken',
        'withTeamInfo' => 'withTeamInfo',
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
        if (null !== $this->withTeamInfo) {
            $res['withTeamInfo'] = $this->withTeamInfo;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return spaceRequest
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
        if (isset($map['withTeamInfo'])) {
            $model->withTeamInfo = $map['withTeamInfo'];
        }

        return $model;
    }
}
