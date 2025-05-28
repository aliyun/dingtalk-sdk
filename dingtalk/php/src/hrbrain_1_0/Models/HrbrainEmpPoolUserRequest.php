<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models;

use AlibabaCloud\Tea\Model;

class HrbrainEmpPoolUserRequest extends Model
{
    /**
     * @var int
     */
    public $maxResults;

    /**
     * @var int
     */
    public $nextToken;

    /**
     * @var string
     */
    public $poolCode;
    protected $_name = [
        'maxResults' => 'maxResults',
        'nextToken' => 'nextToken',
        'poolCode' => 'poolCode',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->poolCode) {
            $res['poolCode'] = $this->poolCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return HrbrainEmpPoolUserRequest
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
        if (isset($map['poolCode'])) {
            $model->poolCode = $map['poolCode'];
        }

        return $model;
    }
}
