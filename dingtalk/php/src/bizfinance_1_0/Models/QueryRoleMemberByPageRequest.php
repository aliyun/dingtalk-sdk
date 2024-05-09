<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryRoleMemberByPageRequest extends Model
{
    /**
     * @example COM_DEFAULT
     *
     * @var string
     */
    public $companyCode;

    /**
     * @example 20
     *
     * @var string
     */
    public $maxResults;

    /**
     * @example 0
     *
     * @var string
     */
    public $nextToken;

    /**
     * @example financeManager
     *
     * @var string
     */
    public $roleCode;
    protected $_name = [
        'companyCode' => 'companyCode',
        'maxResults'  => 'maxResults',
        'nextToken'   => 'nextToken',
        'roleCode'    => 'roleCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->companyCode) {
            $res['companyCode'] = $this->companyCode;
        }
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->roleCode) {
            $res['roleCode'] = $this->roleCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryRoleMemberByPageRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['companyCode'])) {
            $model->companyCode = $map['companyCode'];
        }
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['roleCode'])) {
            $model->roleCode = $map['roleCode'];
        }

        return $model;
    }
}
