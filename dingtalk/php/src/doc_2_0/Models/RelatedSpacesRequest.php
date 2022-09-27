<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models;

use AlibabaCloud\Tea\Model;

class RelatedSpacesRequest extends Model
{
    /**
     * @description 每页最大条目数，最大值100。
     *
     * @var int
     */
    public $maxResults;

    /**
     * @description 分页游标，第一页可不传。
     *
     * @var string
     */
    public $nextToken;

    /**
     * @description 操作用户unionId。
     *
     * @var string
     */
    public $operatorId;

    /**
     * @description 小组id。
     *
     * @var string
     */
    public $teamId;
    protected $_name = [
        'maxResults' => 'maxResults',
        'nextToken'  => 'nextToken',
        'operatorId' => 'operatorId',
        'teamId'     => 'teamId',
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
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }
        if (null !== $this->teamId) {
            $res['teamId'] = $this->teamId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return RelatedSpacesRequest
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
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }
        if (isset($map['teamId'])) {
            $model->teamId = $map['teamId'];
        }

        return $model;
    }
}
