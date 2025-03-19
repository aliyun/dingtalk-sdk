<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryMicroAppViewRequest extends Model
{
    /**
     * @var int[]
     */
    public $tenantIdList;

    /**
     * @example 2163515669935611
     *
     * @var string
     */
    public $viewUserId;
    protected $_name = [
        'tenantIdList' => 'tenantIdList',
        'viewUserId' => 'viewUserId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->tenantIdList) {
            $res['tenantIdList'] = $this->tenantIdList;
        }
        if (null !== $this->viewUserId) {
            $res['viewUserId'] = $this->viewUserId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryMicroAppViewRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['tenantIdList'])) {
            if (!empty($map['tenantIdList'])) {
                $model->tenantIdList = $map['tenantIdList'];
            }
        }
        if (isset($map['viewUserId'])) {
            $model->viewUserId = $map['viewUserId'];
        }

        return $model;
    }
}
