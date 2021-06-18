<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetEmpsByOrgIdRequest extends Model
{
    /**
     * @var int
     */
    public $nextToken;

    /**
     * @var int
     */
    public $maxResults;

    /**
     * @var bool
     */
    public $needDept;
    protected $_name = [
        'nextToken'  => 'nextToken',
        'maxResults' => 'maxResults',
        'needDept'   => 'needDept',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }
        if (null !== $this->needDept) {
            $res['needDept'] = $this->needDept;
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
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }
        if (isset($map['needDept'])) {
            $model->needDept = $map['needDept'];
        }

        return $model;
    }
}
