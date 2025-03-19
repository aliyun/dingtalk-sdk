<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vswform_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListFormInstancesRequest extends Model
{
    /**
     * @example 2019-01-01
     *
     * @var string
     */
    public $actionDate;

    /**
     * @example 0
     *
     * @var int
     */
    public $bizType;

    /**
     * @description This parameter is required.
     *
     * @example 15
     *
     * @var int
     */
    public $maxResults;

    /**
     * @description This parameter is required.
     *
     * @example 0
     *
     * @var int
     */
    public $nextToken;
    protected $_name = [
        'actionDate' => 'actionDate',
        'bizType' => 'bizType',
        'maxResults' => 'maxResults',
        'nextToken' => 'nextToken',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->actionDate) {
            $res['actionDate'] = $this->actionDate;
        }
        if (null !== $this->bizType) {
            $res['bizType'] = $this->bizType;
        }
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListFormInstancesRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['actionDate'])) {
            $model->actionDate = $map['actionDate'];
        }
        if (isset($map['bizType'])) {
            $model->bizType = $map['bizType'];
        }
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }

        return $model;
    }
}
