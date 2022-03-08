<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetEmpsByOrgIdRequest extends Model
{
    /**
     * @var int
     */
    public $maxResults;

    /**
     * @var bool
     */
    public $needDept;

    /**
     * @var int
     */
    public $nextToken;
    protected $_name = [
        'maxResults' => 'maxResults',
        'needDept'   => 'needDept',
        'nextToken'  => 'nextToken',
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
        if (null !== $this->needDept) {
            $res['needDept'] = $this->needDept;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetEmpsByOrgIdRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }
        if (isset($map['needDept'])) {
            $model->needDept = $map['needDept'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }

        return $model;
    }
}
