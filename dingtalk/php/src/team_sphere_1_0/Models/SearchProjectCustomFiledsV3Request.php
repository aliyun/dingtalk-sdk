<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models;

use AlibabaCloud\Tea\Model;

class SearchProjectCustomFiledsV3Request extends Model
{
    /**
     * @var string
     */
    public $cfIds;

    /**
     * @var int
     */
    public $maxResults;

    /**
     * @var string
     */
    public $nextToken;

    /**
     * @var string
     */
    public $sfcId;
    protected $_name = [
        'cfIds' => 'cfIds',
        'maxResults' => 'maxResults',
        'nextToken' => 'nextToken',
        'sfcId' => 'sfcId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->cfIds) {
            $res['cfIds'] = $this->cfIds;
        }
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->sfcId) {
            $res['sfcId'] = $this->sfcId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SearchProjectCustomFiledsV3Request
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['cfIds'])) {
            $model->cfIds = $map['cfIds'];
        }
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['sfcId'])) {
            $model->sfcId = $map['sfcId'];
        }

        return $model;
    }
}
