<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models;

use AlibabaCloud\Tea\Model;

class QueryRecentListRequest extends Model
{
    /**
     * @var int
     */
    public $creatorType;

    /**
     * @var int
     */
    public $fileType;

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
     * @description This parameter is required.
     *
     * @var string
     */
    public $operatorId;

    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $recentType;
    protected $_name = [
        'creatorType' => 'creatorType',
        'fileType'    => 'fileType',
        'maxResults'  => 'maxResults',
        'nextToken'   => 'nextToken',
        'operatorId'  => 'operatorId',
        'recentType'  => 'recentType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->creatorType) {
            $res['creatorType'] = $this->creatorType;
        }
        if (null !== $this->fileType) {
            $res['fileType'] = $this->fileType;
        }
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }
        if (null !== $this->recentType) {
            $res['recentType'] = $this->recentType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryRecentListRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['creatorType'])) {
            $model->creatorType = $map['creatorType'];
        }
        if (isset($map['fileType'])) {
            $model->fileType = $map['fileType'];
        }
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }
        if (isset($map['recentType'])) {
            $model->recentType = $map['recentType'];
        }

        return $model;
    }
}
