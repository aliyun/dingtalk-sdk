<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryJobRanksRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $maxResults;

    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $nextToken;

    /**
     * @var string
     */
    public $rankCategoryId;

    /**
     * @var string
     */
    public $rankCode;

    /**
     * @var string
     */
    public $rankName;
    protected $_name = [
        'maxResults'     => 'maxResults',
        'nextToken'      => 'nextToken',
        'rankCategoryId' => 'rankCategoryId',
        'rankCode'       => 'rankCode',
        'rankName'       => 'rankName',
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
        if (null !== $this->rankCategoryId) {
            $res['rankCategoryId'] = $this->rankCategoryId;
        }
        if (null !== $this->rankCode) {
            $res['rankCode'] = $this->rankCode;
        }
        if (null !== $this->rankName) {
            $res['rankName'] = $this->rankName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryJobRanksRequest
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
        if (isset($map['rankCategoryId'])) {
            $model->rankCategoryId = $map['rankCategoryId'];
        }
        if (isset($map['rankCode'])) {
            $model->rankCode = $map['rankCode'];
        }
        if (isset($map['rankName'])) {
            $model->rankName = $map['rankName'];
        }

        return $model;
    }
}
