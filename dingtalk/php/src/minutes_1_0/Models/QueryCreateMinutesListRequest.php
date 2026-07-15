<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryCreateMinutesListRequest extends Model
{
    /**
     * @var int
     */
    public $gmtCreateEnd;

    /**
     * @var int
     */
    public $gmtCreateStart;

    /**
     * @description This parameter is required.
     *
     * @example 20
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
    public $unionId;
    protected $_name = [
        'gmtCreateEnd' => 'gmtCreateEnd',
        'gmtCreateStart' => 'gmtCreateStart',
        'maxResults' => 'maxResults',
        'nextToken' => 'nextToken',
        'unionId' => 'unionId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->gmtCreateEnd) {
            $res['gmtCreateEnd'] = $this->gmtCreateEnd;
        }
        if (null !== $this->gmtCreateStart) {
            $res['gmtCreateStart'] = $this->gmtCreateStart;
        }
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryCreateMinutesListRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['gmtCreateEnd'])) {
            $model->gmtCreateEnd = $map['gmtCreateEnd'];
        }
        if (isset($map['gmtCreateStart'])) {
            $model->gmtCreateStart = $map['gmtCreateStart'];
        }
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
